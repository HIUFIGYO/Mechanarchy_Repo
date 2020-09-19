/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

namespace Opsive.UltimateCharacterController.AddOns.Agility.Editor.Inspectors.Character.Abilities
{
	using Opsive.UltimateCharacterController.Editor.Inspectors;
	using Opsive.UltimateCharacterController.Editor.Inspectors.Character.Abilities;
	using Opsive.UltimateCharacterController.Editor.Utility;
	using UnityEditor;
	using UnityEditor.Animations;
	using UnityEngine;

	/// <summary>
	/// Draws a custom inspector for the Vault Ability.
	/// </summary>
	[InspectorDrawer(typeof(Vault))]
	public class VaultInspectorDrawer : DetectObjectAbilityBaseInspectorDrawer
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
					if (baseStateMachine0.stateMachines[j].stateMachine.name == "Vault") {
						baseStateMachine0.RemoveStateMachine(baseStateMachine0.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var m_VaultAnimationClip16538Path = AssetDatabase.GUIDToAssetPath("0399bfd67aded3d45b9a9478528c1759"); 
			var m_VaultAnimationClip16538 = AnimatorBuilder.GetAnimationClip(m_VaultAnimationClip16538Path, "Vault");
			var m_VaultWalkAnimationClip12114Path = AssetDatabase.GUIDToAssetPath("efb0ea01363a21e41adf6d34dd4ba46c"); 
			var m_VaultWalkAnimationClip12114 = AnimatorBuilder.GetAnimationClip(m_VaultWalkAnimationClip12114Path, "VaultWalk");
			var m_VaultRunAnimationClip18184Path = AssetDatabase.GUIDToAssetPath("258a82687d525724f8c461b7279ae336"); 
			var m_VaultRunAnimationClip18184 = AnimatorBuilder.GetAnimationClip(m_VaultRunAnimationClip18184Path, "VaultRun");

			// State Machine.
			var m_VaultAnimatorStateMachine420344 = baseStateMachine0.AddStateMachine("Vault", new Vector3(624f, 204f, 0f));

			// States.
			var m_VaultAnimatorState420306 = m_VaultAnimatorStateMachine420344.AddState("Vault", new Vector3(384f, 36f, 0f));
			var m_VaultAnimatorState420306m_BlendTreeBlendTree417786 = new BlendTree();
			AssetDatabase.AddObjectToAsset(m_VaultAnimatorState420306m_BlendTreeBlendTree417786, animatorController);
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786.hideFlags = HideFlags.HideInHierarchy;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786.blendParameter = "AbilityFloatData";
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786.blendParameterY = "HorizontalMovement";
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786.blendType = BlendTreeType.Simple1D;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786.maxThreshold = 8f;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786.minThreshold = 0f;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786.name = "Blend Tree";
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786.useAutomaticThresholds = false;
			var m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child0=  new ChildMotion();
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child0.motion = m_VaultAnimationClip16538;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child0.cycleOffset = 0f;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child0.directBlendParameter = "HorizontalMovement";
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child0.mirror = false;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child0.position = new Vector2(0f, 0f);
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child0.threshold = 0f;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child0.timeScale = 1.75f;
			var m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child1=  new ChildMotion();
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child1.motion = m_VaultWalkAnimationClip12114;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child1.cycleOffset = 0f;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child1.directBlendParameter = "HorizontalMovement";
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child1.mirror = false;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child1.position = new Vector2(0f, 0f);
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child1.threshold = 4f;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child1.timeScale = 1.75f;
			var m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child2=  new ChildMotion();
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child2.motion = m_VaultRunAnimationClip18184;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child2.cycleOffset = 0f;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child2.directBlendParameter = "HorizontalMovement";
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child2.mirror = false;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child2.position = new Vector2(0f, 0f);
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child2.threshold = 8f;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child2.timeScale = 1.75f;
			m_VaultAnimatorState420306m_BlendTreeBlendTree417786.children = new ChildMotion[] {
				m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child0,
				m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child1,
				m_VaultAnimatorState420306m_BlendTreeBlendTree417786Child2
			};
			m_VaultAnimatorState420306.motion = m_VaultAnimatorState420306m_BlendTreeBlendTree417786;
			m_VaultAnimatorState420306.cycleOffset = 0f;
			m_VaultAnimatorState420306.cycleOffsetParameterActive = false;
			m_VaultAnimatorState420306.iKOnFeet = true;
			m_VaultAnimatorState420306.mirror = false;
			m_VaultAnimatorState420306.mirrorParameterActive = false;
			m_VaultAnimatorState420306.speed = 1f;
			m_VaultAnimatorState420306.speedParameterActive = false;
			m_VaultAnimatorState420306.writeDefaultValues = true;

			// State Transitions.
			var m_AnimatorStateTransition419062 = m_VaultAnimatorState420306.AddExitTransition();
			m_AnimatorStateTransition419062.canTransitionToSelf = true;
			m_AnimatorStateTransition419062.duration = 0.15f;
			m_AnimatorStateTransition419062.exitTime = 0.99f;
			m_AnimatorStateTransition419062.hasExitTime = false;
			m_AnimatorStateTransition419062.hasFixedDuration = true;
			m_AnimatorStateTransition419062.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419062.offset = 0f;
			m_AnimatorStateTransition419062.orderedInterruption = true;
			m_AnimatorStateTransition419062.isExit = true;
			m_AnimatorStateTransition419062.mute = false;
			m_AnimatorStateTransition419062.solo = false;
			m_AnimatorStateTransition419062.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			// State Machine Defaults.
			m_VaultAnimatorStateMachine420344.anyStatePosition = new Vector3(50f, 20f, 0f);
			m_VaultAnimatorStateMachine420344.defaultState = m_VaultAnimatorState420306;
			m_VaultAnimatorStateMachine420344.entryPosition = new Vector3(50f, 120f, 0f);
			m_VaultAnimatorStateMachine420344.exitPosition = new Vector3(800f, 120f, 0f);
			m_VaultAnimatorStateMachine420344.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Machine Transitions.
			var m_AnimatorStateTransition418686 = baseStateMachine0.AddAnyStateTransition(m_VaultAnimatorState420306);
			m_AnimatorStateTransition418686.canTransitionToSelf = false;
			m_AnimatorStateTransition418686.duration = 0.1f;
			m_AnimatorStateTransition418686.exitTime = 0.75f;
			m_AnimatorStateTransition418686.hasExitTime = false;
			m_AnimatorStateTransition418686.hasFixedDuration = true;
			m_AnimatorStateTransition418686.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418686.offset = 0f;
			m_AnimatorStateTransition418686.orderedInterruption = true;
			m_AnimatorStateTransition418686.isExit = false;
			m_AnimatorStateTransition418686.mute = false;
			m_AnimatorStateTransition418686.solo = false;
			m_AnimatorStateTransition418686.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition418686.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");

			var baseStateMachine5 = animatorController.layers[5].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine5.stateMachines.Length; ++j) {
					if (baseStateMachine5.stateMachines[j].stateMachine.name == "Vault") {
						baseStateMachine5.RemoveStateMachine(baseStateMachine5.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var m_AssaultRifleVaultAnimationClip22584Path = AssetDatabase.GUIDToAssetPath("194b765e69b16a54c95f816909686574"); 
			var m_AssaultRifleVaultAnimationClip22584 = AnimatorBuilder.GetAnimationClip(m_AssaultRifleVaultAnimationClip22584Path, "AssaultRifleVault");
			var m_SniperRifleVaultAnimationClip15546Path = AssetDatabase.GUIDToAssetPath("5acbfc759a7379b438891af30302e377"); 
			var m_SniperRifleVaultAnimationClip15546 = AnimatorBuilder.GetAnimationClip(m_SniperRifleVaultAnimationClip15546Path, "SniperRifleVault");
			var m_PistolVaultAnimationClip21342Path = AssetDatabase.GUIDToAssetPath("6be7d0bcdc299f048902da3da3f6db84"); 
			var m_PistolVaultAnimationClip21342 = AnimatorBuilder.GetAnimationClip(m_PistolVaultAnimationClip21342Path, "PistolVault");
			var m_ShieldVaultAnimationClip15932Path = AssetDatabase.GUIDToAssetPath("1bccb806fb9e01f40ae2a500cdc3cc6e"); 
			var m_ShieldVaultAnimationClip15932 = AnimatorBuilder.GetAnimationClip(m_ShieldVaultAnimationClip15932Path, "ShieldVault");
			var m_RocketLauncherVaultAnimationClip13336Path = AssetDatabase.GUIDToAssetPath("b1e8de7271784f84dbb18ac8391720d7"); 
			var m_RocketLauncherVaultAnimationClip13336 = AnimatorBuilder.GetAnimationClip(m_RocketLauncherVaultAnimationClip13336Path, "RocketLauncherVault");
			var m_DualPistolVaultAnimationClip18912Path = AssetDatabase.GUIDToAssetPath("f991d0293f754c442ad09f19059391c1"); 
			var m_DualPistolVaultAnimationClip18912 = AnimatorBuilder.GetAnimationClip(m_DualPistolVaultAnimationClip18912Path, "DualPistolVault");
			var m_ShotgunVaultAnimationClip23038Path = AssetDatabase.GUIDToAssetPath("6b5a0abe350de1f46a9931f384ae8667"); 
			var m_ShotgunVaultAnimationClip23038 = AnimatorBuilder.GetAnimationClip(m_ShotgunVaultAnimationClip23038Path, "ShotgunVault");
			var m_BowVaultAnimationClip19700Path = AssetDatabase.GUIDToAssetPath("5a127a4aefca9f04797502ef9a805037"); 
			var m_BowVaultAnimationClip19700 = AnimatorBuilder.GetAnimationClip(m_BowVaultAnimationClip19700Path, "BowVault");

			// State Machine.
			var m_VaultAnimatorStateMachine420354 = baseStateMachine5.AddStateMachine("Vault", new Vector3(852f, 156f, 0f));

			// States.
			var m_AssaultRifleAnimatorState420242 = m_VaultAnimatorStateMachine420354.AddState("Assault Rifle", new Vector3(384f, -48f, 0f));
			m_AssaultRifleAnimatorState420242.motion = m_AssaultRifleVaultAnimationClip22584;
			m_AssaultRifleAnimatorState420242.cycleOffset = 0f;
			m_AssaultRifleAnimatorState420242.cycleOffsetParameterActive = false;
			m_AssaultRifleAnimatorState420242.iKOnFeet = false;
			m_AssaultRifleAnimatorState420242.mirror = false;
			m_AssaultRifleAnimatorState420242.mirrorParameterActive = false;
			m_AssaultRifleAnimatorState420242.speed = 1.75f;
			m_AssaultRifleAnimatorState420242.speedParameterActive = false;
			m_AssaultRifleAnimatorState420242.writeDefaultValues = true;

			var m_SniperRifleAnimatorState420184 = m_VaultAnimatorStateMachine420354.AddState("Sniper Rifle", new Vector3(384f, 372f, 0f));
			m_SniperRifleAnimatorState420184.motion = m_SniperRifleVaultAnimationClip15546;
			m_SniperRifleAnimatorState420184.cycleOffset = 0f;
			m_SniperRifleAnimatorState420184.cycleOffsetParameterActive = false;
			m_SniperRifleAnimatorState420184.iKOnFeet = false;
			m_SniperRifleAnimatorState420184.mirror = false;
			m_SniperRifleAnimatorState420184.mirrorParameterActive = false;
			m_SniperRifleAnimatorState420184.speed = 1.75f;
			m_SniperRifleAnimatorState420184.speedParameterActive = false;
			m_SniperRifleAnimatorState420184.writeDefaultValues = true;

			var m_PistolAnimatorState420026 = m_VaultAnimatorStateMachine420354.AddState("Pistol", new Vector3(384f, 132f, 0f));
			m_PistolAnimatorState420026.motion = m_PistolVaultAnimationClip21342;
			m_PistolAnimatorState420026.cycleOffset = 0f;
			m_PistolAnimatorState420026.cycleOffsetParameterActive = false;
			m_PistolAnimatorState420026.iKOnFeet = false;
			m_PistolAnimatorState420026.mirror = false;
			m_PistolAnimatorState420026.mirrorParameterActive = false;
			m_PistolAnimatorState420026.speed = 1.75f;
			m_PistolAnimatorState420026.speedParameterActive = false;
			m_PistolAnimatorState420026.writeDefaultValues = true;

			var m_ShieldAnimatorState420082 = m_VaultAnimatorStateMachine420354.AddState("Shield", new Vector3(384f, 252f, 0f));
			m_ShieldAnimatorState420082.motion = m_ShieldVaultAnimationClip15932;
			m_ShieldAnimatorState420082.cycleOffset = 0f;
			m_ShieldAnimatorState420082.cycleOffsetParameterActive = false;
			m_ShieldAnimatorState420082.iKOnFeet = false;
			m_ShieldAnimatorState420082.mirror = false;
			m_ShieldAnimatorState420082.mirrorParameterActive = false;
			m_ShieldAnimatorState420082.speed = 1.75f;
			m_ShieldAnimatorState420082.speedParameterActive = false;
			m_ShieldAnimatorState420082.writeDefaultValues = true;

			var m_RocketLauncherAnimatorState420086 = m_VaultAnimatorStateMachine420354.AddState("Rocket Launcher", new Vector3(384f, 192f, 0f));
			m_RocketLauncherAnimatorState420086.motion = m_RocketLauncherVaultAnimationClip13336;
			m_RocketLauncherAnimatorState420086.cycleOffset = 0f;
			m_RocketLauncherAnimatorState420086.cycleOffsetParameterActive = false;
			m_RocketLauncherAnimatorState420086.iKOnFeet = false;
			m_RocketLauncherAnimatorState420086.mirror = false;
			m_RocketLauncherAnimatorState420086.mirrorParameterActive = false;
			m_RocketLauncherAnimatorState420086.speed = 1.75f;
			m_RocketLauncherAnimatorState420086.speedParameterActive = false;
			m_RocketLauncherAnimatorState420086.writeDefaultValues = true;

			var m_DualPistolAnimatorState420094 = m_VaultAnimatorStateMachine420354.AddState("Dual Pistol", new Vector3(384f, 72f, 0f));
			m_DualPistolAnimatorState420094.motion = m_DualPistolVaultAnimationClip18912;
			m_DualPistolAnimatorState420094.cycleOffset = 0f;
			m_DualPistolAnimatorState420094.cycleOffsetParameterActive = false;
			m_DualPistolAnimatorState420094.iKOnFeet = false;
			m_DualPistolAnimatorState420094.mirror = false;
			m_DualPistolAnimatorState420094.mirrorParameterActive = false;
			m_DualPistolAnimatorState420094.speed = 1.75f;
			m_DualPistolAnimatorState420094.speedParameterActive = false;
			m_DualPistolAnimatorState420094.writeDefaultValues = true;

			var m_ShotgunAnimatorState420294 = m_VaultAnimatorStateMachine420354.AddState("Shotgun", new Vector3(384f, 312f, 0f));
			m_ShotgunAnimatorState420294.motion = m_ShotgunVaultAnimationClip23038;
			m_ShotgunAnimatorState420294.cycleOffset = 0f;
			m_ShotgunAnimatorState420294.cycleOffsetParameterActive = false;
			m_ShotgunAnimatorState420294.iKOnFeet = false;
			m_ShotgunAnimatorState420294.mirror = false;
			m_ShotgunAnimatorState420294.mirrorParameterActive = false;
			m_ShotgunAnimatorState420294.speed = 1.75f;
			m_ShotgunAnimatorState420294.speedParameterActive = false;
			m_ShotgunAnimatorState420294.writeDefaultValues = true;

			var m_BowAnimatorState420022 = m_VaultAnimatorStateMachine420354.AddState("Bow", new Vector3(384f, 12f, 0f));
			m_BowAnimatorState420022.motion = m_BowVaultAnimationClip19700;
			m_BowAnimatorState420022.cycleOffset = 0f;
			m_BowAnimatorState420022.cycleOffsetParameterActive = false;
			m_BowAnimatorState420022.iKOnFeet = false;
			m_BowAnimatorState420022.mirror = false;
			m_BowAnimatorState420022.mirrorParameterActive = false;
			m_BowAnimatorState420022.speed = 1.75f;
			m_BowAnimatorState420022.speedParameterActive = false;
			m_BowAnimatorState420022.writeDefaultValues = true;

			// State Transitions.
			var m_AnimatorStateTransition419296 = m_AssaultRifleAnimatorState420242.AddExitTransition();
			m_AnimatorStateTransition419296.canTransitionToSelf = true;
			m_AnimatorStateTransition419296.duration = 0.15f;
			m_AnimatorStateTransition419296.exitTime = 0f;
			m_AnimatorStateTransition419296.hasExitTime = false;
			m_AnimatorStateTransition419296.hasFixedDuration = true;
			m_AnimatorStateTransition419296.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419296.offset = 0f;
			m_AnimatorStateTransition419296.orderedInterruption = true;
			m_AnimatorStateTransition419296.isExit = true;
			m_AnimatorStateTransition419296.mute = false;
			m_AnimatorStateTransition419296.solo = false;
			m_AnimatorStateTransition419296.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition419204 = m_SniperRifleAnimatorState420184.AddExitTransition();
			m_AnimatorStateTransition419204.canTransitionToSelf = true;
			m_AnimatorStateTransition419204.duration = 0.15f;
			m_AnimatorStateTransition419204.exitTime = 0f;
			m_AnimatorStateTransition419204.hasExitTime = false;
			m_AnimatorStateTransition419204.hasFixedDuration = true;
			m_AnimatorStateTransition419204.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419204.offset = 0f;
			m_AnimatorStateTransition419204.orderedInterruption = true;
			m_AnimatorStateTransition419204.isExit = true;
			m_AnimatorStateTransition419204.mute = false;
			m_AnimatorStateTransition419204.solo = false;
			m_AnimatorStateTransition419204.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition418688 = m_PistolAnimatorState420026.AddExitTransition();
			m_AnimatorStateTransition418688.canTransitionToSelf = true;
			m_AnimatorStateTransition418688.duration = 0.15f;
			m_AnimatorStateTransition418688.exitTime = 0f;
			m_AnimatorStateTransition418688.hasExitTime = false;
			m_AnimatorStateTransition418688.hasFixedDuration = true;
			m_AnimatorStateTransition418688.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418688.offset = 0f;
			m_AnimatorStateTransition418688.orderedInterruption = true;
			m_AnimatorStateTransition418688.isExit = true;
			m_AnimatorStateTransition418688.mute = false;
			m_AnimatorStateTransition418688.solo = false;
			m_AnimatorStateTransition418688.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition419710 = m_ShieldAnimatorState420082.AddExitTransition();
			m_AnimatorStateTransition419710.canTransitionToSelf = true;
			m_AnimatorStateTransition419710.duration = 0.15f;
			m_AnimatorStateTransition419710.exitTime = 0f;
			m_AnimatorStateTransition419710.hasExitTime = false;
			m_AnimatorStateTransition419710.hasFixedDuration = true;
			m_AnimatorStateTransition419710.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419710.offset = 0f;
			m_AnimatorStateTransition419710.orderedInterruption = true;
			m_AnimatorStateTransition419710.isExit = true;
			m_AnimatorStateTransition419710.mute = false;
			m_AnimatorStateTransition419710.solo = false;
			m_AnimatorStateTransition419710.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition418590 = m_RocketLauncherAnimatorState420086.AddExitTransition();
			m_AnimatorStateTransition418590.canTransitionToSelf = true;
			m_AnimatorStateTransition418590.duration = 0.15f;
			m_AnimatorStateTransition418590.exitTime = 0f;
			m_AnimatorStateTransition418590.hasExitTime = false;
			m_AnimatorStateTransition418590.hasFixedDuration = true;
			m_AnimatorStateTransition418590.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418590.offset = 0f;
			m_AnimatorStateTransition418590.orderedInterruption = true;
			m_AnimatorStateTransition418590.isExit = true;
			m_AnimatorStateTransition418590.mute = false;
			m_AnimatorStateTransition418590.solo = false;
			m_AnimatorStateTransition418590.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition419568 = m_DualPistolAnimatorState420094.AddExitTransition();
			m_AnimatorStateTransition419568.canTransitionToSelf = true;
			m_AnimatorStateTransition419568.duration = 0.15f;
			m_AnimatorStateTransition419568.exitTime = 0f;
			m_AnimatorStateTransition419568.hasExitTime = false;
			m_AnimatorStateTransition419568.hasFixedDuration = true;
			m_AnimatorStateTransition419568.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419568.offset = 0f;
			m_AnimatorStateTransition419568.orderedInterruption = true;
			m_AnimatorStateTransition419568.isExit = true;
			m_AnimatorStateTransition419568.mute = false;
			m_AnimatorStateTransition419568.solo = false;
			m_AnimatorStateTransition419568.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition418872 = m_ShotgunAnimatorState420294.AddExitTransition();
			m_AnimatorStateTransition418872.canTransitionToSelf = true;
			m_AnimatorStateTransition418872.duration = 0.15f;
			m_AnimatorStateTransition418872.exitTime = 0f;
			m_AnimatorStateTransition418872.hasExitTime = false;
			m_AnimatorStateTransition418872.hasFixedDuration = true;
			m_AnimatorStateTransition418872.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418872.offset = 0f;
			m_AnimatorStateTransition418872.orderedInterruption = true;
			m_AnimatorStateTransition418872.isExit = true;
			m_AnimatorStateTransition418872.mute = false;
			m_AnimatorStateTransition418872.solo = false;
			m_AnimatorStateTransition418872.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition419326 = m_BowAnimatorState420022.AddExitTransition();
			m_AnimatorStateTransition419326.canTransitionToSelf = true;
			m_AnimatorStateTransition419326.duration = 0.15f;
			m_AnimatorStateTransition419326.exitTime = 0f;
			m_AnimatorStateTransition419326.hasExitTime = false;
			m_AnimatorStateTransition419326.hasFixedDuration = true;
			m_AnimatorStateTransition419326.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419326.offset = 0f;
			m_AnimatorStateTransition419326.orderedInterruption = true;
			m_AnimatorStateTransition419326.isExit = true;
			m_AnimatorStateTransition419326.mute = false;
			m_AnimatorStateTransition419326.solo = false;
			m_AnimatorStateTransition419326.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			// State Machine Defaults.
			m_VaultAnimatorStateMachine420354.anyStatePosition = new Vector3(48f, 144f, 0f);
			m_VaultAnimatorStateMachine420354.defaultState = m_AssaultRifleAnimatorState420242;
			m_VaultAnimatorStateMachine420354.entryPosition = new Vector3(48f, 96f, 0f);
			m_VaultAnimatorStateMachine420354.exitPosition = new Vector3(780f, 156f, 0f);
			m_VaultAnimatorStateMachine420354.parentStateMachinePosition = new Vector3(756f, 72f, 0f);

			// State Machine Transitions.
			var m_AnimatorStateTransition418672 = baseStateMachine5.AddAnyStateTransition(m_ShieldAnimatorState420082);
			m_AnimatorStateTransition418672.canTransitionToSelf = false;
			m_AnimatorStateTransition418672.duration = 0.1f;
			m_AnimatorStateTransition418672.exitTime = 0.75f;
			m_AnimatorStateTransition418672.hasExitTime = false;
			m_AnimatorStateTransition418672.hasFixedDuration = true;
			m_AnimatorStateTransition418672.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418672.offset = 0f;
			m_AnimatorStateTransition418672.orderedInterruption = true;
			m_AnimatorStateTransition418672.isExit = false;
			m_AnimatorStateTransition418672.mute = false;
			m_AnimatorStateTransition418672.solo = false;
			m_AnimatorStateTransition418672.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition418672.AddCondition(AnimatorConditionMode.Equals, 25f, "Slot1ItemID");

			var m_AnimatorStateTransition419318 = baseStateMachine5.AddAnyStateTransition(m_DualPistolAnimatorState420094);
			m_AnimatorStateTransition419318.canTransitionToSelf = false;
			m_AnimatorStateTransition419318.duration = 0.1f;
			m_AnimatorStateTransition419318.exitTime = 0.75f;
			m_AnimatorStateTransition419318.hasExitTime = false;
			m_AnimatorStateTransition419318.hasFixedDuration = true;
			m_AnimatorStateTransition419318.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419318.offset = 0f;
			m_AnimatorStateTransition419318.orderedInterruption = true;
			m_AnimatorStateTransition419318.isExit = false;
			m_AnimatorStateTransition419318.mute = false;
			m_AnimatorStateTransition419318.solo = false;
			m_AnimatorStateTransition419318.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition419318.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			m_AnimatorStateTransition419318.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot1ItemID");

			var m_AnimatorStateTransition418600 = baseStateMachine5.AddAnyStateTransition(m_PistolAnimatorState420026);
			m_AnimatorStateTransition418600.canTransitionToSelf = false;
			m_AnimatorStateTransition418600.duration = 0.1f;
			m_AnimatorStateTransition418600.exitTime = 0.75f;
			m_AnimatorStateTransition418600.hasExitTime = false;
			m_AnimatorStateTransition418600.hasFixedDuration = true;
			m_AnimatorStateTransition418600.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418600.offset = 0f;
			m_AnimatorStateTransition418600.orderedInterruption = true;
			m_AnimatorStateTransition418600.isExit = false;
			m_AnimatorStateTransition418600.mute = false;
			m_AnimatorStateTransition418600.solo = false;
			m_AnimatorStateTransition418600.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition418600.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			m_AnimatorStateTransition418600.AddCondition(AnimatorConditionMode.NotEqual, 2f, "Slot1ItemID");

			var m_AnimatorStateTransition418652 = baseStateMachine5.AddAnyStateTransition(m_AssaultRifleAnimatorState420242);
			m_AnimatorStateTransition418652.canTransitionToSelf = false;
			m_AnimatorStateTransition418652.duration = 0.1f;
			m_AnimatorStateTransition418652.exitTime = 0.75f;
			m_AnimatorStateTransition418652.hasExitTime = false;
			m_AnimatorStateTransition418652.hasFixedDuration = true;
			m_AnimatorStateTransition418652.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418652.offset = 0f;
			m_AnimatorStateTransition418652.orderedInterruption = true;
			m_AnimatorStateTransition418652.isExit = false;
			m_AnimatorStateTransition418652.mute = false;
			m_AnimatorStateTransition418652.solo = false;
			m_AnimatorStateTransition418652.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition418652.AddCondition(AnimatorConditionMode.Equals, 1f, "Slot0ItemID");

			var m_AnimatorStateTransition419640 = baseStateMachine5.AddAnyStateTransition(m_BowAnimatorState420022);
			m_AnimatorStateTransition419640.canTransitionToSelf = false;
			m_AnimatorStateTransition419640.duration = 0.1f;
			m_AnimatorStateTransition419640.exitTime = 0.75f;
			m_AnimatorStateTransition419640.hasExitTime = false;
			m_AnimatorStateTransition419640.hasFixedDuration = true;
			m_AnimatorStateTransition419640.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419640.offset = 0f;
			m_AnimatorStateTransition419640.orderedInterruption = true;
			m_AnimatorStateTransition419640.isExit = false;
			m_AnimatorStateTransition419640.mute = false;
			m_AnimatorStateTransition419640.solo = false;
			m_AnimatorStateTransition419640.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition419640.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot1ItemID");

			var m_AnimatorStateTransition418580 = baseStateMachine5.AddAnyStateTransition(m_SniperRifleAnimatorState420184);
			m_AnimatorStateTransition418580.canTransitionToSelf = false;
			m_AnimatorStateTransition418580.duration = 0.1f;
			m_AnimatorStateTransition418580.exitTime = 0.75f;
			m_AnimatorStateTransition418580.hasExitTime = false;
			m_AnimatorStateTransition418580.hasFixedDuration = true;
			m_AnimatorStateTransition418580.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418580.offset = 0f;
			m_AnimatorStateTransition418580.orderedInterruption = true;
			m_AnimatorStateTransition418580.isExit = false;
			m_AnimatorStateTransition418580.mute = false;
			m_AnimatorStateTransition418580.solo = false;
			m_AnimatorStateTransition418580.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition418580.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemID");

			var m_AnimatorStateTransition419668 = baseStateMachine5.AddAnyStateTransition(m_ShotgunAnimatorState420294);
			m_AnimatorStateTransition419668.canTransitionToSelf = false;
			m_AnimatorStateTransition419668.duration = 0.1f;
			m_AnimatorStateTransition419668.exitTime = 0.75f;
			m_AnimatorStateTransition419668.hasExitTime = false;
			m_AnimatorStateTransition419668.hasFixedDuration = true;
			m_AnimatorStateTransition419668.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419668.offset = 0f;
			m_AnimatorStateTransition419668.orderedInterruption = true;
			m_AnimatorStateTransition419668.isExit = false;
			m_AnimatorStateTransition419668.mute = false;
			m_AnimatorStateTransition419668.solo = false;
			m_AnimatorStateTransition419668.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition419668.AddCondition(AnimatorConditionMode.Equals, 3f, "Slot0ItemID");

			var m_AnimatorStateTransition419746 = baseStateMachine5.AddAnyStateTransition(m_RocketLauncherAnimatorState420086);
			m_AnimatorStateTransition419746.canTransitionToSelf = false;
			m_AnimatorStateTransition419746.duration = 0.1f;
			m_AnimatorStateTransition419746.exitTime = 0.75f;
			m_AnimatorStateTransition419746.hasExitTime = false;
			m_AnimatorStateTransition419746.hasFixedDuration = true;
			m_AnimatorStateTransition419746.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419746.offset = 0f;
			m_AnimatorStateTransition419746.orderedInterruption = true;
			m_AnimatorStateTransition419746.isExit = false;
			m_AnimatorStateTransition419746.mute = false;
			m_AnimatorStateTransition419746.solo = false;
			m_AnimatorStateTransition419746.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition419746.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemID");

			var baseStateMachine6 = animatorController.layers[6].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine6.stateMachines.Length; ++j) {
					if (baseStateMachine6.stateMachines[j].stateMachine.name == "Vault") {
						baseStateMachine6.RemoveStateMachine(baseStateMachine6.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var m_SwordVaultAnimationClip22502Path = AssetDatabase.GUIDToAssetPath("120b0f3e59a781a44b765e2205535382"); 
			var m_SwordVaultAnimationClip22502 = AnimatorBuilder.GetAnimationClip(m_SwordVaultAnimationClip22502Path, "SwordVault");
			var m_KatanaVaultAnimationClip15098Path = AssetDatabase.GUIDToAssetPath("f64e92e464549d343ac586eb3ca9f381"); 
			var m_KatanaVaultAnimationClip15098 = AnimatorBuilder.GetAnimationClip(m_KatanaVaultAnimationClip15098Path, "KatanaVault");
			var m_KnifeVaultAnimationClip13598Path = AssetDatabase.GUIDToAssetPath("2c917cc202a5edc4e8dda8662217d2d5"); 
			var m_KnifeVaultAnimationClip13598 = AnimatorBuilder.GetAnimationClip(m_KnifeVaultAnimationClip13598Path, "KnifeVault");
			var m_FragGrenadeVaultAnimationClip15884Path = AssetDatabase.GUIDToAssetPath("ed618ef5a99858840b36d7837d93418a"); 
			var m_FragGrenadeVaultAnimationClip15884 = AnimatorBuilder.GetAnimationClip(m_FragGrenadeVaultAnimationClip15884Path, "FragGrenadeVault");

			// State Machine.
			var m_VaultAnimatorStateMachine420328 = baseStateMachine6.AddStateMachine("Vault", new Vector3(852f, 108f, 0f));

			// States.
			var m_SwordAnimatorState420212 = m_VaultAnimatorStateMachine420328.AddState("Sword", new Vector3(384f, 372f, 0f));
			m_SwordAnimatorState420212.motion = m_SwordVaultAnimationClip22502;
			m_SwordAnimatorState420212.cycleOffset = 0f;
			m_SwordAnimatorState420212.cycleOffsetParameterActive = false;
			m_SwordAnimatorState420212.iKOnFeet = false;
			m_SwordAnimatorState420212.mirror = false;
			m_SwordAnimatorState420212.mirrorParameterActive = false;
			m_SwordAnimatorState420212.speed = 1.75f;
			m_SwordAnimatorState420212.speedParameterActive = false;
			m_SwordAnimatorState420212.writeDefaultValues = true;

			var m_ShotgunAnimatorState420078 = m_VaultAnimatorStateMachine420328.AddState("Shotgun", new Vector3(384f, 252f, 0f));
			m_ShotgunAnimatorState420078.motion = m_ShotgunVaultAnimationClip23038;
			m_ShotgunAnimatorState420078.cycleOffset = 0f;
			m_ShotgunAnimatorState420078.cycleOffsetParameterActive = false;
			m_ShotgunAnimatorState420078.iKOnFeet = false;
			m_ShotgunAnimatorState420078.mirror = false;
			m_ShotgunAnimatorState420078.mirrorParameterActive = false;
			m_ShotgunAnimatorState420078.speed = 1.75f;
			m_ShotgunAnimatorState420078.speedParameterActive = false;
			m_ShotgunAnimatorState420078.writeDefaultValues = true;

			var m_PistolAnimatorState420044 = m_VaultAnimatorStateMachine420328.AddState("Pistol", new Vector3(384f, 132f, 0f));
			m_PistolAnimatorState420044.motion = m_PistolVaultAnimationClip21342;
			m_PistolAnimatorState420044.cycleOffset = 0f;
			m_PistolAnimatorState420044.cycleOffsetParameterActive = false;
			m_PistolAnimatorState420044.iKOnFeet = false;
			m_PistolAnimatorState420044.mirror = false;
			m_PistolAnimatorState420044.mirrorParameterActive = false;
			m_PistolAnimatorState420044.speed = 1.75f;
			m_PistolAnimatorState420044.speedParameterActive = false;
			m_PistolAnimatorState420044.writeDefaultValues = true;

			var m_SniperRifleAnimatorState420102 = m_VaultAnimatorStateMachine420328.AddState("Sniper Rifle", new Vector3(384f, 312f, 0f));
			m_SniperRifleAnimatorState420102.motion = m_SniperRifleVaultAnimationClip15546;
			m_SniperRifleAnimatorState420102.cycleOffset = 0f;
			m_SniperRifleAnimatorState420102.cycleOffsetParameterActive = false;
			m_SniperRifleAnimatorState420102.iKOnFeet = false;
			m_SniperRifleAnimatorState420102.mirror = false;
			m_SniperRifleAnimatorState420102.mirrorParameterActive = false;
			m_SniperRifleAnimatorState420102.speed = 1.75f;
			m_SniperRifleAnimatorState420102.speedParameterActive = false;
			m_SniperRifleAnimatorState420102.writeDefaultValues = true;

			var m_DualPistolAnimatorState420258 = m_VaultAnimatorStateMachine420328.AddState("Dual Pistol", new Vector3(384f, -108f, 0f));
			m_DualPistolAnimatorState420258.motion = m_DualPistolVaultAnimationClip18912;
			m_DualPistolAnimatorState420258.cycleOffset = 0f;
			m_DualPistolAnimatorState420258.cycleOffsetParameterActive = false;
			m_DualPistolAnimatorState420258.iKOnFeet = false;
			m_DualPistolAnimatorState420258.mirror = false;
			m_DualPistolAnimatorState420258.mirrorParameterActive = false;
			m_DualPistolAnimatorState420258.speed = 1.75f;
			m_DualPistolAnimatorState420258.speedParameterActive = false;
			m_DualPistolAnimatorState420258.writeDefaultValues = true;

			var m_AssaultRifleAnimatorState420132 = m_VaultAnimatorStateMachine420328.AddState("Assault Rifle", new Vector3(384f, -228f, 0f));
			m_AssaultRifleAnimatorState420132.motion = m_AssaultRifleVaultAnimationClip22584;
			m_AssaultRifleAnimatorState420132.cycleOffset = 0f;
			m_AssaultRifleAnimatorState420132.cycleOffsetParameterActive = false;
			m_AssaultRifleAnimatorState420132.iKOnFeet = false;
			m_AssaultRifleAnimatorState420132.mirror = false;
			m_AssaultRifleAnimatorState420132.mirrorParameterActive = false;
			m_AssaultRifleAnimatorState420132.speed = 1.75f;
			m_AssaultRifleAnimatorState420132.speedParameterActive = false;
			m_AssaultRifleAnimatorState420132.writeDefaultValues = true;

			var m_RocketLauncherAnimatorState420244 = m_VaultAnimatorStateMachine420328.AddState("Rocket Launcher", new Vector3(384f, 192f, 0f));
			m_RocketLauncherAnimatorState420244.motion = m_RocketLauncherVaultAnimationClip13336;
			m_RocketLauncherAnimatorState420244.cycleOffset = 0f;
			m_RocketLauncherAnimatorState420244.cycleOffsetParameterActive = false;
			m_RocketLauncherAnimatorState420244.iKOnFeet = false;
			m_RocketLauncherAnimatorState420244.mirror = false;
			m_RocketLauncherAnimatorState420244.mirrorParameterActive = false;
			m_RocketLauncherAnimatorState420244.speed = 1.75f;
			m_RocketLauncherAnimatorState420244.speedParameterActive = false;
			m_RocketLauncherAnimatorState420244.writeDefaultValues = true;

			var m_KatanaAnimatorState420266 = m_VaultAnimatorStateMachine420328.AddState("Katana", new Vector3(384f, 12f, 0f));
			m_KatanaAnimatorState420266.motion = m_KatanaVaultAnimationClip15098;
			m_KatanaAnimatorState420266.cycleOffset = 0f;
			m_KatanaAnimatorState420266.cycleOffsetParameterActive = false;
			m_KatanaAnimatorState420266.iKOnFeet = false;
			m_KatanaAnimatorState420266.mirror = false;
			m_KatanaAnimatorState420266.mirrorParameterActive = false;
			m_KatanaAnimatorState420266.speed = 1.75f;
			m_KatanaAnimatorState420266.speedParameterActive = false;
			m_KatanaAnimatorState420266.writeDefaultValues = true;

			var m_BowAnimatorState420170 = m_VaultAnimatorStateMachine420328.AddState("Bow", new Vector3(384f, -168f, 0f));
			m_BowAnimatorState420170.motion = m_BowVaultAnimationClip19700;
			m_BowAnimatorState420170.cycleOffset = 0f;
			m_BowAnimatorState420170.cycleOffsetParameterActive = false;
			m_BowAnimatorState420170.iKOnFeet = false;
			m_BowAnimatorState420170.mirror = false;
			m_BowAnimatorState420170.mirrorParameterActive = false;
			m_BowAnimatorState420170.speed = 1.75f;
			m_BowAnimatorState420170.speedParameterActive = false;
			m_BowAnimatorState420170.writeDefaultValues = true;

			var m_KnifeAnimatorState420218 = m_VaultAnimatorStateMachine420328.AddState("Knife", new Vector3(384f, 72f, 0f));
			m_KnifeAnimatorState420218.motion = m_KnifeVaultAnimationClip13598;
			m_KnifeAnimatorState420218.cycleOffset = 0f;
			m_KnifeAnimatorState420218.cycleOffsetParameterActive = false;
			m_KnifeAnimatorState420218.iKOnFeet = false;
			m_KnifeAnimatorState420218.mirror = false;
			m_KnifeAnimatorState420218.mirrorParameterActive = false;
			m_KnifeAnimatorState420218.speed = 1.75f;
			m_KnifeAnimatorState420218.speedParameterActive = false;
			m_KnifeAnimatorState420218.writeDefaultValues = true;

			var m_FragGrenadeAnimatorState420180 = m_VaultAnimatorStateMachine420328.AddState("Frag Grenade", new Vector3(384f, -48f, 0f));
			m_FragGrenadeAnimatorState420180.motion = m_FragGrenadeVaultAnimationClip15884;
			m_FragGrenadeAnimatorState420180.cycleOffset = 0f;
			m_FragGrenadeAnimatorState420180.cycleOffsetParameterActive = false;
			m_FragGrenadeAnimatorState420180.iKOnFeet = false;
			m_FragGrenadeAnimatorState420180.mirror = false;
			m_FragGrenadeAnimatorState420180.mirrorParameterActive = false;
			m_FragGrenadeAnimatorState420180.speed = 1.75f;
			m_FragGrenadeAnimatorState420180.speedParameterActive = false;
			m_FragGrenadeAnimatorState420180.writeDefaultValues = true;

			// State Transitions.
			var m_AnimatorStateTransition418696 = m_SwordAnimatorState420212.AddExitTransition();
			m_AnimatorStateTransition418696.canTransitionToSelf = true;
			m_AnimatorStateTransition418696.duration = 0.15f;
			m_AnimatorStateTransition418696.exitTime = 0f;
			m_AnimatorStateTransition418696.hasExitTime = false;
			m_AnimatorStateTransition418696.hasFixedDuration = true;
			m_AnimatorStateTransition418696.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418696.offset = 0f;
			m_AnimatorStateTransition418696.orderedInterruption = true;
			m_AnimatorStateTransition418696.isExit = true;
			m_AnimatorStateTransition418696.mute = false;
			m_AnimatorStateTransition418696.solo = false;
			m_AnimatorStateTransition418696.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition418660 = m_ShotgunAnimatorState420078.AddExitTransition();
			m_AnimatorStateTransition418660.canTransitionToSelf = true;
			m_AnimatorStateTransition418660.duration = 0.15f;
			m_AnimatorStateTransition418660.exitTime = 0f;
			m_AnimatorStateTransition418660.hasExitTime = false;
			m_AnimatorStateTransition418660.hasFixedDuration = true;
			m_AnimatorStateTransition418660.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418660.offset = 0f;
			m_AnimatorStateTransition418660.orderedInterruption = true;
			m_AnimatorStateTransition418660.isExit = true;
			m_AnimatorStateTransition418660.mute = false;
			m_AnimatorStateTransition418660.solo = false;
			m_AnimatorStateTransition418660.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition418632 = m_PistolAnimatorState420044.AddExitTransition();
			m_AnimatorStateTransition418632.canTransitionToSelf = true;
			m_AnimatorStateTransition418632.duration = 0.15f;
			m_AnimatorStateTransition418632.exitTime = 0f;
			m_AnimatorStateTransition418632.hasExitTime = false;
			m_AnimatorStateTransition418632.hasFixedDuration = true;
			m_AnimatorStateTransition418632.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418632.offset = 0f;
			m_AnimatorStateTransition418632.orderedInterruption = true;
			m_AnimatorStateTransition418632.isExit = true;
			m_AnimatorStateTransition418632.mute = false;
			m_AnimatorStateTransition418632.solo = false;
			m_AnimatorStateTransition418632.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition418922 = m_SniperRifleAnimatorState420102.AddExitTransition();
			m_AnimatorStateTransition418922.canTransitionToSelf = true;
			m_AnimatorStateTransition418922.duration = 0.15f;
			m_AnimatorStateTransition418922.exitTime = 0f;
			m_AnimatorStateTransition418922.hasExitTime = false;
			m_AnimatorStateTransition418922.hasFixedDuration = true;
			m_AnimatorStateTransition418922.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418922.offset = 0f;
			m_AnimatorStateTransition418922.orderedInterruption = true;
			m_AnimatorStateTransition418922.isExit = true;
			m_AnimatorStateTransition418922.mute = false;
			m_AnimatorStateTransition418922.solo = false;
			m_AnimatorStateTransition418922.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition419892 = m_DualPistolAnimatorState420258.AddExitTransition();
			m_AnimatorStateTransition419892.canTransitionToSelf = true;
			m_AnimatorStateTransition419892.duration = 0.15f;
			m_AnimatorStateTransition419892.exitTime = 0f;
			m_AnimatorStateTransition419892.hasExitTime = false;
			m_AnimatorStateTransition419892.hasFixedDuration = true;
			m_AnimatorStateTransition419892.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419892.offset = 0f;
			m_AnimatorStateTransition419892.orderedInterruption = true;
			m_AnimatorStateTransition419892.isExit = true;
			m_AnimatorStateTransition419892.mute = false;
			m_AnimatorStateTransition419892.solo = false;
			m_AnimatorStateTransition419892.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition418868 = m_AssaultRifleAnimatorState420132.AddExitTransition();
			m_AnimatorStateTransition418868.canTransitionToSelf = true;
			m_AnimatorStateTransition418868.duration = 0.15f;
			m_AnimatorStateTransition418868.exitTime = 0f;
			m_AnimatorStateTransition418868.hasExitTime = false;
			m_AnimatorStateTransition418868.hasFixedDuration = true;
			m_AnimatorStateTransition418868.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418868.offset = 0f;
			m_AnimatorStateTransition418868.orderedInterruption = true;
			m_AnimatorStateTransition418868.isExit = true;
			m_AnimatorStateTransition418868.mute = false;
			m_AnimatorStateTransition418868.solo = false;
			m_AnimatorStateTransition418868.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition419232 = m_RocketLauncherAnimatorState420244.AddExitTransition();
			m_AnimatorStateTransition419232.canTransitionToSelf = true;
			m_AnimatorStateTransition419232.duration = 0.15f;
			m_AnimatorStateTransition419232.exitTime = 0f;
			m_AnimatorStateTransition419232.hasExitTime = false;
			m_AnimatorStateTransition419232.hasFixedDuration = true;
			m_AnimatorStateTransition419232.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419232.offset = 0f;
			m_AnimatorStateTransition419232.orderedInterruption = true;
			m_AnimatorStateTransition419232.isExit = true;
			m_AnimatorStateTransition419232.mute = false;
			m_AnimatorStateTransition419232.solo = false;
			m_AnimatorStateTransition419232.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition418700 = m_KatanaAnimatorState420266.AddExitTransition();
			m_AnimatorStateTransition418700.canTransitionToSelf = true;
			m_AnimatorStateTransition418700.duration = 0.15f;
			m_AnimatorStateTransition418700.exitTime = 0f;
			m_AnimatorStateTransition418700.hasExitTime = false;
			m_AnimatorStateTransition418700.hasFixedDuration = true;
			m_AnimatorStateTransition418700.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418700.offset = 0f;
			m_AnimatorStateTransition418700.orderedInterruption = true;
			m_AnimatorStateTransition418700.isExit = true;
			m_AnimatorStateTransition418700.mute = false;
			m_AnimatorStateTransition418700.solo = false;
			m_AnimatorStateTransition418700.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition419078 = m_BowAnimatorState420170.AddExitTransition();
			m_AnimatorStateTransition419078.canTransitionToSelf = true;
			m_AnimatorStateTransition419078.duration = 0.15f;
			m_AnimatorStateTransition419078.exitTime = 0f;
			m_AnimatorStateTransition419078.hasExitTime = false;
			m_AnimatorStateTransition419078.hasFixedDuration = true;
			m_AnimatorStateTransition419078.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419078.offset = 0f;
			m_AnimatorStateTransition419078.orderedInterruption = true;
			m_AnimatorStateTransition419078.isExit = true;
			m_AnimatorStateTransition419078.mute = false;
			m_AnimatorStateTransition419078.solo = false;
			m_AnimatorStateTransition419078.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition419960 = m_KnifeAnimatorState420218.AddExitTransition();
			m_AnimatorStateTransition419960.canTransitionToSelf = true;
			m_AnimatorStateTransition419960.duration = 0.15f;
			m_AnimatorStateTransition419960.exitTime = 0f;
			m_AnimatorStateTransition419960.hasExitTime = false;
			m_AnimatorStateTransition419960.hasFixedDuration = true;
			m_AnimatorStateTransition419960.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419960.offset = 0f;
			m_AnimatorStateTransition419960.orderedInterruption = true;
			m_AnimatorStateTransition419960.isExit = true;
			m_AnimatorStateTransition419960.mute = false;
			m_AnimatorStateTransition419960.solo = false;
			m_AnimatorStateTransition419960.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			var m_AnimatorStateTransition419692 = m_FragGrenadeAnimatorState420180.AddExitTransition();
			m_AnimatorStateTransition419692.canTransitionToSelf = true;
			m_AnimatorStateTransition419692.duration = 0.15f;
			m_AnimatorStateTransition419692.exitTime = 0f;
			m_AnimatorStateTransition419692.hasExitTime = false;
			m_AnimatorStateTransition419692.hasFixedDuration = true;
			m_AnimatorStateTransition419692.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419692.offset = 0f;
			m_AnimatorStateTransition419692.orderedInterruption = true;
			m_AnimatorStateTransition419692.isExit = true;
			m_AnimatorStateTransition419692.mute = false;
			m_AnimatorStateTransition419692.solo = false;
			m_AnimatorStateTransition419692.AddCondition(AnimatorConditionMode.NotEqual, 105f, "AbilityIndex");

			// State Machine Defaults.
			m_VaultAnimatorStateMachine420328.anyStatePosition = new Vector3(48f, 72f, 0f);
			m_VaultAnimatorStateMachine420328.defaultState = m_AssaultRifleAnimatorState420132;
			m_VaultAnimatorStateMachine420328.entryPosition = new Vector3(48f, 24f, 0f);
			m_VaultAnimatorStateMachine420328.exitPosition = new Vector3(768f, 72f, 0f);
			m_VaultAnimatorStateMachine420328.parentStateMachinePosition = new Vector3(756f, 0f, 0f);

			// State Machine Transitions.
			var m_AnimatorStateTransition419864 = baseStateMachine6.AddAnyStateTransition(m_SwordAnimatorState420212);
			m_AnimatorStateTransition419864.canTransitionToSelf = false;
			m_AnimatorStateTransition419864.duration = 0.1f;
			m_AnimatorStateTransition419864.exitTime = 0.75f;
			m_AnimatorStateTransition419864.hasExitTime = false;
			m_AnimatorStateTransition419864.hasFixedDuration = true;
			m_AnimatorStateTransition419864.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419864.offset = 0f;
			m_AnimatorStateTransition419864.orderedInterruption = true;
			m_AnimatorStateTransition419864.isExit = false;
			m_AnimatorStateTransition419864.mute = false;
			m_AnimatorStateTransition419864.solo = false;
			m_AnimatorStateTransition419864.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition419864.AddCondition(AnimatorConditionMode.Equals, 22f, "Slot0ItemID");

			var m_AnimatorStateTransition419432 = baseStateMachine6.AddAnyStateTransition(m_KnifeAnimatorState420218);
			m_AnimatorStateTransition419432.canTransitionToSelf = false;
			m_AnimatorStateTransition419432.duration = 0.1f;
			m_AnimatorStateTransition419432.exitTime = 0.75f;
			m_AnimatorStateTransition419432.hasExitTime = false;
			m_AnimatorStateTransition419432.hasFixedDuration = true;
			m_AnimatorStateTransition419432.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419432.offset = 0f;
			m_AnimatorStateTransition419432.orderedInterruption = true;
			m_AnimatorStateTransition419432.isExit = false;
			m_AnimatorStateTransition419432.mute = false;
			m_AnimatorStateTransition419432.solo = false;
			m_AnimatorStateTransition419432.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition419432.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition419432.AddCondition(AnimatorConditionMode.Equals, 23f, "Slot0ItemID");

			var m_AnimatorStateTransition419944 = baseStateMachine6.AddAnyStateTransition(m_KatanaAnimatorState420266);
			m_AnimatorStateTransition419944.canTransitionToSelf = false;
			m_AnimatorStateTransition419944.duration = 0.1f;
			m_AnimatorStateTransition419944.exitTime = 0.75f;
			m_AnimatorStateTransition419944.hasExitTime = false;
			m_AnimatorStateTransition419944.hasFixedDuration = true;
			m_AnimatorStateTransition419944.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419944.offset = 0f;
			m_AnimatorStateTransition419944.orderedInterruption = true;
			m_AnimatorStateTransition419944.isExit = false;
			m_AnimatorStateTransition419944.mute = false;
			m_AnimatorStateTransition419944.solo = false;
			m_AnimatorStateTransition419944.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition419944.AddCondition(AnimatorConditionMode.Equals, 24f, "Slot0ItemID");

			var m_AnimatorStateTransition419036 = baseStateMachine6.AddAnyStateTransition(m_BowAnimatorState420170);
			m_AnimatorStateTransition419036.canTransitionToSelf = false;
			m_AnimatorStateTransition419036.duration = 0.1f;
			m_AnimatorStateTransition419036.exitTime = 0.75f;
			m_AnimatorStateTransition419036.hasExitTime = false;
			m_AnimatorStateTransition419036.hasFixedDuration = true;
			m_AnimatorStateTransition419036.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419036.offset = 0f;
			m_AnimatorStateTransition419036.orderedInterruption = true;
			m_AnimatorStateTransition419036.isExit = false;
			m_AnimatorStateTransition419036.mute = false;
			m_AnimatorStateTransition419036.solo = false;
			m_AnimatorStateTransition419036.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition419036.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot1ItemID");

			var m_AnimatorStateTransition419732 = baseStateMachine6.AddAnyStateTransition(m_DualPistolAnimatorState420258);
			m_AnimatorStateTransition419732.canTransitionToSelf = false;
			m_AnimatorStateTransition419732.duration = 0.1f;
			m_AnimatorStateTransition419732.exitTime = 0.75f;
			m_AnimatorStateTransition419732.hasExitTime = false;
			m_AnimatorStateTransition419732.hasFixedDuration = true;
			m_AnimatorStateTransition419732.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419732.offset = 0f;
			m_AnimatorStateTransition419732.orderedInterruption = true;
			m_AnimatorStateTransition419732.isExit = false;
			m_AnimatorStateTransition419732.mute = false;
			m_AnimatorStateTransition419732.solo = false;
			m_AnimatorStateTransition419732.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition419732.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			m_AnimatorStateTransition419732.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot1ItemID");

			var m_AnimatorStateTransition419038 = baseStateMachine6.AddAnyStateTransition(m_ShotgunAnimatorState420078);
			m_AnimatorStateTransition419038.canTransitionToSelf = false;
			m_AnimatorStateTransition419038.duration = 0.1f;
			m_AnimatorStateTransition419038.exitTime = 0.75f;
			m_AnimatorStateTransition419038.hasExitTime = false;
			m_AnimatorStateTransition419038.hasFixedDuration = true;
			m_AnimatorStateTransition419038.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419038.offset = 0f;
			m_AnimatorStateTransition419038.orderedInterruption = true;
			m_AnimatorStateTransition419038.isExit = false;
			m_AnimatorStateTransition419038.mute = false;
			m_AnimatorStateTransition419038.solo = false;
			m_AnimatorStateTransition419038.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition419038.AddCondition(AnimatorConditionMode.Equals, 3f, "Slot0ItemID");

			var m_AnimatorStateTransition418772 = baseStateMachine6.AddAnyStateTransition(m_PistolAnimatorState420044);
			m_AnimatorStateTransition418772.canTransitionToSelf = false;
			m_AnimatorStateTransition418772.duration = 0.1f;
			m_AnimatorStateTransition418772.exitTime = 0.75f;
			m_AnimatorStateTransition418772.hasExitTime = false;
			m_AnimatorStateTransition418772.hasFixedDuration = true;
			m_AnimatorStateTransition418772.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418772.offset = 0f;
			m_AnimatorStateTransition418772.orderedInterruption = true;
			m_AnimatorStateTransition418772.isExit = false;
			m_AnimatorStateTransition418772.mute = false;
			m_AnimatorStateTransition418772.solo = false;
			m_AnimatorStateTransition418772.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition418772.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			m_AnimatorStateTransition418772.AddCondition(AnimatorConditionMode.NotEqual, 2f, "Slot1ItemID");

			var m_AnimatorStateTransition419170 = baseStateMachine6.AddAnyStateTransition(m_RocketLauncherAnimatorState420244);
			m_AnimatorStateTransition419170.canTransitionToSelf = false;
			m_AnimatorStateTransition419170.duration = 0.1f;
			m_AnimatorStateTransition419170.exitTime = 0.75f;
			m_AnimatorStateTransition419170.hasExitTime = false;
			m_AnimatorStateTransition419170.hasFixedDuration = true;
			m_AnimatorStateTransition419170.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419170.offset = 0f;
			m_AnimatorStateTransition419170.orderedInterruption = true;
			m_AnimatorStateTransition419170.isExit = false;
			m_AnimatorStateTransition419170.mute = false;
			m_AnimatorStateTransition419170.solo = false;
			m_AnimatorStateTransition419170.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition419170.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemID");

			var m_AnimatorStateTransition419278 = baseStateMachine6.AddAnyStateTransition(m_AssaultRifleAnimatorState420132);
			m_AnimatorStateTransition419278.canTransitionToSelf = false;
			m_AnimatorStateTransition419278.duration = 0.1f;
			m_AnimatorStateTransition419278.exitTime = 0.75f;
			m_AnimatorStateTransition419278.hasExitTime = false;
			m_AnimatorStateTransition419278.hasFixedDuration = true;
			m_AnimatorStateTransition419278.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419278.offset = 0f;
			m_AnimatorStateTransition419278.orderedInterruption = true;
			m_AnimatorStateTransition419278.isExit = false;
			m_AnimatorStateTransition419278.mute = false;
			m_AnimatorStateTransition419278.solo = false;
			m_AnimatorStateTransition419278.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition419278.AddCondition(AnimatorConditionMode.Equals, 1f, "Slot0ItemID");

			var m_AnimatorStateTransition419446 = baseStateMachine6.AddAnyStateTransition(m_SniperRifleAnimatorState420102);
			m_AnimatorStateTransition419446.canTransitionToSelf = false;
			m_AnimatorStateTransition419446.duration = 0.1f;
			m_AnimatorStateTransition419446.exitTime = 0.75f;
			m_AnimatorStateTransition419446.hasExitTime = false;
			m_AnimatorStateTransition419446.hasFixedDuration = true;
			m_AnimatorStateTransition419446.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419446.offset = 0f;
			m_AnimatorStateTransition419446.orderedInterruption = true;
			m_AnimatorStateTransition419446.isExit = false;
			m_AnimatorStateTransition419446.mute = false;
			m_AnimatorStateTransition419446.solo = false;
			m_AnimatorStateTransition419446.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition419446.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemID");

			var m_AnimatorStateTransition418616 = baseStateMachine6.AddAnyStateTransition(m_FragGrenadeAnimatorState420180);
			m_AnimatorStateTransition418616.canTransitionToSelf = false;
			m_AnimatorStateTransition418616.duration = 0.1f;
			m_AnimatorStateTransition418616.exitTime = 0.75f;
			m_AnimatorStateTransition418616.hasExitTime = false;
			m_AnimatorStateTransition418616.hasFixedDuration = true;
			m_AnimatorStateTransition418616.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418616.offset = 0f;
			m_AnimatorStateTransition418616.orderedInterruption = true;
			m_AnimatorStateTransition418616.isExit = false;
			m_AnimatorStateTransition418616.mute = false;
			m_AnimatorStateTransition418616.solo = false;
			m_AnimatorStateTransition418616.AddCondition(AnimatorConditionMode.Equals, 105f, "AbilityIndex");
			m_AnimatorStateTransition418616.AddCondition(AnimatorConditionMode.Equals, 41f, "Slot0ItemID");
		}
	}
}
