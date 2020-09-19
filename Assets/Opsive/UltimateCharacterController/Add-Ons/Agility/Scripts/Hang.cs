/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

namespace Opsive.UltimateCharacterController.AddOns.Agility
{
    using Opsive.Shared.Events;
    using Opsive.Shared.Game;
    using Opsive.Shared.Utility;
    using Opsive.UltimateCharacterController.Character;
    using Opsive.UltimateCharacterController.Character.Abilities;
    using Opsive.UltimateCharacterController.Input;
    using Opsive.UltimateCharacterController.Objects.CharacterAssist;
    using Opsive.UltimateCharacterController.StateSystem;
    using Opsive.UltimateCharacterController.Utility;
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// The Hang ability allows the character to hang from flat objects. The hang ability is NOT able to climb up any object and is only designed for hanging. 
    /// While hanging the character can:
    /// - Start hanging from the ground or mid jump/fall.
    /// - Start hanging by dropping down onto the hang object.
    /// - Shimmy.
    /// - Shimmy across curved objects.
    /// - Transfer to another hang object in the vertical or horizontal direction.
    /// - Pull up from a hang and stop the ability.
    /// </summary>
    [DefaultStartType(AbilityStartType.ButtonDown)]
    [DefaultStopType(AbilityStopType.ButtonToggle)]
    [DefaultInputName("Action")]
    [DefaultAbilityIndex(104)]
    [DefaultAllowRotationalInput(false)]
    [DefaultUseGravity(AbilityBoolOverride.False)]
    [DefaultUseRootMotionPosition(AbilityBoolOverride.True)]
    [DefaultDetectHorizontalCollisions(AbilityBoolOverride.False)]
    [DefaultDetectVerticalCollisions(AbilityBoolOverride.False)]
    [DefaultCastOffset(0, 0, -0.4f)]
    [DefaultEquippedSlots(0)]
    [DefaultObjectDetection(ObjectDetectionMode.Customcast)]
    [DefaultUseLookDirection(false)]
    [StateSystem.AddState("Airborne", "f3f2b8f35d3c59341b22755edb46ea3f")]
    [StateSystem.AddState("Hang", "bc370e4702c161f43948d7bc20b7fa94")]
    public class Hang : DetectObjectAbilityBase
    {
        /// <summary>
        /// Specifies the current state of the Hang ability.
        /// </summary>
        private enum HangState
        {
            MoveToStart,    // The character is moving into starting position.
            DropToStart,    // The character is dropping to the start position.
            Shimmy,         // The character is shimmying across the object.
            TransferUp,     // The character is transferring vertically up from one hang object to another.
            TransferRight,  // The character is transferring horizontally to the left from one hang object to another.
            TransferLeft,   // The character is transferring horizontally to the right from one hang object to another.
            TransferDown,   // The character is transferring vertically down from one hang object to another.
            PullUp,         // The character is pulling themself up to end the ability.
            None
        }

        /// <summary>
        /// The movements that the ability can perform.
        /// </summary>
        public enum AllowedMovement
        {
            DropDown = 1,           // The character can drop down from above the hang object.
            TransferVertically = 2, // The character can transfer vertically from one hang object to another.
            TransferHorizontal = 4, // The character can transfer horizontally from one hang object to another.
            PullUp = 8,             // The character can pull themselves up to end the ability.
            DropToStop = 16         // The character can drop to stop the ability.
        }

#if UNITY_EDITOR
        [Tooltip("Should debug lines be drawn to the editor indicating the location of the horizontal and vertical casts?")]
        [SerializeField] protected bool m_DrawDebugLines;
#endif
        [Tooltip("Specifies which hang movements the character can perform.")]
        [HideInInspector] [SerializeField] protected AllowedMovement m_AllowedMovements = AllowedMovement.DropDown | AllowedMovement.TransferVertically |
                                                                AllowedMovement.TransferHorizontal | AllowedMovement.PullUp | AllowedMovement.DropToStop;
        [Tooltip("The minimum offset from the character's pivot that the ability can perform a movement.")]
        [SerializeField] protected Vector3 m_MinimumStartOffset = new Vector3(0.6f, 2, -0.4f);
        [Tooltip("The maximum offset from the character's pivot that the ability can perform a movement.")]
        [SerializeField] protected Vector3 m_MaximumStartOffset = new Vector3(2, 3.5f, -0.4f);
        [Tooltip("The offset from the top of the character to the hang object.")]
        [SerializeField] protected Vector3 m_RelativeHangOffset = new Vector3(0, -0.17f, -0.2f);
        [Tooltip("The speed that the character moves towards the starting position.")]
        [SerializeField] protected float m_StartMoveTowardsSpeed = 1;
        [Tooltip("The character can shimmy when the vertical distance between the character and hang object is less than the specified amount.")]
        [SerializeField] protected float m_InPositionShimmyDistance = 0.1f;
        [Tooltip("The name of the state when the character is in hang position.")]
        [SerializeField] protected string m_InPositionStateName = "HangInPosition";
        [Tooltip("The name of the button that will transfer or pull the character up to the next hang state.")]
        [SerializeField] protected string m_MoveUpButtonName;
        [Tooltip("Specifies how sensitive the ability is when determining the next state. A value is 0 is the most sensitive while a value of 1 is the least.")]
        [SerializeField] [Range(0, 1)] protected float m_ChangeStateSensitivity = 0.01f;
        [Tooltip("Offset to detect hang objects when shimmying.")]
        [SerializeField] protected float m_ShimmyOffset = 0.5f;
        [Tooltip("Offset to apply to the hand position relative to the object hit at the hands position.")]
        [SerializeField] protected Vector3 m_HandIKOffset = new Vector3(0, 0, -0.02f);
        [Tooltip("The distance that should be checked to determine if the character can pull up without any obstructing objects.")]
        [SerializeField] protected float m_PullUpCastDistance = 0.5f;
        [Tooltip("Should the ability stop if the jump button is pressed?")]
        [SerializeField] protected bool m_StopHangOnJump = true;

