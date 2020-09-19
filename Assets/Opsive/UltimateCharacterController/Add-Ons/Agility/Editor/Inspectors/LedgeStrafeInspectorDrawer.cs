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
	/// Draws a custom inspector for the LedgeStrafe Ability.
	/// </summary>
	[InspectorDrawer(typeof(LedgeStrafe))]
	public class LedgeStrafeInspectorDrawer : AbilityInspectorDrawer
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
					if (baseStateMachine0.stateMachines[j].stateMachine.name == "Ledge Strafe") {
						baseStateMachine0.RemoveStateMachine(baseStateMachine0.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var m_LedgeStrafeIdleAnimationClip11570Path = AssetDatabase.GUIDToAssetPath("74100d50a4867ba4bbc2e29cb7155f66"); 
			var m_LedgeStrafeIdleAnimationClip11570 = AnimatorBuilder.GetAnimationClip(m_LedgeStrafeIdleAnimationClip11570Path, "LedgeStrafeIdle");
			var m_LedgeStrafeRightAnimationClip20500Path = AssetDatabase.GUIDToAssetPath("1f453c6b5910ecb46a0c7053d5cbc64e"); 
			var m_LedgeStrafeRightAnimationClip20500 = AnimatorBuilder.GetAnimationClip(m_LedgeStrafeRightAnimationClip20500Path, "LedgeStrafeRight");
			var m_LedgeStrafeLeftAnimationClip20498Path = AssetDatabase.GUIDToAssetPath("1f453c6b5910ecb46a0c7053d5cbc64e"); 
			var m_LedgeStrafeLeftAnimationClip20498 = AnimatorBuilder.GetAnimationClip(m_LedgeStrafeLeftAnimationClip20498Path, "LedgeStrafeLeft");

			// State Machine.
			var m_LedgeStrafeAnimatorStateMachine420368 = baseStateMachine0.AddStateMachine("Ledge Strafe", new Vector3(624f, 108f, 0f));

			// States.
			var m_LedgeIdleAnimatorState420312 = m_LedgeStrafeAnimatorStateMachine420368.AddState("Ledge Idle", new Vector3(384f, 0f, 0f));
			m_LedgeIdleAnimatorState420312.motion = m_LedgeStrafeIdleAnimationClip11570;
			m_LedgeIdleAnimatorState420312.cycleOffset = 0f;
			m_LedgeIdleAnimatorState420312.cycleOffsetParameterActive = false;
			m_LedgeIdleAnimatorState420312.iKOnFeet = true;
			m_LedgeIdleAnimatorState420312.mirror = false;
			m_LedgeIdleAnimatorState420312.mirrorParameterActive = false;
			m_LedgeIdleAnimatorState420312.speed = 1f;
			m_LedgeIdleAnimatorState420312.speedParameterActive = false;
			m_LedgeIdleAnimatorState420312.writeDefaultValues = true;

			var m_LedgeStrafeAnimatorState420020 = m_LedgeStrafeAnimatorStateMachine420368.AddState("Ledge Strafe", new Vector3(384f, 108f, 0f));
			var m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172 = new BlendTree();
			AssetDatabase.AddObjectToAsset(m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172, animatorController);
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172.hideFlags = HideFlags.HideInHierarchy;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172.blendParameter = "HorizontalMovement";
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172.blendParameterY = "HorizontalMovement";
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172.blendType = BlendTreeType.Simple1D;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172.maxThreshold = 1f;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172.minThreshold = -1f;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172.name = "Blend Tree";
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172.useAutomaticThresholds = false;
			var m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child0=  new ChildMotion();
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child0.motion = m_LedgeStrafeRightAnimationClip20500;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child0.cycleOffset = 0f;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child0.directBlendParameter = "HorizontalMovement";
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child0.mirror = false;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child0.position = new Vector2(0f, 0f);
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child0.threshold = -1f;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child0.timeScale = 2f;
			var m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child1=  new ChildMotion();
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child1.motion = m_LedgeStrafeIdleAnimationClip11570;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child1.cycleOffset = 0f;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child1.directBlendParameter = "HorizontalMovement";
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child1.mirror = false;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child1.position = new Vector2(0f, 0f);
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child1.threshold = 0f;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child1.timeScale = 1f;
			var m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child2=  new ChildMotion();
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child2.motion = m_LedgeStrafeLeftAnimationClip20498;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child2.cycleOffset = 0f;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child2.directBlendParameter = "HorizontalMovement";
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child2.mirror = false;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child2.position = new Vector2(0f, 0f);
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child2.threshold = 1f;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child2.timeScale = 2f;
			m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172.children = new ChildMotion[] {
				m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child0,
				m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child1,
				m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172Child2
			};
			m_LedgeStrafeAnimatorState420020.motion = m_LedgeStrafeAnimatorState420020m_BlendTreeBlendTree418172;
			m_LedgeStrafeAnimatorState420020.cycleOffset = 0f;
			m_LedgeStrafeAnimatorState420020.cycleOffsetParameterActive = false;
			m_LedgeStrafeAnimatorState420020.iKOnFeet = true;
			m_LedgeStrafeAnimatorState420020.mirror = false;
			m_LedgeStrafeAnimatorState420020.mirrorParameterActive = false;
			m_LedgeStrafeAnimatorState420020.speed = 1f;
			m_LedgeStrafeAnimatorState420020.speedParameterActive = false;
			m_LedgeStrafeAnimatorState420020.writeDefaultValues = true;

			// State Transitions.
			var m_AnimatorStateTransition419438 = m_LedgeIdleAnimatorState420312.AddExitTransition();
			m_AnimatorStateTransition419438.canTransitionToSelf = true;
			m_AnimatorStateTransition419438.duration = 0.15f;
			m_AnimatorStateTransition419438.exitTime = 0.95f;
			m_AnimatorStateTransition419438.hasExitTime = false;
			m_AnimatorStateTransition419438.hasFixedDuration = true;
			m_AnimatorStateTransition419438.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419438.offset = 0f;
			m_AnimatorStateTransition419438.orderedInterruption = true;
			m_AnimatorStateTransition419438.isExit = true;
			m_AnimatorStateTransition419438.mute = false;
			m_AnimatorStateTransition419438.solo = false;
			m_AnimatorStateTransition419438.AddCondition(AnimatorConditionMode.NotEqual, 106f, "AbilityIndex");

			var m_AnimatorStateTransition418780 = m_LedgeIdleAnimatorState420312.AddTransition(m_LedgeStrafeAnimatorState420020);
			m_AnimatorStateTransition418780.canTransitionToSelf = true;
			m_AnimatorStateTransition418780.duration = 0.1f;
			m_AnimatorStateTransition418780.exitTime = 0.95f;
			m_AnimatorStateTransition418780.hasExitTime = false;
			m_AnimatorStateTransition418780.hasFixedDuration = true;
			m_AnimatorStateTransition418780.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418780.offset = 0.1f;
			m_AnimatorStateTransition418780.orderedInterruption = true;
			m_AnimatorStateTransition418780.isExit = false;
			m_AnimatorStateTransition418780.mute = false;
			m_AnimatorStateTransition418780.solo = false;
			m_AnimatorStateTransition418780.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			m_AnimatorStateTransition418780.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			var m_AnimatorStateTransition419400 = m_LedgeStrafeAnimatorState420020.AddExitTransition();
			m_AnimatorStateTransition419400.canTransitionToSelf = true;
			m_AnimatorStateTransition419400.duration = 0.15f;
			m_AnimatorStateTransition419400.exitTime = 0.95f;
			m_AnimatorStateTransition419400.hasExitTime = false;
			m_AnimatorStateTransition419400.hasFixedDuration = true;
			m_AnimatorStateTransition419400.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419400.offset = 0f;
			m_AnimatorStateTransition419400.orderedInterruption = true;
			m_AnimatorStateTransition419400.isExit = true;
			m_AnimatorStateTransition419400.mute = false;
			m_AnimatorStateTransition419400.solo = false;
			m_AnimatorStateTransition419400.AddCondition(AnimatorConditionMode.NotEqual, 106f, "AbilityIndex");

			var m_AnimatorStateTransition419738 = m_LedgeStrafeAnimatorState420020.AddTransition(m_LedgeIdleAnimatorState420312);
			m_AnimatorStateTransition419738.canTransitionToSelf = true;
			m_AnimatorStateTransition419738.duration = 0.25f;
			m_AnimatorStateTransition419738.exitTime = 0.91f;
			m_AnimatorStateTransition419738.hasExitTime = false;
			m_AnimatorStateTransition419738.hasFixedDuration = true;
			m_AnimatorStateTransition419738.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419738.offset = 0f;
			m_AnimatorStateTransition419738.orderedInterruption = true;
			m_AnimatorStateTransition419738.isExit = false;
			m_AnimatorStateTransition419738.mute = false;
			m_AnimatorStateTransition419738.solo = false;
			m_AnimatorStateTransition419738.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			m_AnimatorStateTransition419738.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			// State Machine Defaults.
			m_LedgeStrafeAnimatorStateMachine420368.anyStatePosition = new Vector3(50f, 20f, 0f);
			m_LedgeStrafeAnimatorStateMachine420368.defaultState = m_LedgeIdleAnimatorState420312;
			m_LedgeStrafeAnimatorStateMachine420368.entryPosition = new Vector3(50f, 120f, 0f);
			m_LedgeStrafeAnimatorStateMachine420368.exitPosition = new Vector3(800f, 120f, 0f);
			m_LedgeStrafeAnimatorStateMachine420368.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Machine Transitions.
			var m_AnimatorStateTransition419822 = baseStateMachine0.AddAnyStateTransition(m_LedgeIdleAnimatorState420312);
			m_AnimatorStateTransition419822.canTransitionToSelf = false;
			m_AnimatorStateTransition419822.duration = 0.15f;
			m_AnimatorStateTransition419822.exitTime = 0.75f;
			m_AnimatorStateTransition419822.hasExitTime = false;
			m_AnimatorStateTransition419822.hasFixedDuration = true;
			m_AnimatorStateTransition419822.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419822.offset = 0f;
			m_AnimatorStateTransition419822.orderedInterruption = true;
			m_AnimatorStateTransition419822.isExit = false;
			m_AnimatorStateTransition419822.mute = false;
			m_AnimatorStateTransition419822.solo = false;
			m_AnimatorStateTransition419822.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition419822.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			m_AnimatorStateTransition419822.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var m_AnimatorStateTransition419234 = baseStateMachine0.AddAnyStateTransition(m_LedgeStrafeAnimatorState420020);
			m_AnimatorStateTransition419234.canTransitionToSelf = false;
			m_AnimatorStateTransition419234.duration = 0.15f;
			m_AnimatorStateTransition419234.exitTime = 0.75f;
			m_AnimatorStateTransition419234.hasExitTime = false;
			m_AnimatorStateTransition419234.hasFixedDuration = true;
			m_AnimatorStateTransition419234.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419234.offset = 0f;
			m_AnimatorStateTransition419234.orderedInterruption = true;
			m_AnimatorStateTransition419234.isExit = false;
			m_AnimatorStateTransition419234.mute = false;
			m_AnimatorStateTransition419234.solo = false;
			m_AnimatorStateTransition419234.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition419234.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			m_AnimatorStateTransition419234.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			var baseStateMachine5 = animatorController.layers[5].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine5.stateMachines.Length; ++j) {
					if (baseStateMachine5.stateMachines[j].stateMachine.name == "Ledge Strafe") {
						baseStateMachine5.RemoveStateMachine(baseStateMachine5.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var m_DualPistolIdleAnimationClip13016Path = AssetDatabase.GUIDToAssetPath("abd3b20228164e44b8fa1597ee6dfe31"); 
			var m_DualPistolIdleAnimationClip13016 = AnimatorBuilder.GetAnimationClip(m_DualPistolIdleAnimationClip13016Path, "DualPistolIdle");
			var m_ShieldIdleAnimationClip19194Path = AssetDatabase.GUIDToAssetPath("17718399930c6ea4b9a734dbe54df24f"); 
			var m_ShieldIdleAnimationClip19194 = AnimatorBuilder.GetAnimationClip(m_ShieldIdleAnimationClip19194Path, "ShieldIdle");

			// State Machine.
			var m_LedgeStrafeAnimatorStateMachine420364 = baseStateMachine5.AddStateMachine("Ledge Strafe", new Vector3(852f, 12f, 0f));

			// States.
			var m_DualPistolAnimatorState420118 = m_LedgeStrafeAnimatorStateMachine420364.AddState("Dual Pistol", new Vector3(384f, 12f, 0f));
			m_DualPistolAnimatorState420118.motion = m_DualPistolIdleAnimationClip13016;
			m_DualPistolAnimatorState420118.cycleOffset = 0f;
			m_DualPistolAnimatorState420118.cycleOffsetParameterActive = false;
			m_DualPistolAnimatorState420118.iKOnFeet = false;
			m_DualPistolAnimatorState420118.mirror = false;
			m_DualPistolAnimatorState420118.mirrorParameterActive = false;
			m_DualPistolAnimatorState420118.speed = 1f;
			m_DualPistolAnimatorState420118.speedParameterActive = false;
			m_DualPistolAnimatorState420118.writeDefaultValues = true;

			var m_ShieldAnimatorState420260 = m_LedgeStrafeAnimatorStateMachine420364.AddState("Shield", new Vector3(384f, 72f, 0f));
			m_ShieldAnimatorState420260.motion = m_ShieldIdleAnimationClip19194;
			m_ShieldAnimatorState420260.cycleOffset = 0f;
			m_ShieldAnimatorState420260.cycleOffsetParameterActive = false;
			m_ShieldAnimatorState420260.iKOnFeet = false;
			m_ShieldAnimatorState420260.mirror = false;
			m_ShieldAnimatorState420260.mirrorParameterActive = false;
			m_ShieldAnimatorState420260.speed = 1f;
			m_ShieldAnimatorState420260.speedParameterActive = false;
			m_ShieldAnimatorState420260.writeDefaultValues = true;

			// State Transitions.
			var m_AnimatorStateTransition419436 = m_DualPistolAnimatorState420118.AddExitTransition();
			m_AnimatorStateTransition419436.canTransitionToSelf = true;
			m_AnimatorStateTransition419436.duration = 0.1f;
			m_AnimatorStateTransition419436.exitTime = 0f;
			m_AnimatorStateTransition419436.hasExitTime = false;
			m_AnimatorStateTransition419436.hasFixedDuration = true;
			m_AnimatorStateTransition419436.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419436.offset = 0f;
			m_AnimatorStateTransition419436.orderedInterruption = true;
			m_AnimatorStateTransition419436.isExit = true;
			m_AnimatorStateTransition419436.mute = false;
			m_AnimatorStateTransition419436.solo = false;
			m_AnimatorStateTransition419436.AddCondition(AnimatorConditionMode.NotEqual, 106f, "AbilityIndex");

			var m_AnimatorStateTransition419270 = m_ShieldAnimatorState420260.AddExitTransition();
			m_AnimatorStateTransition419270.canTransitionToSelf = true;
			m_AnimatorStateTransition419270.duration = 0.1f;
			m_AnimatorStateTransition419270.exitTime = 0f;
			m_AnimatorStateTransition419270.hasExitTime = false;
			m_AnimatorStateTransition419270.hasFixedDuration = true;
			m_AnimatorStateTransition419270.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419270.offset = 0f;
			m_AnimatorStateTransition419270.orderedInterruption = true;
			m_AnimatorStateTransition419270.isExit = true;
			m_AnimatorStateTransition419270.mute = false;
			m_AnimatorStateTransition419270.solo = false;
			m_AnimatorStateTransition419270.AddCondition(AnimatorConditionMode.NotEqual, 106f, "AbilityIndex");

			// State Machine Defaults.
			m_LedgeStrafeAnimatorStateMachine420364.anyStatePosition = new Vector3(48f, 48f, 0f);
			m_LedgeStrafeAnimatorStateMachine420364.defaultState = m_DualPistolAnimatorState420118;
			m_LedgeStrafeAnimatorStateMachine420364.entryPosition = new Vector3(48f, 0f, 0f);
			m_LedgeStrafeAnimatorStateMachine420364.exitPosition = new Vector3(780f, 60f, 0f);
			m_LedgeStrafeAnimatorStateMachine420364.parentStateMachinePosition = new Vector3(756f, 0f, 0f);

			// State Machine Transitions.
			var m_AnimatorStateTransition419664 = baseStateMachine5.AddAnyStateTransition(m_DualPistolAnimatorState420118);
			m_AnimatorStateTransition419664.canTransitionToSelf = false;
			m_AnimatorStateTransition419664.duration = 0.15f;
			m_AnimatorStateTransition419664.exitTime = 0.75f;
			m_AnimatorStateTransition419664.hasExitTime = false;
			m_AnimatorStateTransition419664.hasFixedDuration = true;
			m_AnimatorStateTransition419664.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419664.offset = 0f;
			m_AnimatorStateTransition419664.orderedInterruption = true;
			m_AnimatorStateTransition419664.isExit = false;
			m_AnimatorStateTransition419664.mute = false;
			m_AnimatorStateTransition419664.solo = false;
			m_AnimatorStateTransition419664.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			m_AnimatorStateTransition419664.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot1ItemID");

			var m_AnimatorStateTransition418776 = baseStateMachine5.AddAnyStateTransition(m_ShieldAnimatorState420260);
			m_AnimatorStateTransition418776.canTransitionToSelf = false;
			m_AnimatorStateTransition418776.duration = 0.15f;
			m_AnimatorStateTransition418776.exitTime = 0.75f;
			m_AnimatorStateTransition418776.hasExitTime = false;
			m_AnimatorStateTransition418776.hasFixedDuration = true;
			m_AnimatorStateTransition418776.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418776.offset = 0f;
			m_AnimatorStateTransition418776.orderedInterruption = true;
			m_AnimatorStateTransition418776.isExit = false;
			m_AnimatorStateTransition418776.mute = false;
			m_AnimatorStateTransition418776.solo = false;
			m_AnimatorStateTransition418776.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			m_AnimatorStateTransition418776.AddCondition(AnimatorConditionMode.Equals, 25f, "Slot0ItemID");

			var baseStateMachine6 = animatorController.layers[6].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine6.stateMachines.Length; ++j) {
					if (baseStateMachine6.stateMachines[j].stateMachine.name == "Ledge Strafe") {
						baseStateMachine6.RemoveStateMachine(baseStateMachine6.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var m_SwordIdleMovementAnimationClip16746Path = AssetDatabase.GUIDToAssetPath("7491132715cdf964889b5fc2729270e1"); 
			var m_SwordIdleMovementAnimationClip16746 = AnimatorBuilder.GetAnimationClip(m_SwordIdleMovementAnimationClip16746Path, "SwordIdleMovement");
			var m_KnifeIdleMovementAnimationClip19188Path = AssetDatabase.GUIDToAssetPath("fa9162997c077584ebabf8919a1c1518"); 
			var m_KnifeIdleMovementAnimationClip19188 = AnimatorBuilder.GetAnimationClip(m_KnifeIdleMovementAnimationClip19188Path, "KnifeIdleMovement");

			// State Machine.
			var m_LedgeStrafeAnimatorStateMachine420322 = baseStateMachine6.AddStateMachine("Ledge Strafe", new Vector3(852f, 12f, 0f));

			// States.
			var m_SwordAnimatorState420066 = m_LedgeStrafeAnimatorStateMachine420322.AddState("Sword", new Vector3(384f, 84f, 0f));
			m_SwordAnimatorState420066.motion = m_SwordIdleMovementAnimationClip16746;
			m_SwordAnimatorState420066.cycleOffset = 0f;
			m_SwordAnimatorState420066.cycleOffsetParameterActive = false;
			m_SwordAnimatorState420066.iKOnFeet = false;
			m_SwordAnimatorState420066.mirror = false;
			m_SwordAnimatorState420066.mirrorParameterActive = false;
			m_SwordAnimatorState420066.speed = 1f;
			m_SwordAnimatorState420066.speedParameterActive = false;
			m_SwordAnimatorState420066.writeDefaultValues = true;

			var m_KnifeAnimatorState420062 = m_LedgeStrafeAnimatorStateMachine420322.AddState("Knife", new Vector3(384f, 24f, 0f));
			m_KnifeAnimatorState420062.motion = m_KnifeIdleMovementAnimationClip19188;
			m_KnifeAnimatorState420062.cycleOffset = 0f;
			m_KnifeAnimatorState420062.cycleOffsetParameterActive = false;
			m_KnifeAnimatorState420062.iKOnFeet = false;
			m_KnifeAnimatorState420062.mirror = false;
			m_KnifeAnimatorState420062.mirrorParameterActive = false;
			m_KnifeAnimatorState420062.speed = 1f;
			m_KnifeAnimatorState420062.speedParameterActive = false;
			m_KnifeAnimatorState420062.writeDefaultValues = true;

			var m_DualPistolAnimatorState420004 = m_LedgeStrafeAnimatorStateMachine420322.AddState("Dual Pistol", new Vector3(384f, -36f, 0f));
			m_DualPistolAnimatorState420004.motion = m_DualPistolIdleAnimationClip13016;
			m_DualPistolAnimatorState420004.cycleOffset = 0f;
			m_DualPistolAnimatorState420004.cycleOffsetParameterActive = false;
			m_DualPistolAnimatorState420004.iKOnFeet = false;
			m_DualPistolAnimatorState420004.mirror = false;
			m_DualPistolAnimatorState420004.mirrorParameterActive = false;
			m_DualPistolAnimatorState420004.speed = 1f;
			m_DualPistolAnimatorState420004.speedParameterActive = false;
			m_DualPistolAnimatorState420004.writeDefaultValues = true;

			// State Transitions.
			var m_AnimatorStateTransition418602 = m_SwordAnimatorState420066.AddExitTransition();
			m_AnimatorStateTransition418602.canTransitionToSelf = true;
			m_AnimatorStateTransition418602.duration = 0.1f;
			m_AnimatorStateTransition418602.exitTime = 0f;
			m_AnimatorStateTransition418602.hasExitTime = false;
			m_AnimatorStateTransition418602.hasFixedDuration = true;
			m_AnimatorStateTransition418602.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418602.offset = 0f;
			m_AnimatorStateTransition418602.orderedInterruption = false;
			m_AnimatorStateTransition418602.isExit = true;
			m_AnimatorStateTransition418602.mute = false;
			m_AnimatorStateTransition418602.solo = false;
			m_AnimatorStateTransition418602.AddCondition(AnimatorConditionMode.NotEqual, 106f, "AbilityIndex");

			var m_AnimatorStateTransition418908 = m_KnifeAnimatorState420062.AddExitTransition();
			m_AnimatorStateTransition418908.canTransitionToSelf = true;
			m_AnimatorStateTransition418908.duration = 0.1f;
			m_AnimatorStateTransition418908.exitTime = 0f;
			m_AnimatorStateTransition418908.hasExitTime = false;
			m_AnimatorStateTransition418908.hasFixedDuration = true;
			m_AnimatorStateTransition418908.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418908.offset = 0f;
			m_AnimatorStateTransition418908.orderedInterruption = true;
			m_AnimatorStateTransition418908.isExit = true;
			m_AnimatorStateTransition418908.mute = false;
			m_AnimatorStateTransition418908.solo = false;
			m_AnimatorStateTransition418908.AddCondition(AnimatorConditionMode.NotEqual, 106f, "AbilityIndex");

			var m_AnimatorStateTransition418764 = m_DualPistolAnimatorState420004.AddExitTransition();
			m_AnimatorStateTransition418764.canTransitionToSelf = true;
			m_AnimatorStateTransition418764.duration = 0.1f;
			m_AnimatorStateTransition418764.exitTime = 0f;
			m_AnimatorStateTransition418764.hasExitTime = false;
			m_AnimatorStateTransition418764.hasFixedDuration = true;
			m_AnimatorStateTransition418764.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418764.offset = 0f;
			m_AnimatorStateTransition418764.orderedInterruption = true;
			m_AnimatorStateTransition418764.isExit = true;
			m_AnimatorStateTransition418764.mute = false;
			m_AnimatorStateTransition418764.solo = false;
			m_AnimatorStateTransition418764.AddCondition(AnimatorConditionMode.NotEqual, 106f, "AbilityIndex");

			// State Machine Defaults.
			m_LedgeStrafeAnimatorStateMachine420322.anyStatePosition = new Vector3(50f, 20f, 0f);
			m_LedgeStrafeAnimatorStateMachine420322.defaultState = m_SwordAnimatorState420066;
			m_LedgeStrafeAnimatorStateMachine420322.entryPosition = new Vector3(48f, -24f, 0f);
			m_LedgeStrafeAnimatorStateMachine420322.exitPosition = new Vector3(780f, 24f, 0f);
			m_LedgeStrafeAnimatorStateMachine420322.parentStateMachinePosition = new Vector3(756f, -48f, 0f);

			// State Machine Transitions.
			var m_AnimatorStateTransition418846 = baseStateMachine6.AddAnyStateTransition(m_KnifeAnimatorState420062);
			m_AnimatorStateTransition418846.canTransitionToSelf = false;
			m_AnimatorStateTransition418846.duration = 0.15f;
			m_AnimatorStateTransition418846.exitTime = 0.75f;
			m_AnimatorStateTransition418846.hasExitTime = false;
			m_AnimatorStateTransition418846.hasFixedDuration = true;
			m_AnimatorStateTransition418846.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418846.offset = 0f;
			m_AnimatorStateTransition418846.orderedInterruption = true;
			m_AnimatorStateTransition418846.isExit = false;
			m_AnimatorStateTransition418846.mute = false;
			m_AnimatorStateTransition418846.solo = false;
			m_AnimatorStateTransition418846.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			m_AnimatorStateTransition418846.AddCondition(AnimatorConditionMode.Equals, 23f, "Slot0ItemID");

			var m_AnimatorStateTransition418812 = baseStateMachine6.AddAnyStateTransition(m_SwordAnimatorState420066);
			m_AnimatorStateTransition418812.canTransitionToSelf = false;
			m_AnimatorStateTransition418812.duration = 0.15f;
			m_AnimatorStateTransition418812.exitTime = 0.75f;
			m_AnimatorStateTransition418812.hasExitTime = false;
			m_AnimatorStateTransition418812.hasFixedDuration = true;
			m_AnimatorStateTransition418812.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418812.offset = 0f;
			m_AnimatorStateTransition418812.orderedInterruption = true;
			m_AnimatorStateTransition418812.isExit = false;
			m_AnimatorStateTransition418812.mute = false;
			m_AnimatorStateTransition418812.solo = false;
			m_AnimatorStateTransition418812.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			m_AnimatorStateTransition418812.AddCondition(AnimatorConditionMode.Equals, 22f, "Slot0ItemID");

			var m_AnimatorStateTransition419276 = baseStateMachine6.AddAnyStateTransition(m_DualPistolAnimatorState420004);
			m_AnimatorStateTransition419276.canTransitionToSelf = false;
			m_AnimatorStateTransition419276.duration = 0.15f;
			m_AnimatorStateTransition419276.exitTime = 0.75f;
			m_AnimatorStateTransition419276.hasExitTime = false;
			m_AnimatorStateTransition419276.hasFixedDuration = true;
			m_AnimatorStateTransition419276.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419276.offset = 0f;
			m_AnimatorStateTransition419276.orderedInterruption = true;
			m_AnimatorStateTransition419276.isExit = false;
			m_AnimatorStateTransition419276.mute = false;
			m_AnimatorStateTransition419276.solo = false;
			m_AnimatorStateTransition419276.AddCondition(AnimatorConditionMode.Equals, 106f, "AbilityIndex");
			m_AnimatorStateTransition419276.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
		}
	}
}
