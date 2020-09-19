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
	/// Draws a custom inspector for the Dodge Ability.
	/// </summary>
	[InspectorDrawer(typeof(Dodge))]
	public class DodgeInspectorDrawer : AbilityInspectorDrawer
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
					if (baseStateMachine0.stateMachines[j].stateMachine.name == "Dodge") {
						baseStateMachine0.RemoveStateMachine(baseStateMachine0.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var m_MeleeDodgeBwdAnimationClip14400Path = AssetDatabase.GUIDToAssetPath("e7bcf8f3e84813f48a90cd7827dbf231"); 
			var m_MeleeDodgeBwdAnimationClip14400 = AnimatorBuilder.GetAnimationClip(m_MeleeDodgeBwdAnimationClip14400Path, "MeleeDodgeBwd");
			var m_MeleeDodgeFwdAnimationClip16284Path = AssetDatabase.GUIDToAssetPath("a9418386ebd4e1644ae68187307fc18d"); 
			var m_MeleeDodgeFwdAnimationClip16284 = AnimatorBuilder.GetAnimationClip(m_MeleeDodgeFwdAnimationClip16284Path, "MeleeDodgeFwd");
			var m_MeleeDodgeRightFrontAnimationClip16036Path = AssetDatabase.GUIDToAssetPath("51ea8026172e39b41aea0efa128ffa9b"); 
			var m_MeleeDodgeRightFrontAnimationClip16036 = AnimatorBuilder.GetAnimationClip(m_MeleeDodgeRightFrontAnimationClip16036Path, "MeleeDodgeRightFront");
			var m_MeleeDodgeLeftFrontAnimationClip14892Path = AssetDatabase.GUIDToAssetPath("36ff4a8422553284e81570068ac8394c"); 
			var m_MeleeDodgeLeftFrontAnimationClip14892 = AnimatorBuilder.GetAnimationClip(m_MeleeDodgeLeftFrontAnimationClip14892Path, "MeleeDodgeLeftFront");
			var m_MeleeDodgeLeftBackAnimationClip15496Path = AssetDatabase.GUIDToAssetPath("8ff8c865fd67aa147b0247cee5342ed6"); 
			var m_MeleeDodgeLeftBackAnimationClip15496 = AnimatorBuilder.GetAnimationClip(m_MeleeDodgeLeftBackAnimationClip15496Path, "MeleeDodgeLeftBack");
			var m_MeleeDodgeRightBackAnimationClip14650Path = AssetDatabase.GUIDToAssetPath("2540da54527da3f48a4268b798bb77f8"); 
			var m_MeleeDodgeRightBackAnimationClip14650 = AnimatorBuilder.GetAnimationClip(m_MeleeDodgeRightBackAnimationClip14650Path, "MeleeDodgeRightBack");
			var m_DodgeLeftFrontAnimationClip21998Path = AssetDatabase.GUIDToAssetPath("2924899db8750e145a94f8407e27f52e"); 
			var m_DodgeLeftFrontAnimationClip21998 = AnimatorBuilder.GetAnimationClip(m_DodgeLeftFrontAnimationClip21998Path, "DodgeLeftFront");
			var m_DodgeRightFrontAnimationClip14678Path = AssetDatabase.GUIDToAssetPath("b44a54647fcaab745b64d5fd05e82d23"); 
			var m_DodgeRightFrontAnimationClip14678 = AnimatorBuilder.GetAnimationClip(m_DodgeRightFrontAnimationClip14678Path, "DodgeRightFront");
			var m_DodgeFwdAnimationClip14632Path = AssetDatabase.GUIDToAssetPath("c6577d4489d7c56478e2206131c3f836"); 
			var m_DodgeFwdAnimationClip14632 = AnimatorBuilder.GetAnimationClip(m_DodgeFwdAnimationClip14632Path, "DodgeFwd");
			var m_DodgeBwdAnimationClip13630Path = AssetDatabase.GUIDToAssetPath("e1a75bd20e3b6a449b6cdb0272e141da"); 
			var m_DodgeBwdAnimationClip13630 = AnimatorBuilder.GetAnimationClip(m_DodgeBwdAnimationClip13630Path, "DodgeBwd");
			var m_DodgeRightBackAnimationClip23638Path = AssetDatabase.GUIDToAssetPath("de82364f24793704ba3dbe4388b6d4ee"); 
			var m_DodgeRightBackAnimationClip23638 = AnimatorBuilder.GetAnimationClip(m_DodgeRightBackAnimationClip23638Path, "DodgeRightBack");
			var m_DodgeLeftBackAnimationClip11820Path = AssetDatabase.GUIDToAssetPath("b1aa4ab0d79ce554db3b358804cc79fc"); 
			var m_DodgeLeftBackAnimationClip11820 = AnimatorBuilder.GetAnimationClip(m_DodgeLeftBackAnimationClip11820Path, "DodgeLeftBack");
			var m_BowDodgeBwdAnimationClip21764Path = AssetDatabase.GUIDToAssetPath("1b60dd3de1d599144a0f7abc7647ca5c"); 
			var m_BowDodgeBwdAnimationClip21764 = AnimatorBuilder.GetAnimationClip(m_BowDodgeBwdAnimationClip21764Path, "BowDodgeBwd");
			var m_BowDodgeFwdAnimationClip18040Path = AssetDatabase.GUIDToAssetPath("e2affe2826a89294e9b162cd9898143c"); 
			var m_BowDodgeFwdAnimationClip18040 = AnimatorBuilder.GetAnimationClip(m_BowDodgeFwdAnimationClip18040Path, "BowDodgeFwd");
			var m_BowDodgeRightFrontAnimationClip21312Path = AssetDatabase.GUIDToAssetPath("eb7944ac7f494cd418908bf77250f0f0"); 
			var m_BowDodgeRightFrontAnimationClip21312 = AnimatorBuilder.GetAnimationClip(m_BowDodgeRightFrontAnimationClip21312Path, "BowDodgeRightFront");
			var m_BowDodgeLeftFrontAnimationClip18368Path = AssetDatabase.GUIDToAssetPath("79f1b69833b2c99499766434ee4f1088"); 
			var m_BowDodgeLeftFrontAnimationClip18368 = AnimatorBuilder.GetAnimationClip(m_BowDodgeLeftFrontAnimationClip18368Path, "BowDodgeLeftFront");
			var m_BowDodgeLeftBackAnimationClip14586Path = AssetDatabase.GUIDToAssetPath("08e76a348a853204191cc4b375421fcf"); 
			var m_BowDodgeLeftBackAnimationClip14586 = AnimatorBuilder.GetAnimationClip(m_BowDodgeLeftBackAnimationClip14586Path, "BowDodgeLeftBack");
			var m_BowDodgeRightBackAnimationClip18064Path = AssetDatabase.GUIDToAssetPath("11b8cb3821ea2044ca00f75a857195a8"); 
			var m_BowDodgeRightBackAnimationClip18064 = AnimatorBuilder.GetAnimationClip(m_BowDodgeRightBackAnimationClip18064Path, "BowDodgeRightBack");

			// State Machine.
			var m_DodgeAnimatorStateMachine420362 = baseStateMachine0.AddStateMachine("Dodge", new Vector3(624f, 60f, 0f));

			// State Machine.
			var m_MeleeDodgeAnimatorStateMachine420348 = m_DodgeAnimatorStateMachine420362.AddStateMachine("Melee Dodge", new Vector3(372f, 36f, 0f));

			// States.
			var m_MeleeDodgeBackwardAnimatorState420168 = m_MeleeDodgeAnimatorStateMachine420348.AddState("Melee Dodge Backward", new Vector3(384f, -60f, 0f));
			m_MeleeDodgeBackwardAnimatorState420168.motion = m_MeleeDodgeBwdAnimationClip14400;
			m_MeleeDodgeBackwardAnimatorState420168.cycleOffset = 0f;
			m_MeleeDodgeBackwardAnimatorState420168.cycleOffsetParameterActive = false;
			m_MeleeDodgeBackwardAnimatorState420168.iKOnFeet = true;
			m_MeleeDodgeBackwardAnimatorState420168.mirror = false;
			m_MeleeDodgeBackwardAnimatorState420168.mirrorParameterActive = false;
			m_MeleeDodgeBackwardAnimatorState420168.speed = 1f;
			m_MeleeDodgeBackwardAnimatorState420168.speedParameterActive = false;
			m_MeleeDodgeBackwardAnimatorState420168.writeDefaultValues = false;

			var m_MeleeDodgeForwardAnimatorState420226 = m_MeleeDodgeAnimatorStateMachine420348.AddState("Melee Dodge Forward", new Vector3(384f, -120f, 0f));
			m_MeleeDodgeForwardAnimatorState420226.motion = m_MeleeDodgeFwdAnimationClip16284;
			m_MeleeDodgeForwardAnimatorState420226.cycleOffset = 0f;
			m_MeleeDodgeForwardAnimatorState420226.cycleOffsetParameterActive = false;
			m_MeleeDodgeForwardAnimatorState420226.iKOnFeet = true;
			m_MeleeDodgeForwardAnimatorState420226.mirror = false;
			m_MeleeDodgeForwardAnimatorState420226.mirrorParameterActive = false;
			m_MeleeDodgeForwardAnimatorState420226.speed = 1f;
			m_MeleeDodgeForwardAnimatorState420226.speedParameterActive = false;
			m_MeleeDodgeForwardAnimatorState420226.writeDefaultValues = false;

			var m_MeleeDodgeRightFrontAnimatorState420310 = m_MeleeDodgeAnimatorStateMachine420348.AddState("Melee Dodge Right Front", new Vector3(384f, 120f, 0f));
			m_MeleeDodgeRightFrontAnimatorState420310.motion = m_MeleeDodgeRightFrontAnimationClip16036;
			m_MeleeDodgeRightFrontAnimatorState420310.cycleOffset = 0f;
			m_MeleeDodgeRightFrontAnimatorState420310.cycleOffsetParameterActive = false;
			m_MeleeDodgeRightFrontAnimatorState420310.iKOnFeet = true;
			m_MeleeDodgeRightFrontAnimatorState420310.mirror = false;
			m_MeleeDodgeRightFrontAnimatorState420310.mirrorParameterActive = false;
			m_MeleeDodgeRightFrontAnimatorState420310.speed = 1f;
			m_MeleeDodgeRightFrontAnimatorState420310.speedParameterActive = false;
			m_MeleeDodgeRightFrontAnimatorState420310.writeDefaultValues = false;

			var m_MeleeDodgeLeftFrontAnimatorState420268 = m_MeleeDodgeAnimatorStateMachine420348.AddState("Melee Dodge Left Front", new Vector3(384f, 0f, 0f));
			m_MeleeDodgeLeftFrontAnimatorState420268.motion = m_MeleeDodgeLeftFrontAnimationClip14892;
			m_MeleeDodgeLeftFrontAnimatorState420268.cycleOffset = 0f;
			m_MeleeDodgeLeftFrontAnimatorState420268.cycleOffsetParameterActive = false;
			m_MeleeDodgeLeftFrontAnimatorState420268.iKOnFeet = true;
			m_MeleeDodgeLeftFrontAnimatorState420268.mirror = false;
			m_MeleeDodgeLeftFrontAnimatorState420268.mirrorParameterActive = false;
			m_MeleeDodgeLeftFrontAnimatorState420268.speed = 1f;
			m_MeleeDodgeLeftFrontAnimatorState420268.speedParameterActive = false;
			m_MeleeDodgeLeftFrontAnimatorState420268.writeDefaultValues = false;

			var m_MeleeDodgeLeftBackAnimatorState420292 = m_MeleeDodgeAnimatorStateMachine420348.AddState("Melee Dodge Left Back", new Vector3(384f, 60f, 0f));
			m_MeleeDodgeLeftBackAnimatorState420292.motion = m_MeleeDodgeLeftBackAnimationClip15496;
			m_MeleeDodgeLeftBackAnimatorState420292.cycleOffset = 0f;
			m_MeleeDodgeLeftBackAnimatorState420292.cycleOffsetParameterActive = false;
			m_MeleeDodgeLeftBackAnimatorState420292.iKOnFeet = true;
			m_MeleeDodgeLeftBackAnimatorState420292.mirror = false;
			m_MeleeDodgeLeftBackAnimatorState420292.mirrorParameterActive = false;
			m_MeleeDodgeLeftBackAnimatorState420292.speed = 1f;
			m_MeleeDodgeLeftBackAnimatorState420292.speedParameterActive = false;
			m_MeleeDodgeLeftBackAnimatorState420292.writeDefaultValues = false;

			var m_MeleeDodgeRightBackAnimatorState420046 = m_MeleeDodgeAnimatorStateMachine420348.AddState("Melee Dodge Right Back", new Vector3(384f, 180f, 0f));
			m_MeleeDodgeRightBackAnimatorState420046.motion = m_MeleeDodgeRightBackAnimationClip14650;
			m_MeleeDodgeRightBackAnimatorState420046.cycleOffset = 0f;
			m_MeleeDodgeRightBackAnimatorState420046.cycleOffsetParameterActive = false;
			m_MeleeDodgeRightBackAnimatorState420046.iKOnFeet = true;
			m_MeleeDodgeRightBackAnimatorState420046.mirror = false;
			m_MeleeDodgeRightBackAnimatorState420046.mirrorParameterActive = false;
			m_MeleeDodgeRightBackAnimatorState420046.speed = 1f;
			m_MeleeDodgeRightBackAnimatorState420046.speedParameterActive = false;
			m_MeleeDodgeRightBackAnimatorState420046.writeDefaultValues = false;

			// State Transitions.
			var m_AnimatorStateTransition419096 = m_MeleeDodgeBackwardAnimatorState420168.AddExitTransition();
			m_AnimatorStateTransition419096.canTransitionToSelf = true;
			m_AnimatorStateTransition419096.duration = 0.1f;
			m_AnimatorStateTransition419096.exitTime = 0.75f;
			m_AnimatorStateTransition419096.hasExitTime = false;
			m_AnimatorStateTransition419096.hasFixedDuration = true;
			m_AnimatorStateTransition419096.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419096.offset = 0f;
			m_AnimatorStateTransition419096.orderedInterruption = true;
			m_AnimatorStateTransition419096.isExit = true;
			m_AnimatorStateTransition419096.mute = false;
			m_AnimatorStateTransition419096.solo = false;
			m_AnimatorStateTransition419096.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var m_AnimatorStateTransition418956 = m_MeleeDodgeForwardAnimatorState420226.AddExitTransition();
			m_AnimatorStateTransition418956.canTransitionToSelf = true;
			m_AnimatorStateTransition418956.duration = 0.1f;
			m_AnimatorStateTransition418956.exitTime = 0.95f;
			m_AnimatorStateTransition418956.hasExitTime = false;
			m_AnimatorStateTransition418956.hasFixedDuration = true;
			m_AnimatorStateTransition418956.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418956.offset = 0f;
			m_AnimatorStateTransition418956.orderedInterruption = true;
			m_AnimatorStateTransition418956.isExit = true;
			m_AnimatorStateTransition418956.mute = false;
			m_AnimatorStateTransition418956.solo = false;
			m_AnimatorStateTransition418956.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var m_AnimatorStateTransition419786 = m_MeleeDodgeRightFrontAnimatorState420310.AddExitTransition();
			m_AnimatorStateTransition419786.canTransitionToSelf = true;
			m_AnimatorStateTransition419786.duration = 0.1f;
			m_AnimatorStateTransition419786.exitTime = 0.95f;
			m_AnimatorStateTransition419786.hasExitTime = false;
			m_AnimatorStateTransition419786.hasFixedDuration = true;
			m_AnimatorStateTransition419786.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419786.offset = 0f;
			m_AnimatorStateTransition419786.orderedInterruption = true;
			m_AnimatorStateTransition419786.isExit = true;
			m_AnimatorStateTransition419786.mute = false;
			m_AnimatorStateTransition419786.solo = false;
			m_AnimatorStateTransition419786.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var m_AnimatorStateTransition419286 = m_MeleeDodgeLeftFrontAnimatorState420268.AddExitTransition();
			m_AnimatorStateTransition419286.canTransitionToSelf = true;
			m_AnimatorStateTransition419286.duration = 0.1f;
			m_AnimatorStateTransition419286.exitTime = 0.95f;
			m_AnimatorStateTransition419286.hasExitTime = false;
			m_AnimatorStateTransition419286.hasFixedDuration = true;
			m_AnimatorStateTransition419286.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419286.offset = 0f;
			m_AnimatorStateTransition419286.orderedInterruption = true;
			m_AnimatorStateTransition419286.isExit = true;
			m_AnimatorStateTransition419286.mute = false;
			m_AnimatorStateTransition419286.solo = false;
			m_AnimatorStateTransition419286.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var m_AnimatorStateTransition419720 = m_MeleeDodgeLeftBackAnimatorState420292.AddExitTransition();
			m_AnimatorStateTransition419720.canTransitionToSelf = true;
			m_AnimatorStateTransition419720.duration = 0.1f;
			m_AnimatorStateTransition419720.exitTime = 0.95f;
			m_AnimatorStateTransition419720.hasExitTime = false;
			m_AnimatorStateTransition419720.hasFixedDuration = true;
			m_AnimatorStateTransition419720.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419720.offset = 0f;
			m_AnimatorStateTransition419720.orderedInterruption = true;
			m_AnimatorStateTransition419720.isExit = true;
			m_AnimatorStateTransition419720.mute = false;
			m_AnimatorStateTransition419720.solo = false;
			m_AnimatorStateTransition419720.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var m_AnimatorStateTransition418526 = m_MeleeDodgeRightBackAnimatorState420046.AddExitTransition();
			m_AnimatorStateTransition418526.canTransitionToSelf = true;
			m_AnimatorStateTransition418526.duration = 0.1f;
			m_AnimatorStateTransition418526.exitTime = 0.95f;
			m_AnimatorStateTransition418526.hasExitTime = false;
			m_AnimatorStateTransition418526.hasFixedDuration = true;
			m_AnimatorStateTransition418526.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418526.offset = 0f;
			m_AnimatorStateTransition418526.orderedInterruption = true;
			m_AnimatorStateTransition418526.isExit = true;
			m_AnimatorStateTransition418526.mute = false;
			m_AnimatorStateTransition418526.solo = false;
			m_AnimatorStateTransition418526.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			// State Machine Defaults.
			m_MeleeDodgeAnimatorStateMachine420348.anyStatePosition = new Vector3(48f, 36f, 0f);
			m_MeleeDodgeAnimatorStateMachine420348.defaultState = m_MeleeDodgeForwardAnimatorState420226;
			m_MeleeDodgeAnimatorStateMachine420348.entryPosition = new Vector3(48f, -12f, 0f);
			m_MeleeDodgeAnimatorStateMachine420348.exitPosition = new Vector3(800f, 120f, 0f);
			m_MeleeDodgeAnimatorStateMachine420348.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Machine.
			var m_AimDodgeAnimatorStateMachine420356 = m_DodgeAnimatorStateMachine420362.AddStateMachine("Aim Dodge", new Vector3(372f, -12f, 0f));

			// States.
			var m_DodgeLeftFrontAnimatorState420300 = m_AimDodgeAnimatorStateMachine420356.AddState("Dodge Left Front", new Vector3(432f, 72f, 0f));
			m_DodgeLeftFrontAnimatorState420300.motion = m_DodgeLeftFrontAnimationClip21998;
			m_DodgeLeftFrontAnimatorState420300.cycleOffset = 0f;
			m_DodgeLeftFrontAnimatorState420300.cycleOffsetParameterActive = false;
			m_DodgeLeftFrontAnimatorState420300.iKOnFeet = true;
			m_DodgeLeftFrontAnimatorState420300.mirror = false;
			m_DodgeLeftFrontAnimatorState420300.mirrorParameterActive = false;
			m_DodgeLeftFrontAnimatorState420300.speed = 1f;
			m_DodgeLeftFrontAnimatorState420300.speedParameterActive = false;
			m_DodgeLeftFrontAnimatorState420300.writeDefaultValues = false;

			var m_DodgeRightFrontAnimatorState420144 = m_AimDodgeAnimatorStateMachine420356.AddState("Dodge Right Front", new Vector3(432f, 192f, 0f));
			m_DodgeRightFrontAnimatorState420144.motion = m_DodgeRightFrontAnimationClip14678;
			m_DodgeRightFrontAnimatorState420144.cycleOffset = 0f;
			m_DodgeRightFrontAnimatorState420144.cycleOffsetParameterActive = false;
			m_DodgeRightFrontAnimatorState420144.iKOnFeet = true;
			m_DodgeRightFrontAnimatorState420144.mirror = false;
			m_DodgeRightFrontAnimatorState420144.mirrorParameterActive = false;
			m_DodgeRightFrontAnimatorState420144.speed = 1f;
			m_DodgeRightFrontAnimatorState420144.speedParameterActive = false;
			m_DodgeRightFrontAnimatorState420144.writeDefaultValues = false;

			var m_DodgeForwardAnimatorState420166 = m_AimDodgeAnimatorStateMachine420356.AddState("Dodge Forward", new Vector3(432f, -48f, 0f));
			m_DodgeForwardAnimatorState420166.motion = m_DodgeFwdAnimationClip14632;
			m_DodgeForwardAnimatorState420166.cycleOffset = 0f;
			m_DodgeForwardAnimatorState420166.cycleOffsetParameterActive = false;
			m_DodgeForwardAnimatorState420166.iKOnFeet = true;
			m_DodgeForwardAnimatorState420166.mirror = false;
			m_DodgeForwardAnimatorState420166.mirrorParameterActive = false;
			m_DodgeForwardAnimatorState420166.speed = 1f;
			m_DodgeForwardAnimatorState420166.speedParameterActive = false;
			m_DodgeForwardAnimatorState420166.writeDefaultValues = true;

			var m_DodgeBackwardAnimatorState420238 = m_AimDodgeAnimatorStateMachine420356.AddState("Dodge Backward", new Vector3(432f, 12f, 0f));
			m_DodgeBackwardAnimatorState420238.motion = m_DodgeBwdAnimationClip13630;
			m_DodgeBackwardAnimatorState420238.cycleOffset = 0f;
			m_DodgeBackwardAnimatorState420238.cycleOffsetParameterActive = false;
			m_DodgeBackwardAnimatorState420238.iKOnFeet = true;
			m_DodgeBackwardAnimatorState420238.mirror = false;
			m_DodgeBackwardAnimatorState420238.mirrorParameterActive = false;
			m_DodgeBackwardAnimatorState420238.speed = 1f;
			m_DodgeBackwardAnimatorState420238.speedParameterActive = false;
			m_DodgeBackwardAnimatorState420238.writeDefaultValues = true;

			var m_DodgeRightBackAnimatorState420222 = m_AimDodgeAnimatorStateMachine420356.AddState("Dodge Right Back", new Vector3(432f, 252f, 0f));
			m_DodgeRightBackAnimatorState420222.motion = m_DodgeRightBackAnimationClip23638;
			m_DodgeRightBackAnimatorState420222.cycleOffset = 0f;
			m_DodgeRightBackAnimatorState420222.cycleOffsetParameterActive = false;
			m_DodgeRightBackAnimatorState420222.iKOnFeet = true;
			m_DodgeRightBackAnimatorState420222.mirror = false;
			m_DodgeRightBackAnimatorState420222.mirrorParameterActive = false;
			m_DodgeRightBackAnimatorState420222.speed = 1f;
			m_DodgeRightBackAnimatorState420222.speedParameterActive = false;
			m_DodgeRightBackAnimatorState420222.writeDefaultValues = false;

			var m_DodgeLeftBackAnimatorState420228 = m_AimDodgeAnimatorStateMachine420356.AddState("Dodge Left Back", new Vector3(432f, 132f, 0f));
			m_DodgeLeftBackAnimatorState420228.motion = m_DodgeLeftBackAnimationClip11820;
			m_DodgeLeftBackAnimatorState420228.cycleOffset = 0f;
			m_DodgeLeftBackAnimatorState420228.cycleOffsetParameterActive = false;
			m_DodgeLeftBackAnimatorState420228.iKOnFeet = true;
			m_DodgeLeftBackAnimatorState420228.mirror = false;
			m_DodgeLeftBackAnimatorState420228.mirrorParameterActive = false;
			m_DodgeLeftBackAnimatorState420228.speed = 1f;
			m_DodgeLeftBackAnimatorState420228.speedParameterActive = false;
			m_DodgeLeftBackAnimatorState420228.writeDefaultValues = false;

			// State Transitions.
			var m_AnimatorStateTransition419198 = m_DodgeLeftFrontAnimatorState420300.AddExitTransition();
			m_AnimatorStateTransition419198.canTransitionToSelf = true;
			m_AnimatorStateTransition419198.duration = 0.1f;
			m_AnimatorStateTransition419198.exitTime = 0.95f;
			m_AnimatorStateTransition419198.hasExitTime = false;
			m_AnimatorStateTransition419198.hasFixedDuration = true;
			m_AnimatorStateTransition419198.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419198.offset = 0f;
			m_AnimatorStateTransition419198.orderedInterruption = true;
			m_AnimatorStateTransition419198.isExit = true;
			m_AnimatorStateTransition419198.mute = false;
			m_AnimatorStateTransition419198.solo = false;
			m_AnimatorStateTransition419198.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var m_AnimatorStateTransition419972 = m_DodgeRightFrontAnimatorState420144.AddExitTransition();
			m_AnimatorStateTransition419972.canTransitionToSelf = true;
			m_AnimatorStateTransition419972.duration = 0.1f;
			m_AnimatorStateTransition419972.exitTime = 0.95f;
			m_AnimatorStateTransition419972.hasExitTime = false;
			m_AnimatorStateTransition419972.hasFixedDuration = true;
			m_AnimatorStateTransition419972.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419972.offset = 0f;
			m_AnimatorStateTransition419972.orderedInterruption = true;
			m_AnimatorStateTransition419972.isExit = true;
			m_AnimatorStateTransition419972.mute = false;
			m_AnimatorStateTransition419972.solo = false;
			m_AnimatorStateTransition419972.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var m_AnimatorStateTransition418576 = m_DodgeForwardAnimatorState420166.AddExitTransition();
			m_AnimatorStateTransition418576.canTransitionToSelf = true;
			m_AnimatorStateTransition418576.duration = 0.1f;
			m_AnimatorStateTransition418576.exitTime = 0.95f;
			m_AnimatorStateTransition418576.hasExitTime = false;
			m_AnimatorStateTransition418576.hasFixedDuration = true;
			m_AnimatorStateTransition418576.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418576.offset = 0f;
			m_AnimatorStateTransition418576.orderedInterruption = true;
			m_AnimatorStateTransition418576.isExit = true;
			m_AnimatorStateTransition418576.mute = false;
			m_AnimatorStateTransition418576.solo = false;
			m_AnimatorStateTransition418576.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var m_AnimatorStateTransition418990 = m_DodgeBackwardAnimatorState420238.AddExitTransition();
			m_AnimatorStateTransition418990.canTransitionToSelf = true;
			m_AnimatorStateTransition418990.duration = 0.1f;
			m_AnimatorStateTransition418990.exitTime = 0.75f;
			m_AnimatorStateTransition418990.hasExitTime = false;
			m_AnimatorStateTransition418990.hasFixedDuration = true;
			m_AnimatorStateTransition418990.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418990.offset = 0f;
			m_AnimatorStateTransition418990.orderedInterruption = true;
			m_AnimatorStateTransition418990.isExit = true;
			m_AnimatorStateTransition418990.mute = false;
			m_AnimatorStateTransition418990.solo = false;
			m_AnimatorStateTransition418990.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var m_AnimatorStateTransition418650 = m_DodgeRightBackAnimatorState420222.AddExitTransition();
			m_AnimatorStateTransition418650.canTransitionToSelf = true;
			m_AnimatorStateTransition418650.duration = 0.1f;
			m_AnimatorStateTransition418650.exitTime = 0.95f;
			m_AnimatorStateTransition418650.hasExitTime = false;
			m_AnimatorStateTransition418650.hasFixedDuration = true;
			m_AnimatorStateTransition418650.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418650.offset = 0f;
			m_AnimatorStateTransition418650.orderedInterruption = true;
			m_AnimatorStateTransition418650.isExit = true;
			m_AnimatorStateTransition418650.mute = false;
			m_AnimatorStateTransition418650.solo = false;
			m_AnimatorStateTransition418650.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var m_AnimatorStateTransition418818 = m_DodgeLeftBackAnimatorState420228.AddExitTransition();
			m_AnimatorStateTransition418818.canTransitionToSelf = true;
			m_AnimatorStateTransition418818.duration = 0.1f;
			m_AnimatorStateTransition418818.exitTime = 0.95f;
			m_AnimatorStateTransition418818.hasExitTime = false;
			m_AnimatorStateTransition418818.hasFixedDuration = true;
			m_AnimatorStateTransition418818.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418818.offset = 0f;
			m_AnimatorStateTransition418818.orderedInterruption = true;
			m_AnimatorStateTransition418818.isExit = true;
			m_AnimatorStateTransition418818.mute = false;
			m_AnimatorStateTransition418818.solo = false;
			m_AnimatorStateTransition418818.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			// State Machine Defaults.
			m_AimDodgeAnimatorStateMachine420356.anyStatePosition = new Vector3(48f, 48f, 0f);
			m_AimDodgeAnimatorStateMachine420356.defaultState = m_DodgeForwardAnimatorState420166;
			m_AimDodgeAnimatorStateMachine420356.entryPosition = new Vector3(48f, 0f, 0f);
			m_AimDodgeAnimatorStateMachine420356.exitPosition = new Vector3(800f, 120f, 0f);
			m_AimDodgeAnimatorStateMachine420356.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Machine.
			var m_BowDodgeAnimatorStateMachine420346 = m_DodgeAnimatorStateMachine420362.AddStateMachine("Bow Dodge", new Vector3(372f, 84f, 0f));

			// States.
			var m_BowDodgeBackwardAnimatorState420006 = m_BowDodgeAnimatorStateMachine420346.AddState("Bow Dodge Backward", new Vector3(384f, -60f, 0f));
			m_BowDodgeBackwardAnimatorState420006.motion = m_BowDodgeBwdAnimationClip21764;
			m_BowDodgeBackwardAnimatorState420006.cycleOffset = 0f;
			m_BowDodgeBackwardAnimatorState420006.cycleOffsetParameterActive = false;
			m_BowDodgeBackwardAnimatorState420006.iKOnFeet = true;
			m_BowDodgeBackwardAnimatorState420006.mirror = false;
			m_BowDodgeBackwardAnimatorState420006.mirrorParameterActive = false;
			m_BowDodgeBackwardAnimatorState420006.speed = 1f;
			m_BowDodgeBackwardAnimatorState420006.speedParameterActive = false;
			m_BowDodgeBackwardAnimatorState420006.writeDefaultValues = false;

			var m_BowDodgeForwardAnimatorState420002 = m_BowDodgeAnimatorStateMachine420346.AddState("Bow Dodge Forward", new Vector3(384f, -120f, 0f));
			m_BowDodgeForwardAnimatorState420002.motion = m_BowDodgeFwdAnimationClip18040;
			m_BowDodgeForwardAnimatorState420002.cycleOffset = 0f;
			m_BowDodgeForwardAnimatorState420002.cycleOffsetParameterActive = false;
			m_BowDodgeForwardAnimatorState420002.iKOnFeet = true;
			m_BowDodgeForwardAnimatorState420002.mirror = false;
			m_BowDodgeForwardAnimatorState420002.mirrorParameterActive = false;
			m_BowDodgeForwardAnimatorState420002.speed = 1f;
			m_BowDodgeForwardAnimatorState420002.speedParameterActive = false;
			m_BowDodgeForwardAnimatorState420002.writeDefaultValues = false;

			var m_BowDodgeRightFrontAnimatorState420156 = m_BowDodgeAnimatorStateMachine420346.AddState("Bow Dodge Right Front", new Vector3(384f, 120f, 0f));
			m_BowDodgeRightFrontAnimatorState420156.motion = m_BowDodgeRightFrontAnimationClip21312;
			m_BowDodgeRightFrontAnimatorState420156.cycleOffset = 0f;
			m_BowDodgeRightFrontAnimatorState420156.cycleOffsetParameterActive = false;
			m_BowDodgeRightFrontAnimatorState420156.iKOnFeet = true;
			m_BowDodgeRightFrontAnimatorState420156.mirror = false;
			m_BowDodgeRightFrontAnimatorState420156.mirrorParameterActive = false;
			m_BowDodgeRightFrontAnimatorState420156.speed = 1f;
			m_BowDodgeRightFrontAnimatorState420156.speedParameterActive = false;
			m_BowDodgeRightFrontAnimatorState420156.writeDefaultValues = false;

			var m_BowDodgeLeftFrontAnimatorState420202 = m_BowDodgeAnimatorStateMachine420346.AddState("Bow Dodge Left Front", new Vector3(384f, 0f, 0f));
			m_BowDodgeLeftFrontAnimatorState420202.motion = m_BowDodgeLeftFrontAnimationClip18368;
			m_BowDodgeLeftFrontAnimatorState420202.cycleOffset = 0f;
			m_BowDodgeLeftFrontAnimatorState420202.cycleOffsetParameterActive = false;
			m_BowDodgeLeftFrontAnimatorState420202.iKOnFeet = true;
			m_BowDodgeLeftFrontAnimatorState420202.mirror = false;
			m_BowDodgeLeftFrontAnimatorState420202.mirrorParameterActive = false;
			m_BowDodgeLeftFrontAnimatorState420202.speed = 1f;
			m_BowDodgeLeftFrontAnimatorState420202.speedParameterActive = false;
			m_BowDodgeLeftFrontAnimatorState420202.writeDefaultValues = false;

			var m_BowDodgeLeftBackAnimatorState420080 = m_BowDodgeAnimatorStateMachine420346.AddState("Bow Dodge Left Back", new Vector3(384f, 60f, 0f));
			m_BowDodgeLeftBackAnimatorState420080.motion = m_BowDodgeLeftBackAnimationClip14586;
			m_BowDodgeLeftBackAnimatorState420080.cycleOffset = 0f;
			m_BowDodgeLeftBackAnimatorState420080.cycleOffsetParameterActive = false;
			m_BowDodgeLeftBackAnimatorState420080.iKOnFeet = true;
			m_BowDodgeLeftBackAnimatorState420080.mirror = false;
			m_BowDodgeLeftBackAnimatorState420080.mirrorParameterActive = false;
			m_BowDodgeLeftBackAnimatorState420080.speed = 1f;
			m_BowDodgeLeftBackAnimatorState420080.speedParameterActive = false;
			m_BowDodgeLeftBackAnimatorState420080.writeDefaultValues = false;

			var m_BowDodgeRightBackAnimatorState420176 = m_BowDodgeAnimatorStateMachine420346.AddState("Bow Dodge Right Back", new Vector3(384f, 180f, 0f));
			m_BowDodgeRightBackAnimatorState420176.motion = m_BowDodgeRightBackAnimationClip18064;
			m_BowDodgeRightBackAnimatorState420176.cycleOffset = 0f;
			m_BowDodgeRightBackAnimatorState420176.cycleOffsetParameterActive = false;
			m_BowDodgeRightBackAnimatorState420176.iKOnFeet = true;
			m_BowDodgeRightBackAnimatorState420176.mirror = false;
			m_BowDodgeRightBackAnimatorState420176.mirrorParameterActive = false;
			m_BowDodgeRightBackAnimatorState420176.speed = 1f;
			m_BowDodgeRightBackAnimatorState420176.speedParameterActive = false;
			m_BowDodgeRightBackAnimatorState420176.writeDefaultValues = false;

			// State Transitions.
			var m_AnimatorStateTransition418734 = m_BowDodgeBackwardAnimatorState420006.AddExitTransition();
			m_AnimatorStateTransition418734.canTransitionToSelf = true;
			m_AnimatorStateTransition418734.duration = 0.1f;
			m_AnimatorStateTransition418734.exitTime = 0.75f;
			m_AnimatorStateTransition418734.hasExitTime = false;
			m_AnimatorStateTransition418734.hasFixedDuration = true;
			m_AnimatorStateTransition418734.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418734.offset = 0f;
			m_AnimatorStateTransition418734.orderedInterruption = true;
			m_AnimatorStateTransition418734.isExit = true;
			m_AnimatorStateTransition418734.mute = false;
			m_AnimatorStateTransition418734.solo = false;
			m_AnimatorStateTransition418734.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var m_AnimatorStateTransition419486 = m_BowDodgeForwardAnimatorState420002.AddExitTransition();
			m_AnimatorStateTransition419486.canTransitionToSelf = true;
			m_AnimatorStateTransition419486.duration = 0.1f;
			m_AnimatorStateTransition419486.exitTime = 0.95f;
			m_AnimatorStateTransition419486.hasExitTime = false;
			m_AnimatorStateTransition419486.hasFixedDuration = true;
			m_AnimatorStateTransition419486.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419486.offset = 0f;
			m_AnimatorStateTransition419486.orderedInterruption = true;
			m_AnimatorStateTransition419486.isExit = true;
			m_AnimatorStateTransition419486.mute = false;
			m_AnimatorStateTransition419486.solo = false;
			m_AnimatorStateTransition419486.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var m_AnimatorStateTransition419832 = m_BowDodgeRightFrontAnimatorState420156.AddExitTransition();
			m_AnimatorStateTransition419832.canTransitionToSelf = true;
			m_AnimatorStateTransition419832.duration = 0.1f;
			m_AnimatorStateTransition419832.exitTime = 0.95f;
			m_AnimatorStateTransition419832.hasExitTime = false;
			m_AnimatorStateTransition419832.hasFixedDuration = true;
			m_AnimatorStateTransition419832.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419832.offset = 0f;
			m_AnimatorStateTransition419832.orderedInterruption = true;
			m_AnimatorStateTransition419832.isExit = true;
			m_AnimatorStateTransition419832.mute = false;
			m_AnimatorStateTransition419832.solo = false;
			m_AnimatorStateTransition419832.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var m_AnimatorStateTransition418770 = m_BowDodgeLeftFrontAnimatorState420202.AddExitTransition();
			m_AnimatorStateTransition418770.canTransitionToSelf = true;
			m_AnimatorStateTransition418770.duration = 0.1f;
			m_AnimatorStateTransition418770.exitTime = 0.95f;
			m_AnimatorStateTransition418770.hasExitTime = false;
			m_AnimatorStateTransition418770.hasFixedDuration = true;
			m_AnimatorStateTransition418770.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418770.offset = 0f;
			m_AnimatorStateTransition418770.orderedInterruption = true;
			m_AnimatorStateTransition418770.isExit = true;
			m_AnimatorStateTransition418770.mute = false;
			m_AnimatorStateTransition418770.solo = false;
			m_AnimatorStateTransition418770.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var m_AnimatorStateTransition418920 = m_BowDodgeLeftBackAnimatorState420080.AddExitTransition();
			m_AnimatorStateTransition418920.canTransitionToSelf = true;
			m_AnimatorStateTransition418920.duration = 0.1f;
			m_AnimatorStateTransition418920.exitTime = 0.95f;
			m_AnimatorStateTransition418920.hasExitTime = false;
			m_AnimatorStateTransition418920.hasFixedDuration = true;
			m_AnimatorStateTransition418920.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418920.offset = 0f;
			m_AnimatorStateTransition418920.orderedInterruption = true;
			m_AnimatorStateTransition418920.isExit = true;
			m_AnimatorStateTransition418920.mute = false;
			m_AnimatorStateTransition418920.solo = false;
			m_AnimatorStateTransition418920.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			var m_AnimatorStateTransition419618 = m_BowDodgeRightBackAnimatorState420176.AddExitTransition();
			m_AnimatorStateTransition419618.canTransitionToSelf = true;
			m_AnimatorStateTransition419618.duration = 0.1f;
			m_AnimatorStateTransition419618.exitTime = 0.95f;
			m_AnimatorStateTransition419618.hasExitTime = false;
			m_AnimatorStateTransition419618.hasFixedDuration = true;
			m_AnimatorStateTransition419618.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419618.offset = 0f;
			m_AnimatorStateTransition419618.orderedInterruption = true;
			m_AnimatorStateTransition419618.isExit = true;
			m_AnimatorStateTransition419618.mute = false;
			m_AnimatorStateTransition419618.solo = false;
			m_AnimatorStateTransition419618.AddCondition(AnimatorConditionMode.NotEqual, 101f, "AbilityIndex");

			// State Machine Defaults.
			m_BowDodgeAnimatorStateMachine420346.anyStatePosition = new Vector3(48f, 48f, 0f);
			m_BowDodgeAnimatorStateMachine420346.defaultState = m_BowDodgeForwardAnimatorState420002;
			m_BowDodgeAnimatorStateMachine420346.entryPosition = new Vector3(48f, 0f, 0f);
			m_BowDodgeAnimatorStateMachine420346.exitPosition = new Vector3(800f, 120f, 0f);
			m_BowDodgeAnimatorStateMachine420346.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Machine Defaults.
			m_DodgeAnimatorStateMachine420362.anyStatePosition = new Vector3(50f, 20f, 0f);
			m_DodgeAnimatorStateMachine420362.defaultState = m_DodgeForwardAnimatorState420166;
			m_DodgeAnimatorStateMachine420362.entryPosition = new Vector3(50f, 120f, 0f);
			m_DodgeAnimatorStateMachine420362.exitPosition = new Vector3(800f, 120f, 0f);
			m_DodgeAnimatorStateMachine420362.parentStateMachinePosition = new Vector3(800f, 20f, 0f);

			// State Machine Transitions.
			var m_AnimatorStateTransition419526 = baseStateMachine0.AddAnyStateTransition(m_MeleeDodgeBackwardAnimatorState420168);
			m_AnimatorStateTransition419526.canTransitionToSelf = false;
			m_AnimatorStateTransition419526.duration = 0.1f;
			m_AnimatorStateTransition419526.exitTime = 0.75f;
			m_AnimatorStateTransition419526.hasExitTime = false;
			m_AnimatorStateTransition419526.hasFixedDuration = true;
			m_AnimatorStateTransition419526.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419526.offset = 0f;
			m_AnimatorStateTransition419526.orderedInterruption = true;
			m_AnimatorStateTransition419526.isExit = false;
			m_AnimatorStateTransition419526.mute = false;
			m_AnimatorStateTransition419526.solo = false;
			m_AnimatorStateTransition419526.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition419526.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition419526.AddCondition(AnimatorConditionMode.Equals, 3f, "AbilityIntData");
			m_AnimatorStateTransition419526.AddCondition(AnimatorConditionMode.Equals, 1f, "MovementSetID");

			var m_AnimatorStateTransition419750 = baseStateMachine0.AddAnyStateTransition(m_MeleeDodgeForwardAnimatorState420226);
			m_AnimatorStateTransition419750.canTransitionToSelf = false;
			m_AnimatorStateTransition419750.duration = 0.1f;
			m_AnimatorStateTransition419750.exitTime = 0.75f;
			m_AnimatorStateTransition419750.hasExitTime = false;
			m_AnimatorStateTransition419750.hasFixedDuration = true;
			m_AnimatorStateTransition419750.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419750.offset = 0f;
			m_AnimatorStateTransition419750.orderedInterruption = true;
			m_AnimatorStateTransition419750.isExit = false;
			m_AnimatorStateTransition419750.mute = false;
			m_AnimatorStateTransition419750.solo = false;
			m_AnimatorStateTransition419750.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition419750.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition419750.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			m_AnimatorStateTransition419750.AddCondition(AnimatorConditionMode.Equals, 1f, "MovementSetID");

			var m_AnimatorStateTransition418858 = baseStateMachine0.AddAnyStateTransition(m_MeleeDodgeRightFrontAnimatorState420310);
			m_AnimatorStateTransition418858.canTransitionToSelf = false;
			m_AnimatorStateTransition418858.duration = 0.1f;
			m_AnimatorStateTransition418858.exitTime = 0.75f;
			m_AnimatorStateTransition418858.hasExitTime = false;
			m_AnimatorStateTransition418858.hasFixedDuration = true;
			m_AnimatorStateTransition418858.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418858.offset = 0f;
			m_AnimatorStateTransition418858.orderedInterruption = true;
			m_AnimatorStateTransition418858.isExit = false;
			m_AnimatorStateTransition418858.mute = false;
			m_AnimatorStateTransition418858.solo = false;
			m_AnimatorStateTransition418858.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition418858.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition418858.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			m_AnimatorStateTransition418858.AddCondition(AnimatorConditionMode.Equals, 1f, "MovementSetID");
			m_AnimatorStateTransition418858.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var m_AnimatorStateTransition418692 = baseStateMachine0.AddAnyStateTransition(m_MeleeDodgeLeftFrontAnimatorState420268);
			m_AnimatorStateTransition418692.canTransitionToSelf = false;
			m_AnimatorStateTransition418692.duration = 0.1f;
			m_AnimatorStateTransition418692.exitTime = 0.75f;
			m_AnimatorStateTransition418692.hasExitTime = false;
			m_AnimatorStateTransition418692.hasFixedDuration = true;
			m_AnimatorStateTransition418692.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418692.offset = 0f;
			m_AnimatorStateTransition418692.orderedInterruption = true;
			m_AnimatorStateTransition418692.isExit = false;
			m_AnimatorStateTransition418692.mute = false;
			m_AnimatorStateTransition418692.solo = false;
			m_AnimatorStateTransition418692.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition418692.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition418692.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			m_AnimatorStateTransition418692.AddCondition(AnimatorConditionMode.Equals, 1f, "MovementSetID");
			m_AnimatorStateTransition418692.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var m_AnimatorStateTransition419558 = baseStateMachine0.AddAnyStateTransition(m_MeleeDodgeLeftBackAnimatorState420292);
			m_AnimatorStateTransition419558.canTransitionToSelf = false;
			m_AnimatorStateTransition419558.duration = 0.1f;
			m_AnimatorStateTransition419558.exitTime = 0.75f;
			m_AnimatorStateTransition419558.hasExitTime = false;
			m_AnimatorStateTransition419558.hasFixedDuration = true;
			m_AnimatorStateTransition419558.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419558.offset = 0f;
			m_AnimatorStateTransition419558.orderedInterruption = true;
			m_AnimatorStateTransition419558.isExit = false;
			m_AnimatorStateTransition419558.mute = false;
			m_AnimatorStateTransition419558.solo = false;
			m_AnimatorStateTransition419558.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition419558.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition419558.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			m_AnimatorStateTransition419558.AddCondition(AnimatorConditionMode.Equals, 1f, "MovementSetID");
			m_AnimatorStateTransition419558.AddCondition(AnimatorConditionMode.Less, 0.499f, "LegIndex");

			var m_AnimatorStateTransition419398 = baseStateMachine0.AddAnyStateTransition(m_MeleeDodgeRightBackAnimatorState420046);
			m_AnimatorStateTransition419398.canTransitionToSelf = false;
			m_AnimatorStateTransition419398.duration = 0.1f;
			m_AnimatorStateTransition419398.exitTime = 0.75f;
			m_AnimatorStateTransition419398.hasExitTime = false;
			m_AnimatorStateTransition419398.hasFixedDuration = true;
			m_AnimatorStateTransition419398.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419398.offset = 0f;
			m_AnimatorStateTransition419398.orderedInterruption = true;
			m_AnimatorStateTransition419398.isExit = false;
			m_AnimatorStateTransition419398.mute = false;
			m_AnimatorStateTransition419398.solo = false;
			m_AnimatorStateTransition419398.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition419398.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition419398.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			m_AnimatorStateTransition419398.AddCondition(AnimatorConditionMode.Equals, 1f, "MovementSetID");
			m_AnimatorStateTransition419398.AddCondition(AnimatorConditionMode.Less, 0.499f, "LegIndex");

			var m_AnimatorStateTransition419708 = baseStateMachine0.AddAnyStateTransition(m_DodgeLeftFrontAnimatorState420300);
			m_AnimatorStateTransition419708.canTransitionToSelf = false;
			m_AnimatorStateTransition419708.duration = 0.1f;
			m_AnimatorStateTransition419708.exitTime = 0.75f;
			m_AnimatorStateTransition419708.hasExitTime = false;
			m_AnimatorStateTransition419708.hasFixedDuration = true;
			m_AnimatorStateTransition419708.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419708.offset = 0f;
			m_AnimatorStateTransition419708.orderedInterruption = true;
			m_AnimatorStateTransition419708.isExit = false;
			m_AnimatorStateTransition419708.mute = false;
			m_AnimatorStateTransition419708.solo = false;
			m_AnimatorStateTransition419708.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition419708.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition419708.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			m_AnimatorStateTransition419708.AddCondition(AnimatorConditionMode.Equals, 0f, "MovementSetID");
			m_AnimatorStateTransition419708.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var m_AnimatorStateTransition418996 = baseStateMachine0.AddAnyStateTransition(m_DodgeRightFrontAnimatorState420144);
			m_AnimatorStateTransition418996.canTransitionToSelf = false;
			m_AnimatorStateTransition418996.duration = 0.1f;
			m_AnimatorStateTransition418996.exitTime = 0.75f;
			m_AnimatorStateTransition418996.hasExitTime = false;
			m_AnimatorStateTransition418996.hasFixedDuration = true;
			m_AnimatorStateTransition418996.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418996.offset = 0f;
			m_AnimatorStateTransition418996.orderedInterruption = true;
			m_AnimatorStateTransition418996.isExit = false;
			m_AnimatorStateTransition418996.mute = false;
			m_AnimatorStateTransition418996.solo = false;
			m_AnimatorStateTransition418996.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition418996.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition418996.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			m_AnimatorStateTransition418996.AddCondition(AnimatorConditionMode.Equals, 0f, "MovementSetID");
			m_AnimatorStateTransition418996.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var m_AnimatorStateTransition418522 = baseStateMachine0.AddAnyStateTransition(m_DodgeForwardAnimatorState420166);
			m_AnimatorStateTransition418522.canTransitionToSelf = false;
			m_AnimatorStateTransition418522.duration = 0.1f;
			m_AnimatorStateTransition418522.exitTime = 0.75f;
			m_AnimatorStateTransition418522.hasExitTime = false;
			m_AnimatorStateTransition418522.hasFixedDuration = true;
			m_AnimatorStateTransition418522.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418522.offset = 0f;
			m_AnimatorStateTransition418522.orderedInterruption = true;
			m_AnimatorStateTransition418522.isExit = false;
			m_AnimatorStateTransition418522.mute = false;
			m_AnimatorStateTransition418522.solo = false;
			m_AnimatorStateTransition418522.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition418522.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition418522.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			m_AnimatorStateTransition418522.AddCondition(AnimatorConditionMode.Equals, 0f, "MovementSetID");

			var m_AnimatorStateTransition419158 = baseStateMachine0.AddAnyStateTransition(m_DodgeBackwardAnimatorState420238);
			m_AnimatorStateTransition419158.canTransitionToSelf = false;
			m_AnimatorStateTransition419158.duration = 0.1f;
			m_AnimatorStateTransition419158.exitTime = 0.75f;
			m_AnimatorStateTransition419158.hasExitTime = false;
			m_AnimatorStateTransition419158.hasFixedDuration = true;
			m_AnimatorStateTransition419158.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419158.offset = 0f;
			m_AnimatorStateTransition419158.orderedInterruption = true;
			m_AnimatorStateTransition419158.isExit = false;
			m_AnimatorStateTransition419158.mute = false;
			m_AnimatorStateTransition419158.solo = false;
			m_AnimatorStateTransition419158.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition419158.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition419158.AddCondition(AnimatorConditionMode.Equals, 3f, "AbilityIntData");
			m_AnimatorStateTransition419158.AddCondition(AnimatorConditionMode.Equals, 0f, "MovementSetID");

			var m_AnimatorStateTransition418994 = baseStateMachine0.AddAnyStateTransition(m_DodgeRightBackAnimatorState420222);
			m_AnimatorStateTransition418994.canTransitionToSelf = false;
			m_AnimatorStateTransition418994.duration = 0.1f;
			m_AnimatorStateTransition418994.exitTime = 0.75f;
			m_AnimatorStateTransition418994.hasExitTime = false;
			m_AnimatorStateTransition418994.hasFixedDuration = true;
			m_AnimatorStateTransition418994.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418994.offset = 0f;
			m_AnimatorStateTransition418994.orderedInterruption = true;
			m_AnimatorStateTransition418994.isExit = false;
			m_AnimatorStateTransition418994.mute = false;
			m_AnimatorStateTransition418994.solo = false;
			m_AnimatorStateTransition418994.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition418994.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition418994.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			m_AnimatorStateTransition418994.AddCondition(AnimatorConditionMode.Equals, 0f, "MovementSetID");
			m_AnimatorStateTransition418994.AddCondition(AnimatorConditionMode.Less, 0.499f, "LegIndex");

			var m_AnimatorStateTransition419144 = baseStateMachine0.AddAnyStateTransition(m_DodgeLeftBackAnimatorState420228);
			m_AnimatorStateTransition419144.canTransitionToSelf = false;
			m_AnimatorStateTransition419144.duration = 0.1f;
			m_AnimatorStateTransition419144.exitTime = 0.75f;
			m_AnimatorStateTransition419144.hasExitTime = false;
			m_AnimatorStateTransition419144.hasFixedDuration = true;
			m_AnimatorStateTransition419144.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419144.offset = 0f;
			m_AnimatorStateTransition419144.orderedInterruption = true;
			m_AnimatorStateTransition419144.isExit = false;
			m_AnimatorStateTransition419144.mute = false;
			m_AnimatorStateTransition419144.solo = false;
			m_AnimatorStateTransition419144.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition419144.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition419144.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			m_AnimatorStateTransition419144.AddCondition(AnimatorConditionMode.Equals, 0f, "MovementSetID");
			m_AnimatorStateTransition419144.AddCondition(AnimatorConditionMode.Less, 0.499f, "LegIndex");

			var m_AnimatorStateTransition418552 = baseStateMachine0.AddAnyStateTransition(m_BowDodgeBackwardAnimatorState420006);
			m_AnimatorStateTransition418552.canTransitionToSelf = false;
			m_AnimatorStateTransition418552.duration = 0.1f;
			m_AnimatorStateTransition418552.exitTime = 0.75f;
			m_AnimatorStateTransition418552.hasExitTime = false;
			m_AnimatorStateTransition418552.hasFixedDuration = true;
			m_AnimatorStateTransition418552.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418552.offset = 0f;
			m_AnimatorStateTransition418552.orderedInterruption = true;
			m_AnimatorStateTransition418552.isExit = false;
			m_AnimatorStateTransition418552.mute = false;
			m_AnimatorStateTransition418552.solo = false;
			m_AnimatorStateTransition418552.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition418552.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition418552.AddCondition(AnimatorConditionMode.Equals, 3f, "AbilityIntData");
			m_AnimatorStateTransition418552.AddCondition(AnimatorConditionMode.Equals, 2f, "MovementSetID");

			var m_AnimatorStateTransition419544 = baseStateMachine0.AddAnyStateTransition(m_BowDodgeForwardAnimatorState420002);
			m_AnimatorStateTransition419544.canTransitionToSelf = false;
			m_AnimatorStateTransition419544.duration = 0.1f;
			m_AnimatorStateTransition419544.exitTime = 0.75f;
			m_AnimatorStateTransition419544.hasExitTime = false;
			m_AnimatorStateTransition419544.hasFixedDuration = true;
			m_AnimatorStateTransition419544.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419544.offset = 0f;
			m_AnimatorStateTransition419544.orderedInterruption = true;
			m_AnimatorStateTransition419544.isExit = false;
			m_AnimatorStateTransition419544.mute = false;
			m_AnimatorStateTransition419544.solo = false;
			m_AnimatorStateTransition419544.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition419544.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition419544.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			m_AnimatorStateTransition419544.AddCondition(AnimatorConditionMode.Equals, 2f, "MovementSetID");

			var m_AnimatorStateTransition418716 = baseStateMachine0.AddAnyStateTransition(m_BowDodgeRightFrontAnimatorState420156);
			m_AnimatorStateTransition418716.canTransitionToSelf = false;
			m_AnimatorStateTransition418716.duration = 0.1f;
			m_AnimatorStateTransition418716.exitTime = 0.75f;
			m_AnimatorStateTransition418716.hasExitTime = false;
			m_AnimatorStateTransition418716.hasFixedDuration = true;
			m_AnimatorStateTransition418716.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418716.offset = 0f;
			m_AnimatorStateTransition418716.orderedInterruption = true;
			m_AnimatorStateTransition418716.isExit = false;
			m_AnimatorStateTransition418716.mute = false;
			m_AnimatorStateTransition418716.solo = false;
			m_AnimatorStateTransition418716.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition418716.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition418716.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			m_AnimatorStateTransition418716.AddCondition(AnimatorConditionMode.Equals, 2f, "MovementSetID");
			m_AnimatorStateTransition418716.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var m_AnimatorStateTransition419824 = baseStateMachine0.AddAnyStateTransition(m_BowDodgeLeftFrontAnimatorState420202);
			m_AnimatorStateTransition419824.canTransitionToSelf = false;
			m_AnimatorStateTransition419824.duration = 0.1f;
			m_AnimatorStateTransition419824.exitTime = 0.75f;
			m_AnimatorStateTransition419824.hasExitTime = false;
			m_AnimatorStateTransition419824.hasFixedDuration = true;
			m_AnimatorStateTransition419824.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419824.offset = 0f;
			m_AnimatorStateTransition419824.orderedInterruption = true;
			m_AnimatorStateTransition419824.isExit = false;
			m_AnimatorStateTransition419824.mute = false;
			m_AnimatorStateTransition419824.solo = false;
			m_AnimatorStateTransition419824.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition419824.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition419824.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			m_AnimatorStateTransition419824.AddCondition(AnimatorConditionMode.Equals, 2f, "MovementSetID");
			m_AnimatorStateTransition419824.AddCondition(AnimatorConditionMode.Greater, 0.5f, "LegIndex");

			var m_AnimatorStateTransition419974 = baseStateMachine0.AddAnyStateTransition(m_BowDodgeLeftBackAnimatorState420080);
			m_AnimatorStateTransition419974.canTransitionToSelf = false;
			m_AnimatorStateTransition419974.duration = 0.1f;
			m_AnimatorStateTransition419974.exitTime = 0.75f;
			m_AnimatorStateTransition419974.hasExitTime = false;
			m_AnimatorStateTransition419974.hasFixedDuration = true;
			m_AnimatorStateTransition419974.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419974.offset = 0f;
			m_AnimatorStateTransition419974.orderedInterruption = true;
			m_AnimatorStateTransition419974.isExit = false;
			m_AnimatorStateTransition419974.mute = false;
			m_AnimatorStateTransition419974.solo = false;
			m_AnimatorStateTransition419974.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition419974.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition419974.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			m_AnimatorStateTransition419974.AddCondition(AnimatorConditionMode.Equals, 2f, "MovementSetID");
			m_AnimatorStateTransition419974.AddCondition(AnimatorConditionMode.Less, 0.499f, "LegIndex");

			var m_AnimatorStateTransition419334 = baseStateMachine0.AddAnyStateTransition(m_BowDodgeRightBackAnimatorState420176);
			m_AnimatorStateTransition419334.canTransitionToSelf = false;
			m_AnimatorStateTransition419334.duration = 0.1f;
			m_AnimatorStateTransition419334.exitTime = 0.75f;
			m_AnimatorStateTransition419334.hasExitTime = false;
			m_AnimatorStateTransition419334.hasFixedDuration = true;
			m_AnimatorStateTransition419334.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419334.offset = 0f;
			m_AnimatorStateTransition419334.orderedInterruption = true;
			m_AnimatorStateTransition419334.isExit = false;
			m_AnimatorStateTransition419334.mute = false;
			m_AnimatorStateTransition419334.solo = false;
			m_AnimatorStateTransition419334.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition419334.AddCondition(AnimatorConditionMode.Equals, 101f, "AbilityIndex");
			m_AnimatorStateTransition419334.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			m_AnimatorStateTransition419334.AddCondition(AnimatorConditionMode.Equals, 2f, "MovementSetID");
			m_AnimatorStateTransition419334.AddCondition(AnimatorConditionMode.Less, 0.499f, "LegIndex");
		}
	}
}
