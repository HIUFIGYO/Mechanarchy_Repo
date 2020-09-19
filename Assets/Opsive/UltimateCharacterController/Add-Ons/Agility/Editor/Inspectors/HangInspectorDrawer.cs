/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

namespace Opsive.UltimateCharacterController.AddOns.Agility.Editor.Inspectors.Character.Abilities
{
	using Opsive.UltimateCharacterController.Editor.Inspectors;
	using Opsive.UltimateCharacterController.Editor.Inspectors.Character.Abilities;
	using Opsive.UltimateCharacterController.Editor.Inspectors.Utility;
	using Opsive.UltimateCharacterController.Editor.Utility;
	using UnityEditor;
	using UnityEditor.Animations;
	using UnityEngine;

	/// <summary>
	/// Draws a custom inspector for the Hang Ability.
	/// </summary>
	[InspectorDrawer(typeof(Hang))]
	public class HangInspectorDrawer : DetectObjectAbilityBaseInspectorDrawer
    {
        /// <summary>
        /// Draws the fields related to the inspector drawer.
        /// </summary>
        /// <param name="target">The object that is being drawn.</param>
        /// <param name="parent">The Unity Object that the object belongs to.</param>
        protected override void DrawInspectorDrawerFields(object target, Object parent)
        {
            // Draw AllowMovements manually so it'll use the MaskField.
            var allowedMovements = (int)InspectorUtility.GetFieldValue<Hang.AllowedMovement>(target, "m_AllowedMovements");
            var allowedMovementsString = System.Enum.GetNames(typeof(Hang.AllowedMovement));
            var value = EditorGUILayout.MaskField(new GUIContent("Allowed Movements", InspectorUtility.GetFieldTooltip(target, "m_AllowedMovements")), allowedMovements, allowedMovementsString);
            if (value != allowedMovements) {
                InspectorUtility.SetFieldValue(target, "m_AllowedMovements", value);
            }

            base.DrawInspectorDrawerFields(target, parent);
        }

		// ------------------------------------------- Start Generated Code -------------------------------------------
		// ------- Do NOT make any changes below. Changes will be removed when the animator is generated again. -------
		// ------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// Returns true if the ability can build to the animator.
		/// </summary>
		public override bool CanBuildAnimator { get { return true; } }