        public AllowedMovement AllowedMovements { get { return m_AllowedMovements; } set { m_AllowedMovements = value; } }
        public Vector3 MinimumStartOffset { get { return m_MinimumStartOffset; } set { m_MinimumStartOffset = value; } }
        public Vector3 MaximumStartOffset { get { return m_MaximumStartOffset; } set { m_MaximumStartOffset = value; } }
        public float StartMoveTowardsSpeed { get { return m_StartMoveTowardsSpeed; } set { m_StartMoveTowardsSpeed = value; } }
        public Vector3 RelativeHangOffset { get { return m_RelativeHangOffset; } set { m_RelativeHangOffset = value; } }
        public float InPositionShimmyDistance { get { return m_InPositionShimmyDistance; } set { m_InPositionShimmyDistance = value; } }
        public string InPositionStateName { get { return m_InPositionStateName; } set { m_InPositionStateName = value; } }
        public string MoveUpButtonName { get { return m_MoveUpButtonName; } set { m_MoveUpButtonName = value; } }
        public float ShimmyOffset { get { return m_ShimmyOffset; } set { m_ShimmyOffset = value; } }
        public float ChangeStateSensitivity { get { return m_ChangeStateSensitivity; } set { m_ChangeStateSensitivity = value; } }
        public Vector3 HandIKOffset { get { return m_HandIKOffset; } set { m_HandIKOffset = value; } }
        public float PullUpCastDistance { get { return m_PullUpCastDistance; } set { m_PullUpCastDistance = value; } }
        public bool StopHangOnJump { get { return m_StopHangOnJump; } set { m_StopHangOnJump = value; } }

        public override bool IsConcurrent { get { return m_HangState == HangState.MoveToStart; } }
        public override int AbilityIntData {
            get {
                // The character should go directly to shimmy instead of playing a starting animation if the ability
                // was started while in the air.
                if (!m_GroundedStart && m_HangState == HangState.MoveToStart) {
                    return (int)HangState.Shimmy;
                }
                return (int)m_HangState;
            }
        }
        public override float AbilityFloatData {
            get {
                if (m_HangState == HangState.DropToStart) {
                    return m_LedgeStrafeDropStart ? 1 : 0;
                }
                return m_CharacterLocomotion.LocalLocomotionVelocity.y;
            }
        }
        public override string AbilityMessageText { get { return m_LedgeStrafeDropStart ? string.Empty : base.AbilityMessageText; } }

        private UltimateCharacterLocomotionHandler m_Handler;
        private Jump m_Jump;
        private CharacterIKBase m_CharacterIK;
        private ActiveInputEvent m_JumpInput;
        private ActiveInputEvent m_MoveUpInput;

        private HangState m_HangState = HangState.None;
        private RaycastHit m_RaycastHit;
        private GameObject m_LastHangObject;
        private bool m_CanChangeVertically;
        private bool m_GroundedStart;
        private bool m_LedgeStrafeDropStart;
        private bool m_TryMoveUp;

        private Dictionary<CharacterIKBase.IKGoal, Vector3> m_IKPositionMap;
        private Dictionary<CharacterIKBase.IKGoal, Quaternion> m_IkRotationMap;

        /// <summary>
        /// Initialize the default values.
        /// </summary>
        public override void Awake()
        {
            base.Awake();

            if (m_ObjectDetection != ObjectDetectionMode.Customcast) {
                Debug.LogError("Error: The Hang ObjectDetectionMode should be set to Customcast.");
                Enabled = false;
                return;
            }

            m_Handler = m_GameObject.GetCachedComponent<UltimateCharacterLocomotionHandler>();
            m_CharacterIK = m_GameObject.GetCachedComponent<CharacterIKBase>();
            m_Jump = m_CharacterLocomotion.GetAbility<Jump>();

            EventHandler.RegisterEvent<bool>(m_GameObject, "OnCharacterGrounded", OnGrounded);
            EventHandler.RegisterEvent<bool>(m_GameObject, "OnCharacterImmediateTransformChange", OnImmediateTransformChange);
            EventHandler.RegisterEvent(m_GameObject, "OnAnimatorHangStartInPosition", OnHangStartInPosition);
            EventHandler.RegisterEvent(m_GameObject, "OnAnimatorHangComplete", OnHangComplete);
        }

