/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

namespace Opsive.UltimateCharacterController.AddOns.Agility.Editor.Inspectors.Character.Abilities
{
	using Opsive.UltimateCharacterController.Editor.Inspectors;
	using Opsive.UltimateCharacterController.Editor.Inspectors.Character;
	using Opsive.UltimateCharacterController.Editor.Utility;
	using UnityEditor;
	using UnityEditor.Animations;
	using UnityEngine;

	/// <summary>
	/// Draws a custom inspector for the Balance Ability.
	/// </summary>
	[InspectorDrawer(typeof(Balance))]
	public class BalanceInspectorDrawer : AbilityInspectorDrawer
	{
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
			var baseStateMachine0 = animatorController.layers[0].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine0.stateMachines.Length; ++j) {
					if (baseStateMachine0.stateMachines[j].stateMachine.name == "Balance") {
						baseStateMachine0.RemoveStateMachine(baseStateMachine0.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var m_BalanceBwdAnimationClip22892Path = AssetDatabase.GUIDToAssetPath("1eb167ae0309ef345acbb8e77a657f82"); 
			var m_BalanceBwdAnimationClip22892 = AnimatorBuilder.GetAnimationClip(m_BalanceBwdAnimationClip22892Path, "BalanceBwd");
			var m_BalanceIdleRightAnimationClip15634Path = AssetDatabase.GUIDToAssetPath("a433ee9521fa9d741b694e52eb438d29"); 
			var m_BalanceIdleRightAnimationClip15634 = AnimatorBuilder.GetAnimationClip(m_BalanceIdleRightAnimationClip15634Path, "BalanceIdleRight");
			var m_BalanceFwdAnimationClip23236Path = AssetDatabase.GUIDToAssetPath("47a0520f151e5c643aa6ef9c68654a51"); 
			var m_BalanceFwdAnimationClip23236 = AnimatorBuilder.GetAnimationClip(m_BalanceFwdAnimationClip23236Path, "BalanceFwd");
			var m_BalanceIdleLeftAnimationClip15632Path = AssetDatabase.GUIDToAssetPath("a433ee9521fa9d741b694e52eb438d29"); 
			var m_BalanceIdleLeftAnimationClip15632 = AnimatorBuilder.GetAnimationClip(m_BalanceIdleLeftAnimationClip15632Path, "BalanceIdleLeft");

			// State Machine.
			var m_BalanceAnimatorStateMachine420332 = baseStateMachine0.AddStateMachine("Balance", new Vector3(624f, 12f, 0f));

			// States.
			var m_BalanceMovementAnimatorState420320 = m_BalanceAnimatorStateMachine420332.AddState("Balance Movement", new Vector3(432f, 96f, 0f));
			var m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228 = new BlendTree();
			AssetDatabase.AddObjectToAsset(m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228, animatorController);
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228.hideFlags = HideFlags.HideInHierarchy;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228.blendParameter = "ForwardMovement";
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228.blendParameterY = "ForwardMovement";
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228.blendType = BlendTreeType.Simple1D;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228.maxThreshold = 1f;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228.minThreshold = -1f;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228.name = "Blend Tree";
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228.useAutomaticThresholds = false;
			var m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child0=  new ChildMotion();
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child0.motion = m_BalanceBwdAnimationClip22892;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child0.cycleOffset = 0f;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child0.directBlendParameter = "HorizontalMovement";
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child0.mirror = false;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child0.position = new Vector2(0f, -1f);
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child0.threshold = -1f;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child0.timeScale = 1.4f;
			var m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child1=  new ChildMotion();
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child1.motion = m_BalanceIdleRightAnimationClip15634;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child1.cycleOffset = 0f;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child1.directBlendParameter = "HorizontalMovement";
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child1.mirror = false;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child1.position = new Vector2(0f, 0f);
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child1.threshold = 0f;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child1.timeScale = 1f;
			var m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child2=  new ChildMotion();
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child2.motion = m_BalanceFwdAnimationClip23236;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child2.cycleOffset = 0f;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child2.directBlendParameter = "HorizontalMovement";
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child2.mirror = false;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child2.position = new Vector2(0f, 1f);
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child2.threshold = 1f;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child2.timeScale = 1.4f;
			m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228.children = new ChildMotion[] {
				m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child0,
				m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child1,
				m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228Child2
			};
			m_BalanceMovementAnimatorState420320.motion = m_BalanceMovementAnimatorState420320m_BlendTreeBlendTree418228;
			m_BalanceMovementAnimatorState420320.cycleOffset = 0f;
			m_BalanceMovementAnimatorState420320.cycleOffsetParameterActive = false;
			m_BalanceMovementAnimatorState420320.iKOnFeet = true;
			m_BalanceMovementAnimatorState420320.mirror = false;
			m_BalanceMovementAnimatorState420320.mirrorParameterActive = false;
			m_BalanceMovementAnimatorState420320.speed = 1f;
			m_BalanceMovementAnimatorState420320.speedParameterActive = false;
			m_BalanceMovementAnimatorState420320.writeDefaultValues = true;

			var m_BalanceIdleLeftAnimatorState420282 = m_BalanceAnimatorStateMachine420332.AddState("Balance Idle Left", new Vector3(564f, -24f, 0f));
			m_BalanceIdleLeftAnimatorState420282.motion = m_BalanceIdleLeftAnimationClip15632;
			m_BalanceIdleLeftAnimatorState420282.cycleOffset = 0f;
			m_BalanceIdleLeftAnimatorState420282.cycleOffsetParameterActive = false;
			m_BalanceIdleLeftAnimatorState420282.iKOnFeet = true;
			m_BalanceIdleLeftAnimatorState420282.mirror = false;
			m_BalanceIdleLeftAnimatorState420282.mirrorParameterActive = false;
			m_BalanceIdleLeftAnimatorState420282.speed = 1f;
			m_BalanceIdleLeftAnimatorState420282.speedParameterActive = false;
			m_BalanceIdleLeftAnimatorState420282.writeDefaultValues = true;

			var m_BalanceIdleRightAnimatorState420070 = m_BalanceAnimatorStateMachine420332.AddState("Balance Idle Right", new Vector3(312f, -24f, 0f));
			m_BalanceIdleRightAnimatorState420070.motion = m_BalanceIdleRightAnimationClip15634;
			m_BalanceIdleRightAnimatorState420070.cycleOffset = 0f;
			m_BalanceIdleRightAnimatorState420070.cycleOffsetParameterActive = false;
			m_BalanceIdleRightAnimatorState420070.iKOnFeet = true;
			m_BalanceIdleRightAnimatorState420070.mirror = false;
			m_BalanceIdleRightAnimatorState420070.mirrorParameterActive = false;
			m_BalanceIdleRightAnimatorState420070.speed = 1f;
			m_BalanceIdleRightAnimatorState420070.speedParameterActive = false;
			m_BalanceIdleRightAnimatorState420070.writeDefaultValues = true;

			// State Transitions.
			var m_AnimatorStateTransition419492 = m_BalanceMovementAnimatorState420320.AddExitTransition();
			m_AnimatorStateTransition419492.canTransitionToSelf = true;
			m_AnimatorStateTransition419492.duration = 0.15f;
			m_AnimatorStateTransition419492.exitTime = 0.9f;
			m_AnimatorStateTransition419492.hasExitTime = false;
			m_AnimatorStateTransition419492.hasFixedDuration = true;
			m_AnimatorStateTransition419492.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419492.offset = 0f;
			m_AnimatorStateTransition419492.orderedInterruption = true;
			m_AnimatorStateTransition419492.isExit = true;
			m_AnimatorStateTransition419492.mute = false;
			m_AnimatorStateTransition419492.solo = false;
			m_AnimatorStateTransition419492.AddCondition(AnimatorConditionMode.NotEqual, 107f, "AbilityIndex");

			var m_AnimatorStateTransition418998 = m_BalanceMovementAnimatorState420320.AddTransition(m_BalanceIdleRightAnimatorState420070);
			m_AnimatorStateTransition418998.canTransitionToSelf = true;
			m_AnimatorStateTransition418998.duration = 0.3f;
			m_AnimatorStateTransition418998.exitTime = 0.91f;
			m_AnimatorStateTransition418998.hasExitTime = false;
			m_AnimatorStateTransition418998.hasFixedDuration = true;
			m_AnimatorStateTransition418998.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418998.offset = 0f;
			m_AnimatorStateTransition418998.orderedInterruption = true;
			m_AnimatorStateTransition418998.isExit = false;
			m_AnimatorStateTransition418998.mute = false;
			m_AnimatorStateTransition418998.solo = false;
			m_AnimatorStateTransition418998.AddCondition(AnimatorConditionMode.Equals, 107f, "AbilityIndex");
			m_AnimatorStateTransition418998.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			m_AnimatorStateTransition418998.AddCondition(AnimatorConditionMode.Less, 0.499f, "LegIndex");

			var m_AnimatorStateTransition419902 = m_BalanceMovementAnimatorState420320.AddTransition(m_BalanceIdleLeftAnimatorState420282);
			m_AnimatorStateTransition419902.canTransitionToSelf = true;
			m_AnimatorStateTransition419902.duration = 0.3f;
			m_AnimatorStateTransition419902.exitTime = 0.91f;
			m_AnimatorStateTransition419902.hasExitTime = false;
			m_AnimatorStateTransition419902.hasFixedDuration = true;
			m_AnimatorStateTransition419902.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419902.offset = 0f;
			m_AnimatorStateTransition419902.orderedInterruption = true;
			m_AnimatorStateTransition419902.isExit = false;
			m_AnimatorStateTransition419902.mute = false;
			m_AnimatorStateTransition419902.solo = false;
			m_AnimatorStateTransition419902.AddCondition(AnimatorConditionMode.Equals, 107f, "AbilityIndex");
			m_AnimatorStateTransition419902.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
			m_AnimatorStateTransition419902.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var m_AnimatorStateTransition419638 = m_BalanceIdleLeftAnimatorState420282.AddExitTransition();
			m_AnimatorStateTransition419638.canTransitionToSelf = true;
			m_AnimatorStateTransition419638.duration = 0.15f;
			m_AnimatorStateTransition419638.exitTime = 0.95f;
			m_AnimatorStateTransition419638.hasExitTime = false;
			m_AnimatorStateTransition419638.hasFixedDuration = true;
			m_AnimatorStateTransition419638.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419638.offset = 0f;
			m_AnimatorStateTransition419638.orderedInterruption = true;
			m_AnimatorStateTransition419638.isExit = true;
			m_AnimatorStateTransition419638.mute = false;
			m_AnimatorStateTransition419638.solo = false;
			m_AnimatorStateTransition419638.AddCondition(AnimatorConditionMode.NotEqual, 107f, "AbilityIndex");

			var m_AnimatorStateTransition418970 = m_BalanceIdleLeftAnimatorState420282.AddTransition(m_BalanceMovementAnimatorState420320);
			m_AnimatorStateTransition418970.canTransitionToSelf = true;
			m_AnimatorStateTransition418970.duration = 0.2f;
			m_AnimatorStateTransition418970.exitTime = 0.95f;
			m_AnimatorStateTransition418970.hasExitTime = false;
			m_AnimatorStateTransition418970.hasFixedDuration = true;
			m_AnimatorStateTransition418970.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418970.offset = 0.6f;
			m_AnimatorStateTransition418970.orderedInterruption = true;
			m_AnimatorStateTransition418970.isExit = false;
			m_AnimatorStateTransition418970.mute = false;
			m_AnimatorStateTransition418970.solo = false;
			m_AnimatorStateTransition418970.AddCondition(AnimatorConditionMode.Equals, 107f, "AbilityIndex");
			m_AnimatorStateTransition418970.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			var m_AnimatorStateTransition419534 = m_BalanceIdleRightAnimatorState420070.AddExitTransition();
			m_AnimatorStateTransition419534.canTransitionToSelf = true;
			m_AnimatorStateTransition419534.duration = 0.15f;
			m_AnimatorStateTransition419534.exitTime = 0.95f;
			m_AnimatorStateTransition419534.hasExitTime = false;
			m_AnimatorStateTransition419534.hasFixedDuration = true;
			m_AnimatorStateTransition419534.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419534.offset = 0f;
			m_AnimatorStateTransition419534.orderedInterruption = true;
			m_AnimatorStateTransition419534.isExit = true;
			m_AnimatorStateTransition419534.mute = false;
			m_AnimatorStateTransition419534.solo = false;
			m_AnimatorStateTransition419534.AddCondition(AnimatorConditionMode.NotEqual, 107f, "AbilityIndex");

			var m_AnimatorStateTransition419434 = m_BalanceIdleRightAnimatorState420070.AddTransition(m_BalanceMovementAnimatorState420320);
			m_AnimatorStateTransition419434.canTransitionToSelf = true;
			m_AnimatorStateTransition419434.duration = 0.2f;
			m_AnimatorStateTransition419434.exitTime = 0.95f;
			m_AnimatorStateTransition419434.hasExitTime = false;
			m_AnimatorStateTransition419434.hasFixedDuration = true;
			m_AnimatorStateTransition419434.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419434.offset = 0.1f;
			m_AnimatorStateTransition419434.orderedInterruption = true;
			m_AnimatorStateTransition419434.isExit = false;
			m_AnimatorStateTransition419434.mute = false;
			m_AnimatorStateTransition419434.solo = false;
			m_AnimatorStateTransition419434.AddCondition(AnimatorConditionMode.Equals, 107f, "AbilityIndex");
			m_AnimatorStateTransition419434.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			// State Machine Defaults.
			m_BalanceAnimatorStateMachine420332.anyStatePosition = new Vector3(50f, 20f, 0f);
			m_BalanceAnimatorStateMachine420332.defaultState = m_BalanceMovementAnimatorState420320;
			m_BalanceAnimatorStateMachine420332.entryPosition = new Vector3(50f, 120f, 0f);
			m_BalanceAnimatorStateMachine420332.exitPosition = new Vector3(800f, 120f, 0f);
			m_BalanceAnimatorStateMachine420332.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Machine Transitions.
			var m_AnimatorStateTransition418944 = baseStateMachine0.AddAnyStateTransition(m_BalanceMovementAnimatorState420320);
			m_AnimatorStateTransition418944.canTransitionToSelf = false;
			m_AnimatorStateTransition418944.duration = 0.15f;
			m_AnimatorStateTransition418944.exitTime = 0.75f;
			m_AnimatorStateTransition418944.hasExitTime = false;
			m_AnimatorStateTransition418944.hasFixedDuration = true;
			m_AnimatorStateTransition418944.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418944.offset = 0f;
			m_AnimatorStateTransition418944.orderedInterruption = true;
			m_AnimatorStateTransition418944.isExit = false;
			m_AnimatorStateTransition418944.mute = false;
			m_AnimatorStateTransition418944.solo = false;
			m_AnimatorStateTransition418944.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition418944.AddCondition(AnimatorConditionMode.Equals, 107f, "AbilityIndex");
			m_AnimatorStateTransition418944.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			var m_AnimatorStateTransition418728 = baseStateMachine0.AddAnyStateTransition(m_BalanceIdleRightAnimatorState420070);
			m_AnimatorStateTransition418728.canTransitionToSelf = false;
			m_AnimatorStateTransition418728.duration = 0.15f;
			m_AnimatorStateTransition418728.exitTime = 0.75f;
			m_AnimatorStateTransition418728.hasExitTime = false;
			m_AnimatorStateTransition418728.hasFixedDuration = true;
			m_AnimatorStateTransition418728.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418728.offset = 0f;
			m_AnimatorStateTransition418728.orderedInterruption = true;
			m_AnimatorStateTransition418728.isExit = false;
			m_AnimatorStateTransition418728.mute = false;
			m_AnimatorStateTransition418728.solo = false;
			m_AnimatorStateTransition418728.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition418728.AddCondition(AnimatorConditionMode.Equals, 107f, "AbilityIndex");
			m_AnimatorStateTransition418728.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");
		}
	}
}