		/// <summary>
		/// An editor only method which can add the abilities states/transitions to the animator.
		/// </summary>
		/// <param name="animatorController">The Animator Controller to add the states to.</param>
		/// <param name="firstPersonAnimatorController">The first person Animator Controller to add the states to.</param>
		public override void BuildAnimator(AnimatorController animatorController, AnimatorController firstPersonAnimatorController)
		{
			var baseStateMachine12 = animatorController.layers[12].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine12.stateMachines.Length; ++j) {
					if (baseStateMachine12.stateMachines[j].stateMachine.name == "Hang") {
						baseStateMachine12.RemoveStateMachine(baseStateMachine12.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var m_HangMovementAnimationClip28412Path = AssetDatabase.GUIDToAssetPath("fd8bcd7a5867d3c489f6e8c561390f5c"); 
			var m_HangMovementAnimationClip28412 = AnimatorBuilder.GetAnimationClip(m_HangMovementAnimationClip28412Path, "HangMovement");
			var m_HangIdleAnimationClip28306Path = AssetDatabase.GUIDToAssetPath("bddb2b4a0e5f12f49b71618b412ff5aa"); 
			var m_HangIdleAnimationClip28306 = AnimatorBuilder.GetAnimationClip(m_HangIdleAnimationClip28306Path, "HangIdle");
			var m_HangStartAnimationClip29190Path = AssetDatabase.GUIDToAssetPath("053d29fbe247cbc4f98bd80634cdad46"); 
			var m_HangStartAnimationClip29190 = AnimatorBuilder.GetAnimationClip(m_HangStartAnimationClip29190Path, "HangStart");
			var m_TransferRightAnimationClip29448Path = AssetDatabase.GUIDToAssetPath("04c74e7c306a6cf48813b0ffc2e992db"); 
			var m_TransferRightAnimationClip29448 = AnimatorBuilder.GetAnimationClip(m_TransferRightAnimationClip29448Path, "TransferRight");
			var m_TransferLeftAnimationClip29010Path = AssetDatabase.GUIDToAssetPath("77339d9bf70da1441b2e6b4de0bbc3d8"); 
			var m_TransferLeftAnimationClip29010 = AnimatorBuilder.GetAnimationClip(m_TransferLeftAnimationClip29010Path, "TransferLeft");
			var m_TransferUpAnimationClip24144Path = AssetDatabase.GUIDToAssetPath("9409cd14629cef747a96eac1d5fa22f7"); 
			var m_TransferUpAnimationClip24144 = AnimatorBuilder.GetAnimationClip(m_TransferUpAnimationClip24144Path, "TransferUp");
			var m_DropStartAnimationClip23654Path = AssetDatabase.GUIDToAssetPath("0b38d3330a39f684ab19e45f90a6eead"); 
			var m_DropStartAnimationClip23654 = AnimatorBuilder.GetAnimationClip(m_DropStartAnimationClip23654Path, "DropStart");
			var m_PullUpAnimationClip23218Path = AssetDatabase.GUIDToAssetPath("c7d5ba824b936f649bbb2747a4a3fc4a"); 
			var m_PullUpAnimationClip23218 = AnimatorBuilder.GetAnimationClip(m_PullUpAnimationClip23218Path, "PullUp");
			var m_TransferDownAnimationClip28552Path = AssetDatabase.GUIDToAssetPath("2ee34eba64def1b44a6062121131cc13"); 
			var m_TransferDownAnimationClip28552 = AnimatorBuilder.GetAnimationClip(m_TransferDownAnimationClip28552Path, "TransferDown");
			var m_HangJumpStartAnimationClip29188Path = AssetDatabase.GUIDToAssetPath("053d29fbe247cbc4f98bd80634cdad46"); 
			var m_HangJumpStartAnimationClip29188 = AnimatorBuilder.GetAnimationClip(m_HangJumpStartAnimationClip29188Path, "HangJumpStart");
			var m_DropStartLedgeStrafeAnimationClip28172Path = AssetDatabase.GUIDToAssetPath("02e3ce0a2c624334d9af402815fa5f5f"); 
			var m_DropStartLedgeStrafeAnimationClip28172 = AnimatorBuilder.GetAnimationClip(m_DropStartLedgeStrafeAnimationClip28172Path, "DropStartLedgeStrafe");

			// State Machine.
			var m_HangAnimatorStateMachine59878 = baseStateMachine12.AddStateMachine("Hang", new Vector3(624f, 204f, 0f));

			// States.
			var m_HangAnimatorState60952 = m_HangAnimatorStateMachine59878.AddState("Hang", new Vector3(384f, -84f, 0f));
			var m_HangAnimatorState60952m_BlendTreeBlendTree60976 = new BlendTree();
			AssetDatabase.AddObjectToAsset(m_HangAnimatorState60952m_BlendTreeBlendTree60976, animatorController);
			m_HangAnimatorState60952m_BlendTreeBlendTree60976.hideFlags = HideFlags.HideInHierarchy;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976.blendParameter = "HorizontalMovement";
			m_HangAnimatorState60952m_BlendTreeBlendTree60976.blendParameterY = "HorizontalMovement";
			m_HangAnimatorState60952m_BlendTreeBlendTree60976.blendType = BlendTreeType.Simple1D;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976.maxThreshold = 1f;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976.minThreshold = -1f;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976.name = "Blend Tree";
			m_HangAnimatorState60952m_BlendTreeBlendTree60976.useAutomaticThresholds = false;
			var m_HangAnimatorState60952m_BlendTreeBlendTree60976Child0=  new ChildMotion();
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child0.motion = m_HangMovementAnimationClip28412;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child0.cycleOffset = 0f;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child0.directBlendParameter = "HorizontalMovement";
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child0.mirror = false;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child0.position = new Vector2(0f, 0f);
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child0.threshold = -1f;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child0.timeScale = 1.4f;
			var m_HangAnimatorState60952m_BlendTreeBlendTree60976Child1=  new ChildMotion();
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child1.motion = m_HangIdleAnimationClip28306;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child1.cycleOffset = 0f;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child1.directBlendParameter = "HorizontalMovement";
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child1.mirror = false;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child1.position = new Vector2(0f, 0f);
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child1.threshold = 0f;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child1.timeScale = 1f;
			var m_HangAnimatorState60952m_BlendTreeBlendTree60976Child2=  new ChildMotion();
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child2.motion = m_HangMovementAnimationClip28412;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child2.cycleOffset = 0f;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child2.directBlendParameter = "HorizontalMovement";
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child2.mirror = false;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child2.position = new Vector2(0f, 0f);
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child2.threshold = 1f;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976Child2.timeScale = -1.4f;
			m_HangAnimatorState60952m_BlendTreeBlendTree60976.children = new ChildMotion[] {
				m_HangAnimatorState60952m_BlendTreeBlendTree60976Child0,
				m_HangAnimatorState60952m_BlendTreeBlendTree60976Child1,
				m_HangAnimatorState60952m_BlendTreeBlendTree60976Child2
			};
			m_HangAnimatorState60952.motion = m_HangAnimatorState60952m_BlendTreeBlendTree60976;
			m_HangAnimatorState60952.cycleOffset = 0f;
			m_HangAnimatorState60952.cycleOffsetParameterActive = false;
			m_HangAnimatorState60952.iKOnFeet = false;
			m_HangAnimatorState60952.mirror = false;
			m_HangAnimatorState60952.mirrorParameterActive = false;
			m_HangAnimatorState60952.speed = 1f;
			m_HangAnimatorState60952.speedParameterActive = false;
			m_HangAnimatorState60952.writeDefaultValues = false;

			var m_HangStartAnimatorState60134 = m_HangAnimatorStateMachine59878.AddState("Hang Start", new Vector3(384f, -192f, 0f));
			m_HangStartAnimatorState60134.motion = m_HangStartAnimationClip29190;
			m_HangStartAnimatorState60134.cycleOffset = 0f;
			m_HangStartAnimatorState60134.cycleOffsetParameterActive = false;
			m_HangStartAnimatorState60134.iKOnFeet = false;
			m_HangStartAnimatorState60134.mirror = false;
			m_HangStartAnimatorState60134.mirrorParameterActive = false;
			m_HangStartAnimatorState60134.speed = 2f;
			m_HangStartAnimatorState60134.speedParameterActive = false;
			m_HangStartAnimatorState60134.writeDefaultValues = false;

			var m_TransferRightAnimatorState60954 = m_HangAnimatorStateMachine59878.AddState("Transfer Right", new Vector3(588f, 12f, 0f));
			m_TransferRightAnimatorState60954.motion = m_TransferRightAnimationClip29448;
			m_TransferRightAnimatorState60954.cycleOffset = 0f;
			m_TransferRightAnimatorState60954.cycleOffsetParameterActive = false;
			m_TransferRightAnimatorState60954.iKOnFeet = true;
			m_TransferRightAnimatorState60954.mirror = false;
			m_TransferRightAnimatorState60954.mirrorParameterActive = false;
			m_TransferRightAnimatorState60954.speed = 1.4f;
			m_TransferRightAnimatorState60954.speedParameterActive = false;
			m_TransferRightAnimatorState60954.writeDefaultValues = true;

			var m_TransferLeftAnimatorState60956 = m_HangAnimatorStateMachine59878.AddState("Transfer Left", new Vector3(180f, 12f, 0f));
			m_TransferLeftAnimatorState60956.motion = m_TransferLeftAnimationClip29010;
			m_TransferLeftAnimatorState60956.cycleOffset = 0f;
			m_TransferLeftAnimatorState60956.cycleOffsetParameterActive = false;
			m_TransferLeftAnimatorState60956.iKOnFeet = true;
			m_TransferLeftAnimatorState60956.mirror = false;
			m_TransferLeftAnimatorState60956.mirrorParameterActive = false;
			m_TransferLeftAnimatorState60956.speed = 1.4f;
			m_TransferLeftAnimatorState60956.speedParameterActive = false;
			m_TransferLeftAnimatorState60956.writeDefaultValues = true;

			var m_TransferUpAnimatorState60958 = m_HangAnimatorStateMachine59878.AddState("Transfer Up", new Vector3(264f, 84f, 0f));
			m_TransferUpAnimatorState60958.motion = m_TransferUpAnimationClip24144;
			m_TransferUpAnimatorState60958.cycleOffset = 0f;
			m_TransferUpAnimatorState60958.cycleOffsetParameterActive = false;
			m_TransferUpAnimatorState60958.iKOnFeet = true;
			m_TransferUpAnimatorState60958.mirror = false;
			m_TransferUpAnimatorState60958.mirrorParameterActive = false;
			m_TransferUpAnimatorState60958.speed = 1.4f;
			m_TransferUpAnimatorState60958.speedParameterActive = false;
			m_TransferUpAnimatorState60958.writeDefaultValues = true;

			var m_DropStartAnimatorState60128 = m_HangAnimatorStateMachine59878.AddState("Drop Start", new Vector3(132f, -192f, 0f));
			m_DropStartAnimatorState60128.motion = m_DropStartAnimationClip23654;
			m_DropStartAnimatorState60128.cycleOffset = 0f;
			m_DropStartAnimatorState60128.cycleOffsetParameterActive = false;
			m_DropStartAnimatorState60128.iKOnFeet = true;
			m_DropStartAnimatorState60128.mirror = false;
			m_DropStartAnimatorState60128.mirrorParameterActive = false;
			m_DropStartAnimatorState60128.speed = 1.3f;
			m_DropStartAnimatorState60128.speedParameterActive = false;
			m_DropStartAnimatorState60128.writeDefaultValues = true;

			var m_PullUpAnimatorState60960 = m_HangAnimatorStateMachine59878.AddState("Pull Up", new Vector3(384f, 168f, 0f));
			m_PullUpAnimatorState60960.motion = m_PullUpAnimationClip23218;
			m_PullUpAnimatorState60960.cycleOffset = 0f;
			m_PullUpAnimatorState60960.cycleOffsetParameter = "HorizontalMovement";
			m_PullUpAnimatorState60960.cycleOffsetParameterActive = false;
			m_PullUpAnimatorState60960.iKOnFeet = true;
			m_PullUpAnimatorState60960.mirror = false;
			m_PullUpAnimatorState60960.mirrorParameterActive = false;
			m_PullUpAnimatorState60960.speed = 1.4f;
			m_PullUpAnimatorState60960.speedParameterActive = false;
			m_PullUpAnimatorState60960.writeDefaultValues = true;

			var m_TransferDownAnimatorState60962 = m_HangAnimatorStateMachine59878.AddState("Transfer Down", new Vector3(504f, 84f, 0f));
			m_TransferDownAnimatorState60962.motion = m_TransferDownAnimationClip28552;
			m_TransferDownAnimatorState60962.cycleOffset = 0f;
			m_TransferDownAnimatorState60962.cycleOffsetParameterActive = false;
			m_TransferDownAnimatorState60962.iKOnFeet = true;
			m_TransferDownAnimatorState60962.mirror = false;
			m_TransferDownAnimatorState60962.mirrorParameterActive = false;
			m_TransferDownAnimatorState60962.speed = 1.4f;
			m_TransferDownAnimatorState60962.speedParameterActive = false;
			m_TransferDownAnimatorState60962.writeDefaultValues = true;

			var m_HangJumpStartAnimatorState60130 = m_HangAnimatorStateMachine59878.AddState("Hang Jump Start", new Vector3(624f, -192f, 0f));
			m_HangJumpStartAnimatorState60130.motion = m_HangJumpStartAnimationClip29188;
			m_HangJumpStartAnimatorState60130.cycleOffset = 0f;
			m_HangJumpStartAnimatorState60130.cycleOffsetParameterActive = false;
			m_HangJumpStartAnimatorState60130.iKOnFeet = false;
			m_HangJumpStartAnimatorState60130.mirror = false;
			m_HangJumpStartAnimatorState60130.mirrorParameterActive = false;
			m_HangJumpStartAnimatorState60130.speed = 1f;
			m_HangJumpStartAnimatorState60130.speedParameterActive = false;
			m_HangJumpStartAnimatorState60130.writeDefaultValues = false;

			var m_DropStartfromLedgeStrafeAnimatorState60132 = m_HangAnimatorStateMachine59878.AddState("Drop Start from Ledge Strafe", new Vector3(132f, -264f, 0f));
			m_DropStartfromLedgeStrafeAnimatorState60132.motion = m_DropStartLedgeStrafeAnimationClip28172;
			m_DropStartfromLedgeStrafeAnimatorState60132.cycleOffset = 0f;
			m_DropStartfromLedgeStrafeAnimatorState60132.cycleOffsetParameterActive = false;
			m_DropStartfromLedgeStrafeAnimatorState60132.iKOnFeet = true;
			m_DropStartfromLedgeStrafeAnimatorState60132.mirror = false;
			m_DropStartfromLedgeStrafeAnimatorState60132.mirrorParameterActive = false;
			m_DropStartfromLedgeStrafeAnimatorState60132.speed = 1.3f;
			m_DropStartfromLedgeStrafeAnimatorState60132.speedParameterActive = false;
			m_DropStartfromLedgeStrafeAnimatorState60132.writeDefaultValues = true;

			// State Transitions.
			var m_AnimatorStateTransition60964 = m_HangAnimatorState60952.AddExitTransition();
			m_AnimatorStateTransition60964.canTransitionToSelf = true;
			m_AnimatorStateTransition60964.duration = 0.15f;
			m_AnimatorStateTransition60964.exitTime = 0.91f;
			m_AnimatorStateTransition60964.hasExitTime = false;
			m_AnimatorStateTransition60964.hasFixedDuration = true;
			m_AnimatorStateTransition60964.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60964.offset = 0f;
			m_AnimatorStateTransition60964.orderedInterruption = true;
			m_AnimatorStateTransition60964.isExit = true;
			m_AnimatorStateTransition60964.mute = false;
			m_AnimatorStateTransition60964.solo = false;
			m_AnimatorStateTransition60964.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var m_AnimatorStateTransition60966 = m_HangAnimatorState60952.AddTransition(m_TransferRightAnimatorState60954);
			m_AnimatorStateTransition60966.canTransitionToSelf = true;
			m_AnimatorStateTransition60966.duration = 0.15f;
			m_AnimatorStateTransition60966.exitTime = 0.91f;
			m_AnimatorStateTransition60966.hasExitTime = false;
			m_AnimatorStateTransition60966.hasFixedDuration = true;
			m_AnimatorStateTransition60966.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60966.offset = 0f;
			m_AnimatorStateTransition60966.orderedInterruption = true;
			m_AnimatorStateTransition60966.isExit = false;
			m_AnimatorStateTransition60966.mute = false;
			m_AnimatorStateTransition60966.solo = false;
			m_AnimatorStateTransition60966.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			m_AnimatorStateTransition60966.AddCondition(AnimatorConditionMode.Equals, 4f, "AbilityIntData");

			var m_AnimatorStateTransition60968 = m_HangAnimatorState60952.AddTransition(m_TransferUpAnimatorState60958);
			m_AnimatorStateTransition60968.canTransitionToSelf = true;
			m_AnimatorStateTransition60968.duration = 0.1f;
			m_AnimatorStateTransition60968.exitTime = 0.91f;
			m_AnimatorStateTransition60968.hasExitTime = false;
			m_AnimatorStateTransition60968.hasFixedDuration = true;
			m_AnimatorStateTransition60968.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60968.offset = 0f;
			m_AnimatorStateTransition60968.orderedInterruption = true;
			m_AnimatorStateTransition60968.isExit = false;
			m_AnimatorStateTransition60968.mute = false;
			m_AnimatorStateTransition60968.solo = false;
			m_AnimatorStateTransition60968.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			m_AnimatorStateTransition60968.AddCondition(AnimatorConditionMode.Equals, 3f, "AbilityIntData");

			var m_AnimatorStateTransition60970 = m_HangAnimatorState60952.AddTransition(m_TransferLeftAnimatorState60956);
			m_AnimatorStateTransition60970.canTransitionToSelf = true;
			m_AnimatorStateTransition60970.duration = 0.15f;
			m_AnimatorStateTransition60970.exitTime = 0.91f;
			m_AnimatorStateTransition60970.hasExitTime = false;
			m_AnimatorStateTransition60970.hasFixedDuration = true;
			m_AnimatorStateTransition60970.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60970.offset = 0f;
			m_AnimatorStateTransition60970.orderedInterruption = true;
			m_AnimatorStateTransition60970.isExit = false;
			m_AnimatorStateTransition60970.mute = false;
			m_AnimatorStateTransition60970.solo = false;
			m_AnimatorStateTransition60970.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			m_AnimatorStateTransition60970.AddCondition(AnimatorConditionMode.Equals, 5f, "AbilityIntData");

			var m_AnimatorStateTransition60972 = m_HangAnimatorState60952.AddTransition(m_PullUpAnimatorState60960);
			m_AnimatorStateTransition60972.canTransitionToSelf = true;
			m_AnimatorStateTransition60972.duration = 0f;
			m_AnimatorStateTransition60972.exitTime = 0.91f;
			m_AnimatorStateTransition60972.hasExitTime = false;
			m_AnimatorStateTransition60972.hasFixedDuration = false;
			m_AnimatorStateTransition60972.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60972.offset = 0f;
			m_AnimatorStateTransition60972.orderedInterruption = true;
			m_AnimatorStateTransition60972.isExit = false;
			m_AnimatorStateTransition60972.mute = false;
			m_AnimatorStateTransition60972.solo = false;
			m_AnimatorStateTransition60972.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			m_AnimatorStateTransition60972.AddCondition(AnimatorConditionMode.Equals, 7f, "AbilityIntData");

			var m_AnimatorStateTransition60974 = m_HangAnimatorState60952.AddTransition(m_TransferDownAnimatorState60962);
			m_AnimatorStateTransition60974.canTransitionToSelf = true;
			m_AnimatorStateTransition60974.duration = 0.15f;
			m_AnimatorStateTransition60974.exitTime = 0.91f;
			m_AnimatorStateTransition60974.hasExitTime = false;
			m_AnimatorStateTransition60974.hasFixedDuration = true;
			m_AnimatorStateTransition60974.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60974.offset = 0f;
			m_AnimatorStateTransition60974.orderedInterruption = true;
			m_AnimatorStateTransition60974.isExit = false;
			m_AnimatorStateTransition60974.mute = false;
			m_AnimatorStateTransition60974.solo = false;
			m_AnimatorStateTransition60974.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			m_AnimatorStateTransition60974.AddCondition(AnimatorConditionMode.Equals, 6f, "AbilityIntData");

			var m_AnimatorStateTransition60978 = m_HangStartAnimatorState60134.AddTransition(m_HangAnimatorState60952);
			m_AnimatorStateTransition60978.canTransitionToSelf = true;
			m_AnimatorStateTransition60978.duration = 0.05f;
			m_AnimatorStateTransition60978.exitTime = 0.95f;
			m_AnimatorStateTransition60978.hasExitTime = true;
			m_AnimatorStateTransition60978.hasFixedDuration = true;
			m_AnimatorStateTransition60978.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60978.offset = 0f;
			m_AnimatorStateTransition60978.orderedInterruption = true;
			m_AnimatorStateTransition60978.isExit = false;
			m_AnimatorStateTransition60978.mute = false;
			m_AnimatorStateTransition60978.solo = false;

			var m_AnimatorStateTransition60980 = m_TransferRightAnimatorState60954.AddTransition(m_HangAnimatorState60952);
			m_AnimatorStateTransition60980.canTransitionToSelf = true;
			m_AnimatorStateTransition60980.duration = 0.15f;
			m_AnimatorStateTransition60980.exitTime = 0.95f;
			m_AnimatorStateTransition60980.hasExitTime = true;
			m_AnimatorStateTransition60980.hasFixedDuration = true;
			m_AnimatorStateTransition60980.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60980.offset = 0f;
			m_AnimatorStateTransition60980.orderedInterruption = true;
			m_AnimatorStateTransition60980.isExit = false;
			m_AnimatorStateTransition60980.mute = false;
			m_AnimatorStateTransition60980.solo = false;

			var m_AnimatorStateTransition113044 = m_TransferRightAnimatorState60954.AddExitTransition();
			m_AnimatorStateTransition113044.canTransitionToSelf = true;
			m_AnimatorStateTransition113044.duration = 0.15f;
			m_AnimatorStateTransition113044.exitTime = 0.9076923f;
			m_AnimatorStateTransition113044.hasExitTime = false;
			m_AnimatorStateTransition113044.hasFixedDuration = true;
			m_AnimatorStateTransition113044.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition113044.offset = 0f;
			m_AnimatorStateTransition113044.orderedInterruption = true;
			m_AnimatorStateTransition113044.isExit = true;
			m_AnimatorStateTransition113044.mute = false;
			m_AnimatorStateTransition113044.solo = false;
			m_AnimatorStateTransition113044.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var m_AnimatorStateTransition60982 = m_TransferLeftAnimatorState60956.AddTransition(m_HangAnimatorState60952);
			m_AnimatorStateTransition60982.canTransitionToSelf = true;
			m_AnimatorStateTransition60982.duration = 0.15f;
			m_AnimatorStateTransition60982.exitTime = 0.95f;
			m_AnimatorStateTransition60982.hasExitTime = true;
			m_AnimatorStateTransition60982.hasFixedDuration = true;
			m_AnimatorStateTransition60982.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60982.offset = 0f;
			m_AnimatorStateTransition60982.orderedInterruption = true;
			m_AnimatorStateTransition60982.isExit = false;
			m_AnimatorStateTransition60982.mute = false;
			m_AnimatorStateTransition60982.solo = false;

			var m_AnimatorStateTransition113274 = m_TransferLeftAnimatorState60956.AddExitTransition();
			m_AnimatorStateTransition113274.canTransitionToSelf = true;
			m_AnimatorStateTransition113274.duration = 0.15f;
			m_AnimatorStateTransition113274.exitTime = 0.9076923f;
			m_AnimatorStateTransition113274.hasExitTime = false;
			m_AnimatorStateTransition113274.hasFixedDuration = true;
			m_AnimatorStateTransition113274.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition113274.offset = 0f;
			m_AnimatorStateTransition113274.orderedInterruption = true;
			m_AnimatorStateTransition113274.isExit = true;
			m_AnimatorStateTransition113274.mute = false;
			m_AnimatorStateTransition113274.solo = false;
			m_AnimatorStateTransition113274.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var m_AnimatorStateTransition60984 = m_TransferUpAnimatorState60958.AddTransition(m_HangAnimatorState60952);
			m_AnimatorStateTransition60984.canTransitionToSelf = true;
			m_AnimatorStateTransition60984.duration = 0.15f;
			m_AnimatorStateTransition60984.exitTime = 0.95f;
			m_AnimatorStateTransition60984.hasExitTime = true;
			m_AnimatorStateTransition60984.hasFixedDuration = true;
			m_AnimatorStateTransition60984.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60984.offset = 0f;
			m_AnimatorStateTransition60984.orderedInterruption = true;
			m_AnimatorStateTransition60984.isExit = false;
			m_AnimatorStateTransition60984.mute = false;
			m_AnimatorStateTransition60984.solo = false;

			var m_AnimatorStateTransition112732 = m_TransferUpAnimatorState60958.AddExitTransition();
			m_AnimatorStateTransition112732.canTransitionToSelf = true;
			m_AnimatorStateTransition112732.duration = 0.15f;
			m_AnimatorStateTransition112732.exitTime = 0.8823529f;
			m_AnimatorStateTransition112732.hasExitTime = false;
			m_AnimatorStateTransition112732.hasFixedDuration = true;
			m_AnimatorStateTransition112732.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition112732.offset = 0f;
			m_AnimatorStateTransition112732.orderedInterruption = true;
			m_AnimatorStateTransition112732.isExit = true;
			m_AnimatorStateTransition112732.mute = false;
			m_AnimatorStateTransition112732.solo = false;
			m_AnimatorStateTransition112732.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var m_AnimatorStateTransition60986 = m_DropStartAnimatorState60128.AddTransition(m_HangAnimatorState60952);
			m_AnimatorStateTransition60986.canTransitionToSelf = true;
			m_AnimatorStateTransition60986.duration = 0.15f;
			m_AnimatorStateTransition60986.exitTime = 0.99f;
			m_AnimatorStateTransition60986.hasExitTime = true;
			m_AnimatorStateTransition60986.hasFixedDuration = true;
			m_AnimatorStateTransition60986.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60986.offset = 0f;
			m_AnimatorStateTransition60986.orderedInterruption = true;
			m_AnimatorStateTransition60986.isExit = false;
			m_AnimatorStateTransition60986.mute = false;
			m_AnimatorStateTransition60986.solo = false;

			var m_AnimatorStateTransition60988 = m_PullUpAnimatorState60960.AddExitTransition();
			m_AnimatorStateTransition60988.canTransitionToSelf = true;
			m_AnimatorStateTransition60988.duration = 0.25f;
			m_AnimatorStateTransition60988.exitTime = 0.95f;
			m_AnimatorStateTransition60988.hasExitTime = false;
			m_AnimatorStateTransition60988.hasFixedDuration = true;
			m_AnimatorStateTransition60988.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60988.offset = 0f;
			m_AnimatorStateTransition60988.orderedInterruption = true;
			m_AnimatorStateTransition60988.isExit = true;
			m_AnimatorStateTransition60988.mute = false;
			m_AnimatorStateTransition60988.solo = false;
			m_AnimatorStateTransition60988.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var m_AnimatorStateTransition60990 = m_TransferDownAnimatorState60962.AddTransition(m_HangAnimatorState60952);
			m_AnimatorStateTransition60990.canTransitionToSelf = true;
			m_AnimatorStateTransition60990.duration = 0.15f;
			m_AnimatorStateTransition60990.exitTime = 0.95f;
			m_AnimatorStateTransition60990.hasExitTime = true;
			m_AnimatorStateTransition60990.hasFixedDuration = true;
			m_AnimatorStateTransition60990.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60990.offset = 0f;
			m_AnimatorStateTransition60990.orderedInterruption = true;
			m_AnimatorStateTransition60990.isExit = false;
			m_AnimatorStateTransition60990.mute = false;
			m_AnimatorStateTransition60990.solo = false;

			var m_AnimatorStateTransition112694 = m_TransferDownAnimatorState60962.AddExitTransition();
			m_AnimatorStateTransition112694.canTransitionToSelf = true;
			m_AnimatorStateTransition112694.duration = 0.15f;
			m_AnimatorStateTransition112694.exitTime = 0.8823529f;
			m_AnimatorStateTransition112694.hasExitTime = false;
			m_AnimatorStateTransition112694.hasFixedDuration = true;
			m_AnimatorStateTransition112694.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition112694.offset = 0f;
			m_AnimatorStateTransition112694.orderedInterruption = true;
			m_AnimatorStateTransition112694.isExit = true;
			m_AnimatorStateTransition112694.mute = false;
			m_AnimatorStateTransition112694.solo = false;
			m_AnimatorStateTransition112694.AddCondition(AnimatorConditionMode.NotEqual, 104f, "AbilityIndex");

			var m_AnimatorStateTransition60992 = m_HangJumpStartAnimatorState60130.AddTransition(m_HangAnimatorState60952);
			m_AnimatorStateTransition60992.canTransitionToSelf = true;
			m_AnimatorStateTransition60992.duration = 0.05f;
			m_AnimatorStateTransition60992.exitTime = 0.95f;
			m_AnimatorStateTransition60992.hasExitTime = true;
			m_AnimatorStateTransition60992.hasFixedDuration = true;
			m_AnimatorStateTransition60992.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60992.offset = 0f;
			m_AnimatorStateTransition60992.orderedInterruption = true;
			m_AnimatorStateTransition60992.isExit = false;
			m_AnimatorStateTransition60992.mute = false;
			m_AnimatorStateTransition60992.solo = false;

			var m_AnimatorStateTransition60994 = m_DropStartfromLedgeStrafeAnimatorState60132.AddTransition(m_HangAnimatorState60952);
			m_AnimatorStateTransition60994.canTransitionToSelf = true;
			m_AnimatorStateTransition60994.duration = 0.15f;
			m_AnimatorStateTransition60994.exitTime = 0.99f;
			m_AnimatorStateTransition60994.hasExitTime = true;
			m_AnimatorStateTransition60994.hasFixedDuration = true;
			m_AnimatorStateTransition60994.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60994.offset = 0f;
			m_AnimatorStateTransition60994.orderedInterruption = true;
			m_AnimatorStateTransition60994.isExit = false;
			m_AnimatorStateTransition60994.mute = false;
			m_AnimatorStateTransition60994.solo = false;

			// State Machine Defaults.
			m_HangAnimatorStateMachine59878.anyStatePosition = new Vector3(-84f, -72f, 0f);
			m_HangAnimatorStateMachine59878.defaultState = m_HangAnimatorState60952;
			m_HangAnimatorStateMachine59878.entryPosition = new Vector3(-84f, -156f, 0f);
			m_HangAnimatorStateMachine59878.exitPosition = new Vector3(876f, -84f, 0f);
			m_HangAnimatorStateMachine59878.parentStateMachinePosition = new Vector3(852f, -168f, 0f);

			// State Machine Transitions.
			var m_AnimatorStateTransition60024 = baseStateMachine12.AddAnyStateTransition(m_DropStartAnimatorState60128);
			m_AnimatorStateTransition60024.canTransitionToSelf = false;
			m_AnimatorStateTransition60024.duration = 0.15f;
			m_AnimatorStateTransition60024.exitTime = 0.75f;
			m_AnimatorStateTransition60024.hasExitTime = false;
			m_AnimatorStateTransition60024.hasFixedDuration = true;
			m_AnimatorStateTransition60024.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60024.offset = 0f;
			m_AnimatorStateTransition60024.orderedInterruption = true;
			m_AnimatorStateTransition60024.isExit = false;
			m_AnimatorStateTransition60024.mute = false;
			m_AnimatorStateTransition60024.solo = false;
			m_AnimatorStateTransition60024.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition60024.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			m_AnimatorStateTransition60024.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			m_AnimatorStateTransition60024.AddCondition(AnimatorConditionMode.Less, 0.1f, "AbilityFloatData");

			var m_AnimatorStateTransition60026 = baseStateMachine12.AddAnyStateTransition(m_HangJumpStartAnimatorState60130);
			m_AnimatorStateTransition60026.canTransitionToSelf = false;
			m_AnimatorStateTransition60026.duration = 0.05f;
			m_AnimatorStateTransition60026.exitTime = 0.75f;
			m_AnimatorStateTransition60026.hasExitTime = false;
			m_AnimatorStateTransition60026.hasFixedDuration = true;
			m_AnimatorStateTransition60026.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60026.offset = 0f;
			m_AnimatorStateTransition60026.orderedInterruption = true;
			m_AnimatorStateTransition60026.isExit = false;
			m_AnimatorStateTransition60026.mute = false;
			m_AnimatorStateTransition60026.solo = false;
			m_AnimatorStateTransition60026.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition60026.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			m_AnimatorStateTransition60026.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");

			var m_AnimatorStateTransition60028 = baseStateMachine12.AddAnyStateTransition(m_DropStartfromLedgeStrafeAnimatorState60132);
			m_AnimatorStateTransition60028.canTransitionToSelf = false;
			m_AnimatorStateTransition60028.duration = 0.15f;
			m_AnimatorStateTransition60028.exitTime = 0.75f;
			m_AnimatorStateTransition60028.hasExitTime = false;
			m_AnimatorStateTransition60028.hasFixedDuration = true;
			m_AnimatorStateTransition60028.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60028.offset = 0f;
			m_AnimatorStateTransition60028.orderedInterruption = true;
			m_AnimatorStateTransition60028.isExit = false;
			m_AnimatorStateTransition60028.mute = false;
			m_AnimatorStateTransition60028.solo = false;
			m_AnimatorStateTransition60028.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition60028.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			m_AnimatorStateTransition60028.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			m_AnimatorStateTransition60028.AddCondition(AnimatorConditionMode.Greater, 0.9f, "AbilityFloatData");
			m_AnimatorStateTransition60028.AddCondition(AnimatorConditionMode.Less, 1.1f, "AbilityFloatData");

			var m_AnimatorStateTransition60030 = baseStateMachine12.AddAnyStateTransition(m_HangStartAnimatorState60134);
			m_AnimatorStateTransition60030.canTransitionToSelf = false;
			m_AnimatorStateTransition60030.duration = 0.2f;
			m_AnimatorStateTransition60030.exitTime = 0.75f;
			m_AnimatorStateTransition60030.hasExitTime = false;
			m_AnimatorStateTransition60030.hasFixedDuration = true;
			m_AnimatorStateTransition60030.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition60030.offset = 0f;
			m_AnimatorStateTransition60030.orderedInterruption = true;
			m_AnimatorStateTransition60030.isExit = false;
			m_AnimatorStateTransition60030.mute = false;
			m_AnimatorStateTransition60030.solo = false;
			m_AnimatorStateTransition60030.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition60030.AddCondition(AnimatorConditionMode.Equals, 104f, "AbilityIndex");
			m_AnimatorStateTransition60030.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
		}
	}
}