        /// <summary>
        /// Called when the ablity is tried to be started. If false is returned then the ability will not be started.
        /// </summary>
        /// <returns>True if the ability can be started.</returns>
        public override bool CanStartAbility()
        {
            if (!base.CanStartAbility()) {
                return false;
            }

            // Determine if there are any vertical objects that the character hang on.
            var castDirection = m_UseLookDirection ? m_LookSource.LookDirection(true) : m_Transform.forward;
            if ((m_DetectedObject = DetermineNextHangObject(HangState.TransferUp, castDirection, out m_RaycastResult)) != null) {
                m_HangState = HangState.MoveToStart;
                return true;
            }

            // If hang can't start because an object is in front of the character, determine if the character can drop down to a hang object.
            if (m_CharacterLocomotion.Grounded && (m_AllowedMovements & AllowedMovement.DropDown) != 0) {
                // Cast a ray towards the character just below the front of the character. If an object is hit then a hang object is beneath the character.
                var position = m_Transform.TransformPoint(0, -0.01f, m_CastDistance);
                if (Physics.Raycast(position, -m_Transform.forward, out m_RaycastResult, m_CastDistance, m_DetectLayers, QueryTriggerInteraction.Ignore)) {
                    // The object must be a valid hang object.
                    var hitObject = m_RaycastResult.collider.gameObject;
                    if (!ValidateObject(hitObject, m_RaycastResult)) {
                        return false;
                    }

                    var raycastNormal = Vector3.ProjectOnPlane(m_RaycastResult.normal, m_CharacterLocomotion.Up).normalized;
                    if (raycastNormal.sqrMagnitude == 0) {
                        return false;
                    }
                    var rotation = Quaternion.LookRotation(-raycastNormal, m_CharacterLocomotion.Up);
                    // The detected object should also exist to the left and the right of the character. This will prevent the character from starting to hang halfway off the edge of a hang object.
                    var raycastOffset = raycastNormal * Mathf.Abs(m_CastOffset.z);
                    if (!Physics.Raycast(m_RaycastResult.point + MathUtility.TransformDirection(Vector3.right * -m_ShimmyOffset, rotation) + raycastOffset,
                        -raycastNormal, m_CastDistance, 1 << hitObject.layer, QueryTriggerInteraction.Ignore)) {
                        return false;
                    }

                    if (!Physics.Raycast(m_RaycastResult.point + MathUtility.TransformDirection(Vector3.right * m_ShimmyOffset, rotation) + raycastOffset,
                        -raycastNormal, m_CastDistance, 1 << hitObject.layer, QueryTriggerInteraction.Ignore)) {
                        return false;
                    }

                    // The detected object is a valid hang object.
                    m_DetectedObject = m_RaycastResult.collider.gameObject;
                    m_HangState = HangState.DropToStart;
                    m_LedgeStrafeDropStart = m_CharacterLocomotion.IsAbilityTypeActive<LedgeStrafe>();
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines if there are any hang objects horizontall or vertically in front of the character.
        /// </summary>
        /// <param name="goalState">The state that the ability is trying to change to.</param>
        /// <param name="castDirection">The direction to determine to look for the hang object.</param>
        /// <param name="raycastHit">The RaycastHit that should be used.</param>
        /// <returns>The GameObject of the found hang object. Can be null.</returns>
        private GameObject DetermineNextHangObject(HangState goalState, Vector3 castDirection, out RaycastHit raycastHit)
        {
            // Perform a capsule cast in front of the character. A capsule cast is used so an entire area can be covered instead of a single point.
            Vector3 firstEndCap, secondEndCap;
            var collisionLayerEnabled = m_CharacterLocomotion.CollisionLayerEnabled;
            m_CharacterLocomotion.EnableColliderCollisionLayer(false);
            var minimumStartOffset = m_MinimumStartOffset;
            var maximumStartOffset = m_MaximumStartOffset;
            if (goalState == HangState.TransferUp || goalState == HangState.TransferDown) {
                minimumStartOffset.x = maximumStartOffset.x = 0;
                if (goalState == HangState.TransferDown) {
                    minimumStartOffset.y = 0;
                    maximumStartOffset.y = m_CharacterLocomotion.Height;
                }

                firstEndCap = m_Transform.TransformPoint(minimumStartOffset);
                secondEndCap = m_Transform.TransformPoint(maximumStartOffset);
            } else {
                minimumStartOffset.y = maximumStartOffset.y = 0;
                if (goalState == HangState.TransferLeft) {
                    minimumStartOffset.x *= -1;
                    maximumStartOffset.x *= -1;
                }

                // The horizontal cast should be based off of the existing raycast hit.
                var horizontalRaycastNormal = Vector3.ProjectOnPlane(m_RaycastResult.normal, m_CharacterLocomotion.Up).normalized;
                var horizontalRaycastRotation = Quaternion.LookRotation(-horizontalRaycastNormal, m_CharacterLocomotion.Up);
                firstEndCap = MathUtility.TransformPoint(m_RaycastResult.point, horizontalRaycastRotation, minimumStartOffset);
                secondEndCap = MathUtility.TransformPoint(m_RaycastResult.point, horizontalRaycastRotation, maximumStartOffset);
            }

            var collision = Physics.CapsuleCast(firstEndCap, secondEndCap, 0.01f, castDirection, out raycastHit, m_CastDistance, m_DetectLayers, QueryTriggerInteraction.Ignore);
#if UNITY_EDITOR
            if (m_DrawDebugLines) {
                Debug.DrawLine(firstEndCap, secondEndCap, Color.black);
            }
#endif
            m_CharacterLocomotion.EnableColliderCollisionLayer(collisionLayerEnabled);
            if (!collision) {
                return null;
            }

            // An object was hit. Determine if it's a valid hang object.
            var hitObject = raycastHit.collider.gameObject;
            if (!ValidateObject(hitObject, raycastHit)) {
                return null;
            }

            // Prevent the character from hanging on the last object hanged on. This will prevent the same object from being detected multiple times.
            if (m_LastHangObject == hitObject) {
                return null;
            }

            // Ensure there is space above the hit object.
            var raycastNormal = Vector3.ProjectOnPlane(raycastHit.normal, m_CharacterLocomotion.Up).normalized;
            var rotation = Quaternion.LookRotation(-raycastNormal, m_CharacterLocomotion.Up);
            var startPosition = MathUtility.TransformPoint(raycastHit.point, rotation, Vector3.up * 0.1f) - (raycastNormal * 0.1f);
            if (!Physics.Raycast(startPosition, -m_Transform.up, out raycastHit, 0.11f, 1 << hitObject.layer, QueryTriggerInteraction.Ignore)) {
                return null;
            }

            // The object found needs to be the same object found by the original cast.
            if (raycastHit.collider.gameObject != hitObject) {
                return null;
            }

            var raycastPoint = raycastHit.point;
            var raycastOffset = raycastNormal * Mathf.Abs(m_CastOffset.z);
            if (goalState == HangState.TransferUp || goalState == HangState.TransferDown) {
                // The detected object should also exist to the left and the right of the character.
                // This will prevent the character from starting to hang halfway off the edge of a hang object.
                if (!Physics.Raycast(raycastPoint + MathUtility.TransformDirection(Vector3.right * -m_ShimmyOffset, rotation) + raycastOffset,
                    -raycastNormal, out raycastHit, m_CastDistance, 1 << hitObject.layer, QueryTriggerInteraction.Ignore) || raycastHit.collider.gameObject != hitObject) {
                    return null;
                }

                if (!Physics.Raycast(raycastPoint + MathUtility.TransformDirection(Vector3.right * m_ShimmyOffset, rotation) + raycastOffset,
                    -raycastNormal, out raycastHit, m_CastDistance, 1 << hitObject.layer, QueryTriggerInteraction.Ignore) || raycastHit.collider.gameObject != hitObject) {
                    return null;
                }
            }

            // The object is a hang object. Adjust the raycast point to be at the edge of the hang object.
            raycastHit.point = raycastPoint + raycastNormal * 0.1f;
            raycastHit.normal = raycastNormal;

            return hitObject;
        }

        /// <summary>
        /// Returns the possible MoveTowardsLocations that the character can move towards.
        /// </summary>
        /// <returns>The possible MoveTowardsLocations that the character can move towards.</returns>
        public override MoveTowardsLocation[] GetMoveTowardsLocations()
        {
            // The character can only move to a start location if dropping to start.
            if (m_HangState == HangState.DropToStart && !m_LedgeStrafeDropStart) {
                var abilityStartLocations = m_DetectedObject.GetCachedComponents<MoveTowardsLocation>();
                if (abilityStartLocations != null) {
                    // The start location should be modified to be directly in front of the hang object raycast position.
                    for (int i = 0; i < abilityStartLocations.Length; ++i) {
                        var rotation = Quaternion.LookRotation(m_RaycastResult.normal, m_CharacterLocomotion.Up);
                        var startPosition = MathUtility.TransformPoint(m_RaycastResult.point, rotation, abilityStartLocations[i].StartOffset);
                        abilityStartLocations[i].Offset = abilityStartLocations[i].transform.position - startPosition;
                        var yawOffset = MathUtility.InverseTransformQuaternion(abilityStartLocations[i].transform.rotation, rotation).eulerAngles.y;
                        abilityStartLocations[i].YawOffset = MathUtility.ClampAngle(yawOffset + abilityStartLocations[i].StartYawOffset);
                    }
                }
                return abilityStartLocations;
            }
            return base.GetMoveTowardsLocations();
        }

        /// <summary>
        /// The ability has started.
        /// </summary>
        protected override void AbilityStarted()
        {
            m_LastHangObject = m_DetectedObject;
            m_GroundedStart = m_CharacterLocomotion.Grounded;
            m_CanChangeVertically = false;
            m_CharacterLocomotion.GravityAmount = 0;

            if (m_HangState == HangState.MoveToStart) {
                // The jump ability will lift the character from the ground to move into hang position. This allows the jump animation have full control over the start
                // instead of having to add the same type of animations to the hang ability.
                if (m_CharacterLocomotion.Grounded) {
                    if (m_Jump == null) {
                        Debug.LogError("Error: The jump ability must be added in order for the character to be able to start hanging while on the ground.");
                        m_HangState = HangState.None;
                        StopAbility();
                        return;
                    }

                    m_CharacterLocomotion.TryStartAbility(m_Jump);
                }

                // When the character is dropping to start hang will activate after the character is in position.
                if (!string.IsNullOrEmpty(m_InPositionStateName)) {
                    StateManager.SetState(m_GameObject, m_InPositionStateName, true);
                }
            } else if (m_HangState == HangState.DropToStart) {
                // Dropping to start requires turning the character around so root motion must be used.
                m_CharacterLocomotion.ForceRootMotionRotation = true;
            }

            // The jump button can stop the ability.
            if (m_StopHangOnJump && m_Handler != null && m_Jump != null && m_Jump.InputNames.Length > 0 && m_Jump.StartType == AbilityStartType.ButtonDown) {
                if (!string.IsNullOrEmpty(m_MoveUpButtonName) && m_Jump.InputNames[0] == m_MoveUpButtonName) {
                    Debug.LogWarning("Warning: The Move Up Button Name is the same as the Jump Input Name with the Hang ability stopping when the character jumps. " +
                        "Stop Hang On Jump will be disabled to prevent conflicts.");
                    m_StopHangOnJump = false;
                } else {
                    m_JumpInput = GenericObjectPool.Get<ActiveInputEvent>();
                    m_JumpInput.Initialize(ActiveInputEvent.Type.ButtonDown, m_Jump.InputNames[0], "OnAnimatorHangComplete");
                    m_Handler.RegisterInputEvent(m_JumpInput);
                }
            }

            // A button can be mapped which moves the character up to the next hang state.
            if (m_Handler != null && !string.IsNullOrEmpty(m_MoveUpButtonName)) {
                m_MoveUpInput = GenericObjectPool.Get<ActiveInputEvent>();
                m_MoveUpInput.Initialize(ActiveInputEvent.Type.ButtonDown, m_MoveUpButtonName, "OnHangMoveUp");
                m_Handler.RegisterInputEvent(m_MoveUpInput);
                EventHandler.RegisterEvent(m_GameObject, "OnHangMoveUp", OnTryMoveUp);
            }

            // The character's hands should be placed on the hang object.
            if (m_CharacterIK != null) {
                m_CharacterIK.OnUpdateIKPosition += OnUpdateIKPosition;
                m_CharacterIK.OnUpdateIKRotation += OnUpdateIKRotation;

                m_IKPositionMap = new Dictionary<CharacterIKBase.IKGoal, Vector3>();
                m_IkRotationMap = new Dictionary<CharacterIKBase.IKGoal, Quaternion>();
            }

            // Call AbilityStarted after the jump ability has had the chance to start. This allows the hang ability general settings to override the jump ability general settings.
            base.AbilityStarted();

            // Force independent look so the movement type won't try to rotate the character.
            EventHandler.ExecuteEvent(m_GameObject, "OnCharacterForceIndependentLook", true);

            // The character should continue to detect horizontal collisions until they are in the air. This should be done after base.AbilityStarted because 
            // the base method also sets the horizontal collision detect property.
            if (m_HangState == HangState.MoveToStart && m_Jump != null && m_Jump.IsActive) {
                m_CharacterLocomotion.AllowHorizontalCollisionDetection = true;
            }
        }

        /// <summary>
        /// Called when another ability is attempting to start and the current ability is active.
        /// Returns true or false depending on if the new ability should be blocked from starting.
        /// </summary>
        /// <param name="startingAbility">The ability that is starting.</param>
        /// <returns>True if the ability should be blocked.</returns>
        public override bool ShouldBlockAbilityStart(Ability startingAbility)
        {
            return startingAbility is Fall;
        }

        /// <summary>
        /// Called when the current ability is attempting to start and another ability is active.
        /// Returns true or false depending on if the active ability should be stopped.
        /// </summary>
        /// <param name="activeAbility">The ability that is currently active.</param>
        /// <returns>True if the ability should be stopped.</returns>
        public override bool ShouldStopActiveAbility(Ability activeAbility)
        {
            return activeAbility is Fall;
        }

        /// <summary>
        /// Updates the ability. Called before the character movements are applied.
        /// </summary>
        public override void Update()
        {
            base.Update();

            // Clear the ik mappings to allow new ik values to be determined.
            if (m_CharacterIK != null) {
                m_IKPositionMap.Clear();
                m_IkRotationMap.Clear();
            }

            var raycastNormal = Vector3.ProjectOnPlane(m_RaycastResult.normal, m_CharacterLocomotion.Up).normalized;
            var raycastRotation = Quaternion.LookRotation(-raycastNormal, m_CharacterLocomotion.Up);
            if (m_HangState == HangState.Shimmy) {
                // The ability should stop if a hang object is no longer in front of the character. Perform a raycast every update to keep the RaycastHit value updated.
                var localPosition = m_Transform.InverseTransformPoint(m_RaycastResult.point);
                localPosition.x = 0;
                if (!Physics.Raycast(m_Transform.TransformPoint(localPosition) + raycastNormal * Mathf.Abs(m_CastOffset.z), -raycastNormal, out m_RaycastHit,
                    m_CastDistance, 1 << m_DetectedObject.layer, QueryTriggerInteraction.Ignore)) {
                    StopAbility();
                    return;
                }
                // Ensure the normal is facing in a valid direction.
                if (m_RaycastHit.normal != m_CharacterLocomotion.Up) {
                    m_RaycastResult = m_RaycastHit;
                }

                // If the hit object has changed then the object should be validated again. If the hit object is not valid then the ability should stop.
                var hitObject = m_RaycastResult.collider.gameObject;
                if (hitObject != m_DetectedObject && !ValidateObject(hitObject, m_RaycastResult)) {
                    StopAbility();
                    return;
                }
                m_LastHangObject = m_DetectedObject = hitObject;

                // The up button should be released before the character can move up vertically again.
                if (!m_CanChangeVertically && !m_GroundedStart) {
                    m_CanChangeVertically = Mathf.Abs(m_CharacterLocomotion.RawInputVector.y) <= m_ChangeStateSensitivity;
                }

                // The character can't continue to move left or right if the hang object no longer exists.
                if (Mathf.Abs(m_CharacterLocomotion.RawInputVector.x) > m_ChangeStateSensitivity &&
                        !Physics.Raycast(m_RaycastResult.point + MathUtility.TransformDirection(Vector3.right * m_ShimmyOffset * (m_CharacterLocomotion.RawInputVector.x < 0 ? -1 : 1),
                        raycastRotation) + raycastNormal * Mathf.Abs(m_CastOffset.z),
                        -raycastNormal, m_RaycastResult.distance + 0.01f, 1 << m_DetectedObject.layer, QueryTriggerInteraction.Ignore)) {
                    // The character may be able to transfer from one hang object to another in the horizontal direction.
                    if ((m_AllowedMovements & AllowedMovement.TransferHorizontal) != 0 &&
                        DetermineNextHangObject(m_CharacterLocomotion.RawInputVector.x > 0 ? HangState.TransferRight : HangState.TransferLeft, m_Transform.forward, out m_RaycastHit) != null) {
                        // A horizontal transfer exist - start transfering from one hang object to the other.
                        m_RaycastResult = m_RaycastHit;
                        m_DetectedObject = m_RaycastResult.collider.gameObject;
                        m_HangState = m_CharacterLocomotion.RawInputVector.x > 0 ? HangState.TransferRight : HangState.TransferLeft;
                        m_CharacterLocomotion.UpdateAbilityAnimatorParameters();
                        return;
                    }
                    // No horizontal transfer exists - stop moving to prevent the character from shimmying off the side of the object.
                    var rawInput = m_CharacterLocomotion.RawInputVector;
                    rawInput.x = 0;
                    m_CharacterLocomotion.RawInputVector = rawInput;
                } else if (m_CanChangeVertically && Mathf.Abs(m_CharacterLocomotion.RawInputVector.y) > m_ChangeStateSensitivity || m_TryMoveUp) {
                    // The character may be able to transfer to a hang object vertically.
                    if ((m_AllowedMovements & AllowedMovement.TransferVertically) != 0 &&
                        DetermineNextHangObject((m_CharacterLocomotion.RawInputVector.y > 0 || m_TryMoveUp) ? HangState.TransferUp : HangState.TransferDown, m_Transform.forward, out m_RaycastHit) != null) {
                        // A vertical object exists. Start to transfer up.
                        m_RaycastResult = m_RaycastHit;
                        m_DetectedObject = m_RaycastResult.collider.gameObject;
                        m_HangState = (m_CharacterLocomotion.RawInputVector.y > 0 || m_TryMoveUp) ? HangState.TransferUp : HangState.TransferDown;
                        m_CanChangeVertically = false;
                        m_CharacterLocomotion.UpdateAbilityAnimatorParameters();
                        return;
                    } else if ((m_CharacterLocomotion.RawInputVector.y > 0 || m_TryMoveUp) && (m_AllowedMovements & AllowedMovement.PullUp) != 0) {
                        // Perform a capsule cast to determine if the character can pull up to stop the ability.
                        var firstEndCap = m_RaycastResult.point + m_Transform.up * (m_ShimmyOffset + 0.01f);
                        var secondEndCap = firstEndCap + m_Transform.up * (Mathf.Max(m_CharacterLocomotion.Height - m_ShimmyOffset, 0.01f));
                        if (Physics.CapsuleCast(firstEndCap, secondEndCap, 0.1f, m_Transform.forward, m_PullUpCastDistance, 
                            m_CharacterLayerManager.IgnoreInvisibleCharacterLayers, QueryTriggerInteraction.Ignore)) {
                            return;
                        }
                        // There is space for the character to pull up on.
                        m_HangState = HangState.PullUp;
                        m_CharacterLocomotion.UpdateAbilityAnimatorParameters();
                    } else if ((m_AllowedMovements & AllowedMovement.DropToStop) != 0 && m_CharacterLocomotion.RawInputVector.y < 0) {
                        StopAbility();
                    }
                    m_TryMoveUp = false;
                }
            } else if ((m_HangState == HangState.MoveToStart || m_HangState == HangState.TransferUp || 
                        m_HangState == HangState.TransferDown || m_HangState == HangState.DropToStart) && !m_CharacterLocomotion.Grounded) {
                // As soon as the character is in the air the jump ability should stop - the hang ability can move into the correct position.
                if (m_Jump.IsActive) {
                    m_CharacterLocomotion.AllowHorizontalCollisionDetection = false;
                    m_CharacterLocomotion.TryStopAbility(m_Jump, true);
                }

                // Start to shimmy as soon as the character is near the hang object.
                var targetPosition = MathUtility.TransformPoint(m_RaycastResult.point, raycastRotation, m_RelativeHangOffset);
                if (Mathf.Abs(m_Transform.InverseTransformPoint(targetPosition - m_CharacterLocomotion.Up * m_CharacterLocomotion.Height).y) < 
                                    (m_HangState == HangState.TransferUp ? m_CharacterLocomotion.ColliderSpacing * 2 : m_InPositionShimmyDistance)) {
                    if (m_HangState == HangState.DropToStart) {
                        m_CharacterLocomotion.ForceRootMotionRotation = false;
                        if (!string.IsNullOrEmpty(m_InPositionStateName)) {
                            StateManager.SetState(m_GameObject, m_InPositionStateName, true);
                        }
                    }

                    m_HangState = HangState.Shimmy;
                    m_CharacterLocomotion.UpdateAbilityAnimatorParameters();
                }
            } else if (m_HangState == HangState.TransferLeft || m_HangState == HangState.TransferRight) {
                // Start to shimmy as soon as the character is near the horizontal hang object.
                var targetPosition = MathUtility.TransformPoint(m_RaycastResult.point, raycastRotation, m_RelativeHangOffset);
                if (Mathf.Abs(m_Transform.InverseTransformPoint(targetPosition).x) < m_InPositionShimmyDistance) {
                    m_HangState = HangState.Shimmy;
                    m_CharacterLocomotion.UpdateAbilityAnimatorParameters();
                }
            }
        }
        
        /// <summary>
        /// Update the ability's Animator parameters.
        /// </summary>
        public override void UpdateAnimator()
        {
            // The float data should be set if the character is moving or dropping to a start. This allongs the animator to keep know if the character is starting 
            // from a ledge strafe, or if the character is in the air the velocity so it knows how high to position the character's feet.
            if (m_HangState == HangState.DropToStart || m_HangState == HangState.MoveToStart) {
                SetAbilityFloatDataParameter(AbilityFloatData);
            }

            // No matter the movement type the x input should be set to the Horizontal Movement parameter, and the y input should be the Forward Movement parameter.
            m_CharacterLocomotion.InputVector = m_CharacterLocomotion.RawInputVector;
        }

        /// <summary>
        /// Update the controller's rotation values.
        /// </summary>
        public override void UpdateRotation()
        {
            base.UpdateRotation();

            if (m_HangState == HangState.DropToStart) {
                return;
            }

            // The character should always face the hang object.
            var raycastNormal = Vector3.ProjectOnPlane(m_RaycastResult.normal, m_CharacterLocomotion.Up).normalized;
            var localLookDirection = m_Transform.InverseTransformDirection(-raycastNormal);
            localLookDirection.y = 0;
            var deltaRotation = m_CharacterLocomotion.DeltaRotation;
            deltaRotation.y = MathUtility.ClampInnerAngle(Quaternion.LookRotation(localLookDirection.normalized, m_CharacterLocomotion.Up).eulerAngles.y);
            m_CharacterLocomotion.DeltaRotation = deltaRotation;
        }

        /// <summary>
        /// Tries to transfer or pull the character up to the next hang state.
        /// </summary>
        public void OnTryMoveUp()
        {
            if (!m_CanChangeVertically || m_HangState != HangState.Shimmy) {
                return;
            }
            m_TryMoveUp = true;
        }

        /// <summary>
        /// Verify the position values. Called immediately before the position is applied.
        /// </summary>
        public override void ApplyPosition()
        {
            base.ApplyPosition();

            // When the character is hanging they should always be a set distance away from the object. Force that position based on the object's position and normal.
            var raycastNormal = Vector3.ProjectOnPlane(m_RaycastResult.normal, m_CharacterLocomotion.Up).normalized;
            var targetPosition = MathUtility.TransformPoint(m_RaycastResult.point, Quaternion.LookRotation(-raycastNormal, m_CharacterLocomotion.Up), m_RelativeHangOffset);
            var localTargetPosition = m_Transform.InverseTransformPoint(targetPosition - m_CharacterLocomotion.Up * m_CharacterLocomotion.Height);
            var localPosition = m_Transform.InverseTransformPoint(m_Transform.position + m_CharacterLocomotion.MoveDirection);
            localTargetPosition.x = localPosition.x;
            if (m_HangState == HangState.MoveToStart) {
                // Move towards the hang point if the character has stopped moving vertically.
                // Give the character a vertical push if the character is moving vertically but the velocity is slowing down. This will allow the character to make it towards
                // the adjusted position even though the velocity may have otherwise stopped the character.
                if (!m_CharacterLocomotion.Grounded && (m_CharacterLocomotion.LocalLocomotionVelocity.y < 0.1f || localTargetPosition.y < 0.1f)) {
                    localTargetPosition.y = Mathf.MoveTowards(0, localTargetPosition.y, Time.deltaTime * m_CharacterLocomotion.TimeScale * 2);
                } else {
                    localTargetPosition.y = localPosition.y;
                }
            } else if (m_HangState == HangState.TransferUp || m_HangState == HangState.TransferDown || m_HangState == HangState.DropToStart || m_HangState == HangState.PullUp) {
                localTargetPosition.y = localPosition.y;
                localTargetPosition.z = localPosition.z;
            }
            // While the character is in the air push them towards the target z position. Don't immediately snap the character.
            if (m_CharacterLocomotion.Grounded) {
                localTargetPosition.z = localPosition.z;
            } else {
                localTargetPosition.z = Mathf.MoveTowards(localPosition.z, localTargetPosition.z, m_StartMoveTowardsSpeed * m_CharacterLocomotion.TimeScale);
            }
            // Apply the adjusted position.
            m_CharacterLocomotion.MoveDirection = m_Transform.TransformPoint(localTargetPosition) - m_Transform.position;
        }

        /// <summary>
        /// Rotates the IK object to be facing in the direction of the hang object.
        /// </summary>
        /// <param name="ikGoal">The IK object being repositioned.</param>
        /// <param name="ikRotation">The current rotation of the IK object.</param>
        /// <param name="ikPosition">The current position of the IK object.</param>
        /// <returns>The new position of the IK object.</returns>
        public Quaternion OnUpdateIKRotation(CharacterIKBase.IKGoal ikGoal, Quaternion ikRotation, Vector3 ikPosition)
        {
            UpdateIKRotationPosition(ikGoal, ref ikRotation, ref ikPosition);

            return ikRotation;
        }

        /// <summary>
        /// Positions the IK object to be on the hang object.
        /// </summary>
        /// <param name="ikGoal">The IK object being repositioned.</param>
        /// <param name="ikRotation">The current rotation of the IK object.</param>
        /// <param name="ikPosition">The current position of the IK object.</param>
        /// <returns>The new position of the IK object.</returns>
        public Vector3 OnUpdateIKPosition(CharacterIKBase.IKGoal ikGoal, Vector3 ikPosition, Quaternion ikRotation)
        {
            UpdateIKRotationPosition(ikGoal, ref ikRotation, ref ikPosition);

            return ikPosition;
        }

        /// <summary>
        /// Rotates and positions the IK object to be on the hang object.
        /// </summary>
        /// <param name="ikGoal">The IK object being repositioned.</param>
        /// <param name="ikRotation">The rotation of the IK object.</param>
        /// <param name="ikPosition">The position of the IK object.</param>
        private void UpdateIKRotationPosition(CharacterIKBase.IKGoal ikGoal, ref Quaternion ikRotation, ref Vector3 ikPosition)
        {
            if (m_HangState == HangState.MoveToStart || m_HangState == HangState.DropToStart || m_HangState == HangState.PullUp || 
                    (ikGoal != CharacterIKBase.IKGoal.LeftHand && ikGoal != CharacterIKBase.IKGoal.RightHand)) {
                return;
            }

            var updateIK = false;
            if (m_IkRotationMap.ContainsKey(ikGoal)) {
                ikRotation = m_IkRotationMap[ikGoal];
            } else {
                updateIK = true;
            }
            if (m_IkRotationMap.ContainsKey(ikGoal)) {
                ikPosition = m_IKPositionMap[ikGoal];
            } else {
                updateIK = true;
            }

            // Don't do another raycast if the raycast has already been performed for the current tick.
            if (!updateIK) {
                return;
            }

            // The IK needs to be updated. Perform the update for both the rotation and position so the raycast only needs to be cast once.
            var raycastNormal = Vector3.ProjectOnPlane(m_RaycastResult.normal, m_CharacterLocomotion.Up).normalized;
            if (!Physics.Raycast(ikPosition + raycastNormal * Mathf.Abs(m_CastOffset.z / 2), -raycastNormal, out m_RaycastHit, Mathf.Abs(m_CastOffset.z) + 0.01f, 
                1 << m_DetectedObject.layer, QueryTriggerInteraction.Ignore)) {
                m_RaycastHit = m_RaycastResult;
            }
            ikRotation *= Quaternion.LookRotation(-m_RaycastHit.normal, m_CharacterLocomotion.Up) * Quaternion.Inverse(m_Transform.rotation);

            // The hand should be resting flat on the hang object in front of the hand. If no object was hit then the center hang object will be used.
            var localPosition = MathUtility.InverseTransformPoint(ikPosition, m_Transform.rotation, m_RaycastHit.point);
            localPosition.x = localPosition.y = 0;
            localPosition += m_HandIKOffset;
            ikPosition = MathUtility.TransformPoint(ikPosition, m_Transform.rotation, localPosition);

            m_IkRotationMap.Add(ikGoal, ikRotation);
            m_IKPositionMap.Add(ikGoal, ikPosition);
        }

        /// <summary>
        /// Returns true if the camera can zoom.
        /// </summary>
        /// <returns>True if the camera can zoom.</returns>
        public override bool CanCameraZoom()
        {
            return false;
        }

        /// <summary>
        /// Can the ability be stopped?
        /// </summary>
        /// <returns>True if the ability can be stopped.</returns>
        public override bool CanStopAbility()
        {
            return m_HangState == HangState.Shimmy || m_HangState == HangState.None;
        }

        /// <summary>
        /// The ability has stopped running.
        /// </summary>
        /// <param name="force">Was the ability force stopped?</param>
        protected override void AbilityStopped(bool force)
        {
            base.AbilityStopped(force);

            if (m_JumpInput != null) {
                m_Handler.UnregisterInputEvent(m_JumpInput);
                GenericObjectPool.Return(m_JumpInput);
            }
            if (m_MoveUpInput != null) {
                m_Handler.UnregisterInputEvent(m_MoveUpInput);
                GenericObjectPool.Return(m_MoveUpInput);
                EventHandler.UnregisterEvent(m_GameObject, "OnHangMoveUp", OnTryMoveUp);
            }
            if (!string.IsNullOrEmpty(m_InPositionStateName)) {
                StateManager.SetState(m_GameObject, m_InPositionStateName, false);
            }
            if (m_CharacterIK != null) {
                m_CharacterIK.OnUpdateIKPosition -= OnUpdateIKPosition;
                m_CharacterIK.OnUpdateIKRotation -= OnUpdateIKRotation;
            }

            EventHandler.ExecuteEvent(m_GameObject, "OnCharacterForceIndependentLook", false);
        }

        /// <summary>
        /// The character has changed grounded states. 
        /// </summary>
        /// <param name="grounded">Is the character on the ground?</param>
        private void OnGrounded(bool grounded)
        {
            if (grounded) {
                // After the character lands on the ground the last hang object should be forgotten. This will allow the character to hang on that same object again.
                m_LastHangObject = null;

                // If the character is grounded while trying to move to the hang position then the ability should be stopped because the character didn't catch the hang object.
                if (IsActive && m_HangState == HangState.MoveToStart) {
                    StopAbility();
                }
            }
        }

        /// <summary>
        /// The character's position or rotation has been teleported.
        /// </summary>
        /// <param name="snapAnimator">Should the animator be snapped?</param>
        private void OnImmediateTransformChange(bool snapAnimator)
        {
            m_LastHangObject = null;
        }

        /// <summary>
        /// The hang ability is in starting position.
        /// </summary>
        private void OnHangStartInPosition()
        {
            // Reset grounded start after the character is in position because the grounded start state no longer matters.
            m_GroundedStart = false;
            // After the character is in position reset the rotation and position to prevent any external jump forces from affecting the character's move direction.
            m_CharacterLocomotion.ResetRotationPosition();
        }

        /// <summary>
        /// The hang ability has completed - stop the ability.
        /// </summary>
        private void OnHangComplete()
        {
            m_HangState = HangState.None;
            StopAbility();
        }

        /// <summary>
        /// Called when the character is destroyed.
        /// </summary>
        public override void OnDestroy()
        {
            base.OnDestroy();

            EventHandler.UnregisterEvent<bool>(m_GameObject, "OnCharacterGrounded", OnGrounded);
            EventHandler.UnregisterEvent<bool>(m_GameObject, "OnCharacterImmediateTransformChange", OnImmediateTransformChange);
            EventHandler.UnregisterEvent(m_GameObject, "OnAnimatorHangStartInPosition", OnHangStartInPosition);
            EventHandler.UnregisterEvent(m_GameObject, "OnAnimatorHangComplete", OnHangComplete);
        }
    }
}