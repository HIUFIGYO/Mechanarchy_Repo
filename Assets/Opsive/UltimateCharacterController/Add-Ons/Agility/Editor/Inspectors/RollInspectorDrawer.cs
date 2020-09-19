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
	/// Draws a custom inspector for the Roll Ability.
	/// </summary>
	[InspectorDrawer(typeof(Roll))]
	public class RollInspectorDrawer : AbilityInspectorDrawer
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
			var baseStateMachine1456108954 = animatorController.layers[0].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1456108954.stateMachines.Length; ++j) {
					if (baseStateMachine1456108954.stateMachines[j].stateMachine.name == "Roll") {
						baseStateMachine1456108954.RemoveStateMachine(baseStateMachine1456108954.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var aimRollStrafeLeftAnimationClip23794Path = AssetDatabase.GUIDToAssetPath("ebc53bbaf0a0c1a4cb304d6fcf6d59e0"); 
			var aimRollStrafeLeftAnimationClip23794 = AnimatorBuilder.GetAnimationClip(aimRollStrafeLeftAnimationClip23794Path, "AimRollStrafeLeft");
			var rollStrafeLeftAnimationClip23796Path = AssetDatabase.GUIDToAssetPath("b8637c33bea0507438d6ac9899a42eba"); 
			var rollStrafeLeftAnimationClip23796 = AnimatorBuilder.GetAnimationClip(rollStrafeLeftAnimationClip23796Path, "RollStrafeLeft");
			var rollStrafeRightAnimationClip23798Path = AssetDatabase.GUIDToAssetPath("b8637c33bea0507438d6ac9899a42eba"); 
			var rollStrafeRightAnimationClip23798 = AnimatorBuilder.GetAnimationClip(rollStrafeRightAnimationClip23798Path, "RollStrafeRight");
			var rollAnimationClip23800Path = AssetDatabase.GUIDToAssetPath("80a3c683dd5529f45a234b67ef06e9f9"); 
			var rollAnimationClip23800 = AnimatorBuilder.GetAnimationClip(rollAnimationClip23800Path, "Roll");
			var rollWalkAnimationClip23802Path = AssetDatabase.GUIDToAssetPath("b8637c33bea0507438d6ac9899a42eba"); 
			var rollWalkAnimationClip23802 = AnimatorBuilder.GetAnimationClip(rollWalkAnimationClip23802Path, "RollWalk");
			var rollRunAnimationClip23804Path = AssetDatabase.GUIDToAssetPath("a6ca56273daad044499776330617bbe0"); 
			var rollRunAnimationClip23804 = AnimatorBuilder.GetAnimationClip(rollRunAnimationClip23804Path, "RollRun");
			var aimRollStrafeRightAnimationClip23806Path = AssetDatabase.GUIDToAssetPath("2086f17275bfe1a428abc9e4fd79b9d0"); 
			var aimRollStrafeRightAnimationClip23806 = AnimatorBuilder.GetAnimationClip(aimRollStrafeRightAnimationClip23806Path, "AimRollStrafeRight");
			var rollFallingAnimationClip23808Path = AssetDatabase.GUIDToAssetPath("f58548f03b2a12d4784d3d02009eac46"); 
			var rollFallingAnimationClip23808 = AnimatorBuilder.GetAnimationClip(rollFallingAnimationClip23808Path, "RollFalling");

			// State Machine.
			var rollAnimatorStateMachine22378 = baseStateMachine1456108954.AddStateMachine("Roll", new Vector3(624f, 156f, 0f));

			// States.
			var aimRollLeftAnimatorState21362 = rollAnimatorStateMachine22378.AddState("Aim Roll Left", new Vector3(384f, -132f, 0f));
			aimRollLeftAnimatorState21362.motion = aimRollStrafeLeftAnimationClip23794;
			aimRollLeftAnimatorState21362.cycleOffset = 0f;
			aimRollLeftAnimatorState21362.cycleOffsetParameterActive = false;
			aimRollLeftAnimatorState21362.iKOnFeet = false;
			aimRollLeftAnimatorState21362.mirror = false;
			aimRollLeftAnimatorState21362.mirrorParameterActive = false;
			aimRollLeftAnimatorState21362.speed = 2.75f;
			aimRollLeftAnimatorState21362.speedParameterActive = false;
			aimRollLeftAnimatorState21362.writeDefaultValues = true;

			var rollLeftAnimatorState20846 = rollAnimatorStateMachine22378.AddState("Roll Left", new Vector3(384f, -192f, 0f));
			rollLeftAnimatorState20846.motion = rollStrafeLeftAnimationClip23796;
			rollLeftAnimatorState20846.cycleOffset = 0f;
			rollLeftAnimatorState20846.cycleOffsetParameterActive = false;
			rollLeftAnimatorState20846.iKOnFeet = false;
			rollLeftAnimatorState20846.mirror = false;
			rollLeftAnimatorState20846.mirrorParameterActive = false;
			rollLeftAnimatorState20846.speed = 2.75f;
			rollLeftAnimatorState20846.speedParameterActive = false;
			rollLeftAnimatorState20846.writeDefaultValues = true;

			var rollRightAnimatorState21824 = rollAnimatorStateMachine22378.AddState("Roll Right", new Vector3(384f, -72f, 0f));
			rollRightAnimatorState21824.motion = rollStrafeRightAnimationClip23798;
			rollRightAnimatorState21824.cycleOffset = 0f;
			rollRightAnimatorState21824.cycleOffsetParameterActive = false;
			rollRightAnimatorState21824.iKOnFeet = false;
			rollRightAnimatorState21824.mirror = false;
			rollRightAnimatorState21824.mirrorParameterActive = false;
			rollRightAnimatorState21824.speed = 2.75f;
			rollRightAnimatorState21824.speedParameterActive = false;
			rollRightAnimatorState21824.writeDefaultValues = true;

			var rollAnimatorState22054 = rollAnimatorStateMachine22378.AddState("Roll", new Vector3(384f, 48f, 0f));
			rollAnimatorState22054.motion = rollAnimationClip23800;
			rollAnimatorState22054.cycleOffset = 0f;
			rollAnimatorState22054.cycleOffsetParameterActive = false;
			rollAnimatorState22054.iKOnFeet = false;
			rollAnimatorState22054.mirror = false;
			rollAnimatorState22054.mirrorParameterActive = false;
			rollAnimatorState22054.speed = 2.75f;
			rollAnimatorState22054.speedParameterActive = false;
			rollAnimatorState22054.writeDefaultValues = true;

			var rollWalkAnimatorState21360 = rollAnimatorStateMachine22378.AddState("Roll Walk", new Vector3(384f, 108f, 0f));
			rollWalkAnimatorState21360.motion = rollWalkAnimationClip23802;
			rollWalkAnimatorState21360.cycleOffset = 0f;
			rollWalkAnimatorState21360.cycleOffsetParameterActive = false;
			rollWalkAnimatorState21360.iKOnFeet = false;
			rollWalkAnimatorState21360.mirror = false;
			rollWalkAnimatorState21360.mirrorParameterActive = false;
			rollWalkAnimatorState21360.speed = 2.75f;
			rollWalkAnimatorState21360.speedParameterActive = false;
			rollWalkAnimatorState21360.writeDefaultValues = true;

			var rollRunAnimatorState21502 = rollAnimatorStateMachine22378.AddState("Roll Run", new Vector3(384f, 168f, 0f));
			rollRunAnimatorState21502.motion = rollRunAnimationClip23804;
			rollRunAnimatorState21502.cycleOffset = 0f;
			rollRunAnimatorState21502.cycleOffsetParameterActive = false;
			rollRunAnimatorState21502.iKOnFeet = false;
			rollRunAnimatorState21502.mirror = false;
			rollRunAnimatorState21502.mirrorParameterActive = false;
			rollRunAnimatorState21502.speed = 2.75f;
			rollRunAnimatorState21502.speedParameterActive = false;
			rollRunAnimatorState21502.writeDefaultValues = true;

			var aimRollRightAnimatorState22208 = rollAnimatorStateMachine22378.AddState("Aim Roll Right", new Vector3(384f, -12f, 0f));
			aimRollRightAnimatorState22208.motion = aimRollStrafeRightAnimationClip23806;
			aimRollRightAnimatorState22208.cycleOffset = 0f;
			aimRollRightAnimatorState22208.cycleOffsetParameterActive = false;
			aimRollRightAnimatorState22208.iKOnFeet = false;
			aimRollRightAnimatorState22208.mirror = false;
			aimRollRightAnimatorState22208.mirrorParameterActive = false;
			aimRollRightAnimatorState22208.speed = 2.75f;
			aimRollRightAnimatorState22208.speedParameterActive = false;
			aimRollRightAnimatorState22208.writeDefaultValues = true;

			var fallingRollAnimatorState21110 = rollAnimatorStateMachine22378.AddState("Falling Roll", new Vector3(384f, 228f, 0f));
			fallingRollAnimatorState21110.motion = rollFallingAnimationClip23808;
			fallingRollAnimatorState21110.cycleOffset = 0f;
			fallingRollAnimatorState21110.cycleOffsetParameterActive = false;
			fallingRollAnimatorState21110.iKOnFeet = false;
			fallingRollAnimatorState21110.mirror = false;
			fallingRollAnimatorState21110.mirrorParameterActive = false;
			fallingRollAnimatorState21110.speed = 2.75f;
			fallingRollAnimatorState21110.speedParameterActive = false;
			fallingRollAnimatorState21110.writeDefaultValues = true;

			// State Transitions.
			var animatorStateTransition20016 = aimRollLeftAnimatorState21362.AddExitTransition();
			animatorStateTransition20016.canTransitionToSelf = true;
			animatorStateTransition20016.duration = 0.15f;
			animatorStateTransition20016.exitTime = 0.9158775f;
			animatorStateTransition20016.hasExitTime = false;
			animatorStateTransition20016.hasFixedDuration = true;
			animatorStateTransition20016.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition20016.offset = 0f;
			animatorStateTransition20016.orderedInterruption = true;
			animatorStateTransition20016.isExit = true;
			animatorStateTransition20016.mute = false;
			animatorStateTransition20016.solo = false;
			animatorStateTransition20016.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition16668 = rollLeftAnimatorState20846.AddExitTransition();
			animatorStateTransition16668.canTransitionToSelf = true;
			animatorStateTransition16668.duration = 0.15f;
			animatorStateTransition16668.exitTime = 0.9158775f;
			animatorStateTransition16668.hasExitTime = false;
			animatorStateTransition16668.hasFixedDuration = true;
			animatorStateTransition16668.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition16668.offset = 0f;
			animatorStateTransition16668.orderedInterruption = true;
			animatorStateTransition16668.isExit = true;
			animatorStateTransition16668.mute = false;
			animatorStateTransition16668.solo = false;
			animatorStateTransition16668.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition16006 = rollRightAnimatorState21824.AddExitTransition();
			animatorStateTransition16006.canTransitionToSelf = true;
			animatorStateTransition16006.duration = 0.15f;
			animatorStateTransition16006.exitTime = 0.9158775f;
			animatorStateTransition16006.hasExitTime = false;
			animatorStateTransition16006.hasFixedDuration = true;
			animatorStateTransition16006.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition16006.offset = 0f;
			animatorStateTransition16006.orderedInterruption = true;
			animatorStateTransition16006.isExit = true;
			animatorStateTransition16006.mute = false;
			animatorStateTransition16006.solo = false;
			animatorStateTransition16006.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition16406 = rollAnimatorState22054.AddExitTransition();
			animatorStateTransition16406.canTransitionToSelf = true;
			animatorStateTransition16406.duration = 0.15f;
			animatorStateTransition16406.exitTime = 0.9158775f;
			animatorStateTransition16406.hasExitTime = false;
			animatorStateTransition16406.hasFixedDuration = true;
			animatorStateTransition16406.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition16406.offset = 0f;
			animatorStateTransition16406.orderedInterruption = true;
			animatorStateTransition16406.isExit = true;
			animatorStateTransition16406.mute = false;
			animatorStateTransition16406.solo = false;
			animatorStateTransition16406.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition15918 = rollWalkAnimatorState21360.AddExitTransition();
			animatorStateTransition15918.canTransitionToSelf = true;
			animatorStateTransition15918.duration = 0.15f;
			animatorStateTransition15918.exitTime = 0.9158775f;
			animatorStateTransition15918.hasExitTime = false;
			animatorStateTransition15918.hasFixedDuration = true;
			animatorStateTransition15918.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition15918.offset = 0f;
			animatorStateTransition15918.orderedInterruption = true;
			animatorStateTransition15918.isExit = true;
			animatorStateTransition15918.mute = false;
			animatorStateTransition15918.solo = false;
			animatorStateTransition15918.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition19828 = rollRunAnimatorState21502.AddExitTransition();
			animatorStateTransition19828.canTransitionToSelf = true;
			animatorStateTransition19828.duration = 0.15f;
			animatorStateTransition19828.exitTime = 0.9158775f;
			animatorStateTransition19828.hasExitTime = false;
			animatorStateTransition19828.hasFixedDuration = true;
			animatorStateTransition19828.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition19828.offset = 0f;
			animatorStateTransition19828.orderedInterruption = true;
			animatorStateTransition19828.isExit = true;
			animatorStateTransition19828.mute = false;
			animatorStateTransition19828.solo = false;
			animatorStateTransition19828.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition19476 = aimRollRightAnimatorState22208.AddExitTransition();
			animatorStateTransition19476.canTransitionToSelf = true;
			animatorStateTransition19476.duration = 0.15f;
			animatorStateTransition19476.exitTime = 0.9158775f;
			animatorStateTransition19476.hasExitTime = false;
			animatorStateTransition19476.hasFixedDuration = true;
			animatorStateTransition19476.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition19476.offset = 0f;
			animatorStateTransition19476.orderedInterruption = true;
			animatorStateTransition19476.isExit = true;
			animatorStateTransition19476.mute = false;
			animatorStateTransition19476.solo = false;
			animatorStateTransition19476.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition17922 = fallingRollAnimatorState21110.AddExitTransition();
			animatorStateTransition17922.canTransitionToSelf = true;
			animatorStateTransition17922.duration = 0.15f;
			animatorStateTransition17922.exitTime = 0.9158775f;
			animatorStateTransition17922.hasExitTime = false;
			animatorStateTransition17922.hasFixedDuration = true;
			animatorStateTransition17922.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition17922.offset = 0f;
			animatorStateTransition17922.orderedInterruption = true;
			animatorStateTransition17922.isExit = true;
			animatorStateTransition17922.mute = false;
			animatorStateTransition17922.solo = false;
			animatorStateTransition17922.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			// State Machine Defaults.
			rollAnimatorStateMachine22378.anyStatePosition = new Vector3(50f, 20f, 0f);
			rollAnimatorStateMachine22378.defaultState = rollAnimatorState22054;
			rollAnimatorStateMachine22378.entryPosition = new Vector3(60f, -36f, 0f);
			rollAnimatorStateMachine22378.exitPosition = new Vector3(756f, 24f, 0f);
			rollAnimatorStateMachine22378.parentStateMachinePosition = new Vector3(732f, -48f, 0f);


			// State Machine Transitions.
			var animatorStateTransition20072 = baseStateMachine1456108954.AddAnyStateTransition(aimRollLeftAnimatorState21362);
			animatorStateTransition20072.canTransitionToSelf = false;
			animatorStateTransition20072.duration = 0.05f;
			animatorStateTransition20072.exitTime = 0.75f;
			animatorStateTransition20072.hasExitTime = false;
			animatorStateTransition20072.hasFixedDuration = true;
			animatorStateTransition20072.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition20072.offset = 0.1f;
			animatorStateTransition20072.orderedInterruption = true;
			animatorStateTransition20072.isExit = false;
			animatorStateTransition20072.mute = false;
			animatorStateTransition20072.solo = false;
			animatorStateTransition20072.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition20072.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition20072.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			animatorStateTransition20072.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");

			var animatorStateTransition19190 = baseStateMachine1456108954.AddAnyStateTransition(rollLeftAnimatorState20846);
			animatorStateTransition19190.canTransitionToSelf = false;
			animatorStateTransition19190.duration = 0.05f;
			animatorStateTransition19190.exitTime = 0.75f;
			animatorStateTransition19190.hasExitTime = false;
			animatorStateTransition19190.hasFixedDuration = true;
			animatorStateTransition19190.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition19190.offset = 0.1f;
			animatorStateTransition19190.orderedInterruption = true;
			animatorStateTransition19190.isExit = false;
			animatorStateTransition19190.mute = false;
			animatorStateTransition19190.solo = false;
			animatorStateTransition19190.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition19190.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition19190.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");
			animatorStateTransition19190.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");

			var animatorStateTransition20134 = baseStateMachine1456108954.AddAnyStateTransition(rollRightAnimatorState21824);
			animatorStateTransition20134.canTransitionToSelf = false;
			animatorStateTransition20134.duration = 0.05f;
			animatorStateTransition20134.exitTime = 0.75f;
			animatorStateTransition20134.hasExitTime = false;
			animatorStateTransition20134.hasFixedDuration = true;
			animatorStateTransition20134.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition20134.offset = 0.1f;
			animatorStateTransition20134.orderedInterruption = true;
			animatorStateTransition20134.isExit = false;
			animatorStateTransition20134.mute = false;
			animatorStateTransition20134.solo = false;
			animatorStateTransition20134.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition20134.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition20134.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition20134.AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");

			var animatorStateTransition17924 = baseStateMachine1456108954.AddAnyStateTransition(rollAnimatorState22054);
			animatorStateTransition17924.canTransitionToSelf = false;
			animatorStateTransition17924.duration = 0.05f;
			animatorStateTransition17924.exitTime = 0.75f;
			animatorStateTransition17924.hasExitTime = false;
			animatorStateTransition17924.hasFixedDuration = true;
			animatorStateTransition17924.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition17924.offset = 0.1f;
			animatorStateTransition17924.orderedInterruption = true;
			animatorStateTransition17924.isExit = false;
			animatorStateTransition17924.mute = false;
			animatorStateTransition17924.solo = false;
			animatorStateTransition17924.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition17924.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition17924.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition17924.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var animatorStateTransition18890 = baseStateMachine1456108954.AddAnyStateTransition(rollWalkAnimatorState21360);
			animatorStateTransition18890.canTransitionToSelf = false;
			animatorStateTransition18890.duration = 0.05f;
			animatorStateTransition18890.exitTime = 0.75f;
			animatorStateTransition18890.hasExitTime = false;
			animatorStateTransition18890.hasFixedDuration = true;
			animatorStateTransition18890.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition18890.offset = 0.1f;
			animatorStateTransition18890.orderedInterruption = true;
			animatorStateTransition18890.isExit = false;
			animatorStateTransition18890.mute = false;
			animatorStateTransition18890.solo = false;
			animatorStateTransition18890.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition18890.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition18890.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition18890.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition18890.AddCondition(AnimatorConditionMode.Greater, 0.5f, "Speed");
			animatorStateTransition18890.AddCondition(AnimatorConditionMode.Less, 1.5f, "Speed");

			var animatorStateTransition20268 = baseStateMachine1456108954.AddAnyStateTransition(rollRunAnimatorState21502);
			animatorStateTransition20268.canTransitionToSelf = false;
			animatorStateTransition20268.duration = 0.05f;
			animatorStateTransition20268.exitTime = 0.75f;
			animatorStateTransition20268.hasExitTime = false;
			animatorStateTransition20268.hasFixedDuration = true;
			animatorStateTransition20268.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition20268.offset = 0.1f;
			animatorStateTransition20268.orderedInterruption = true;
			animatorStateTransition20268.isExit = false;
			animatorStateTransition20268.mute = false;
			animatorStateTransition20268.solo = false;
			animatorStateTransition20268.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition20268.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition20268.AddCondition(AnimatorConditionMode.Equals, 2f, "AbilityIntData");
			animatorStateTransition20268.AddCondition(AnimatorConditionMode.If, 0f, "Moving");
			animatorStateTransition20268.AddCondition(AnimatorConditionMode.Greater, 1f, "Speed");

			var animatorStateTransition18444 = baseStateMachine1456108954.AddAnyStateTransition(aimRollRightAnimatorState22208);
			animatorStateTransition18444.canTransitionToSelf = false;
			animatorStateTransition18444.duration = 0.05f;
			animatorStateTransition18444.exitTime = 0.75f;
			animatorStateTransition18444.hasExitTime = false;
			animatorStateTransition18444.hasFixedDuration = true;
			animatorStateTransition18444.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition18444.offset = 0.1f;
			animatorStateTransition18444.orderedInterruption = true;
			animatorStateTransition18444.isExit = false;
			animatorStateTransition18444.mute = false;
			animatorStateTransition18444.solo = false;
			animatorStateTransition18444.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition18444.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition18444.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");
			animatorStateTransition18444.AddCondition(AnimatorConditionMode.If, 0f, "Aiming");

			var animatorStateTransition19266 = baseStateMachine1456108954.AddAnyStateTransition(fallingRollAnimatorState21110);
			animatorStateTransition19266.canTransitionToSelf = false;
			animatorStateTransition19266.duration = 0.05f;
			animatorStateTransition19266.exitTime = 0.75f;
			animatorStateTransition19266.hasExitTime = false;
			animatorStateTransition19266.hasFixedDuration = true;
			animatorStateTransition19266.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition19266.offset = 0.1f;
			animatorStateTransition19266.orderedInterruption = true;
			animatorStateTransition19266.isExit = false;
			animatorStateTransition19266.mute = false;
			animatorStateTransition19266.solo = false;
			animatorStateTransition19266.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			animatorStateTransition19266.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition19266.AddCondition(AnimatorConditionMode.Equals, 3f, "AbilityIntData");

			var baseStateMachine1368618418 = animatorController.layers[5].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1368618418.stateMachines.Length; ++j) {
					if (baseStateMachine1368618418.stateMachines[j].stateMachine.name == "Roll") {
						baseStateMachine1368618418.RemoveStateMachine(baseStateMachine1368618418.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var assaultRifleRollIdleAnimationClip24562Path = AssetDatabase.GUIDToAssetPath("39544c3509240c542b07576a5af1c13c"); 
			var assaultRifleRollIdleAnimationClip24562 = AnimatorBuilder.GetAnimationClip(assaultRifleRollIdleAnimationClip24562Path, "AssaultRifleRollIdle");
			var pistolRollIdleAnimationClip24564Path = AssetDatabase.GUIDToAssetPath("09e38275d81602b489835c6374477408"); 
			var pistolRollIdleAnimationClip24564 = AnimatorBuilder.GetAnimationClip(pistolRollIdleAnimationClip24564Path, "PistolRollIdle");
			var dualPistolRollIdleAnimationClip24566Path = AssetDatabase.GUIDToAssetPath("d828fedde99b6024a8e7e26e17e45386"); 
			var dualPistolRollIdleAnimationClip24566 = AnimatorBuilder.GetAnimationClip(dualPistolRollIdleAnimationClip24566Path, "DualPistolRollIdle");
			var rocketLauncherRollIdleAnimationClip24568Path = AssetDatabase.GUIDToAssetPath("4b2e64e4268ee634a8f5ef226eea2fa7"); 
			var rocketLauncherRollIdleAnimationClip24568 = AnimatorBuilder.GetAnimationClip(rocketLauncherRollIdleAnimationClip24568Path, "RocketLauncherRollIdle");
			var shotgunRollIdleAnimationClip24570Path = AssetDatabase.GUIDToAssetPath("ecea2486194b00448941b70a63f54011"); 
			var shotgunRollIdleAnimationClip24570 = AnimatorBuilder.GetAnimationClip(shotgunRollIdleAnimationClip24570Path, "ShotgunRollIdle");
			var sniperRifleRollIdleAnimationClip24572Path = AssetDatabase.GUIDToAssetPath("39b068db4042ab343a202f0407939fed"); 
			var sniperRifleRollIdleAnimationClip24572 = AnimatorBuilder.GetAnimationClip(sniperRifleRollIdleAnimationClip24572Path, "SniperRifleRollIdle");
			var shieldRollIdleAnimationClip24574Path = AssetDatabase.GUIDToAssetPath("a0f52d3dc5cea6046b13848f8edd2f5c"); 
			var shieldRollIdleAnimationClip24574 = AnimatorBuilder.GetAnimationClip(shieldRollIdleAnimationClip24574Path, "ShieldRollIdle");
			var bowRollIdleAnimationClip24576Path = AssetDatabase.GUIDToAssetPath("a073f0ad43f21244aaca022aef7f88ee"); 
			var bowRollIdleAnimationClip24576 = AnimatorBuilder.GetAnimationClip(bowRollIdleAnimationClip24576Path, "BowRollIdle");

			// State Machine.
			var rollAnimatorStateMachine22338 = baseStateMachine1368618418.AddStateMachine("Roll", new Vector3(852f, 108f, 0f));

			// States.
			var assaultRifleAnimatorState21680 = rollAnimatorStateMachine22338.AddState("Assault Rifle", new Vector3(384f, -48f, 0f));
			assaultRifleAnimatorState21680.motion = assaultRifleRollIdleAnimationClip24562;
			assaultRifleAnimatorState21680.cycleOffset = 0f;
			assaultRifleAnimatorState21680.cycleOffsetParameterActive = false;
			assaultRifleAnimatorState21680.iKOnFeet = false;
			assaultRifleAnimatorState21680.mirror = false;
			assaultRifleAnimatorState21680.mirrorParameterActive = false;
			assaultRifleAnimatorState21680.speed = 1f;
			assaultRifleAnimatorState21680.speedParameterActive = false;
			assaultRifleAnimatorState21680.writeDefaultValues = true;

			var pistolAnimatorState21004 = rollAnimatorStateMachine22338.AddState("Pistol", new Vector3(384f, 132f, 0f));
			pistolAnimatorState21004.motion = pistolRollIdleAnimationClip24564;
			pistolAnimatorState21004.cycleOffset = 0f;
			pistolAnimatorState21004.cycleOffsetParameterActive = false;
			pistolAnimatorState21004.iKOnFeet = false;
			pistolAnimatorState21004.mirror = false;
			pistolAnimatorState21004.mirrorParameterActive = false;
			pistolAnimatorState21004.speed = 1f;
			pistolAnimatorState21004.speedParameterActive = false;
			pistolAnimatorState21004.writeDefaultValues = true;

			var dualPistolAnimatorState21626 = rollAnimatorStateMachine22338.AddState("Dual Pistol", new Vector3(384f, 72f, 0f));
			dualPistolAnimatorState21626.motion = dualPistolRollIdleAnimationClip24566;
			dualPistolAnimatorState21626.cycleOffset = 0f;
			dualPistolAnimatorState21626.cycleOffsetParameterActive = false;
			dualPistolAnimatorState21626.iKOnFeet = false;
			dualPistolAnimatorState21626.mirror = false;
			dualPistolAnimatorState21626.mirrorParameterActive = false;
			dualPistolAnimatorState21626.speed = 1f;
			dualPistolAnimatorState21626.speedParameterActive = false;
			dualPistolAnimatorState21626.writeDefaultValues = true;

			var rocketLauncherAnimatorState21540 = rollAnimatorStateMachine22338.AddState("Rocket Launcher", new Vector3(384f, 192f, 0f));
			rocketLauncherAnimatorState21540.motion = rocketLauncherRollIdleAnimationClip24568;
			rocketLauncherAnimatorState21540.cycleOffset = 0f;
			rocketLauncherAnimatorState21540.cycleOffsetParameterActive = false;
			rocketLauncherAnimatorState21540.iKOnFeet = false;
			rocketLauncherAnimatorState21540.mirror = false;
			rocketLauncherAnimatorState21540.mirrorParameterActive = false;
			rocketLauncherAnimatorState21540.speed = 1f;
			rocketLauncherAnimatorState21540.speedParameterActive = false;
			rocketLauncherAnimatorState21540.writeDefaultValues = true;

			var shotgunAnimatorState21130 = rollAnimatorStateMachine22338.AddState("Shotgun", new Vector3(384f, 312f, 0f));
			shotgunAnimatorState21130.motion = shotgunRollIdleAnimationClip24570;
			shotgunAnimatorState21130.cycleOffset = 0f;
			shotgunAnimatorState21130.cycleOffsetParameterActive = false;
			shotgunAnimatorState21130.iKOnFeet = false;
			shotgunAnimatorState21130.mirror = false;
			shotgunAnimatorState21130.mirrorParameterActive = false;
			shotgunAnimatorState21130.speed = 1f;
			shotgunAnimatorState21130.speedParameterActive = false;
			shotgunAnimatorState21130.writeDefaultValues = true;

			var sniperRifleAnimatorState20914 = rollAnimatorStateMachine22338.AddState("Sniper Rifle", new Vector3(384f, 372f, 0f));
			sniperRifleAnimatorState20914.motion = sniperRifleRollIdleAnimationClip24572;
			sniperRifleAnimatorState20914.cycleOffset = 0f;
			sniperRifleAnimatorState20914.cycleOffsetParameterActive = false;
			sniperRifleAnimatorState20914.iKOnFeet = false;
			sniperRifleAnimatorState20914.mirror = false;
			sniperRifleAnimatorState20914.mirrorParameterActive = false;
			sniperRifleAnimatorState20914.speed = 1f;
			sniperRifleAnimatorState20914.speedParameterActive = false;
			sniperRifleAnimatorState20914.writeDefaultValues = true;

			var shieldAnimatorState20818 = rollAnimatorStateMachine22338.AddState("Shield", new Vector3(384f, 252f, 0f));
			shieldAnimatorState20818.motion = shieldRollIdleAnimationClip24574;
			shieldAnimatorState20818.cycleOffset = 0f;
			shieldAnimatorState20818.cycleOffsetParameterActive = false;
			shieldAnimatorState20818.iKOnFeet = false;
			shieldAnimatorState20818.mirror = false;
			shieldAnimatorState20818.mirrorParameterActive = false;
			shieldAnimatorState20818.speed = 1f;
			shieldAnimatorState20818.speedParameterActive = false;
			shieldAnimatorState20818.writeDefaultValues = true;

			var bowAnimatorState21300 = rollAnimatorStateMachine22338.AddState("Bow", new Vector3(384f, 12f, 0f));
			bowAnimatorState21300.motion = bowRollIdleAnimationClip24576;
			bowAnimatorState21300.cycleOffset = 0f;
			bowAnimatorState21300.cycleOffsetParameterActive = false;
			bowAnimatorState21300.iKOnFeet = false;
			bowAnimatorState21300.mirror = false;
			bowAnimatorState21300.mirrorParameterActive = false;
			bowAnimatorState21300.speed = 1f;
			bowAnimatorState21300.speedParameterActive = false;
			bowAnimatorState21300.writeDefaultValues = true;

			// State Transitions.
			var animatorStateTransition17996 = assaultRifleAnimatorState21680.AddExitTransition();
			animatorStateTransition17996.canTransitionToSelf = true;
			animatorStateTransition17996.duration = 0.15f;
			animatorStateTransition17996.exitTime = 0f;
			animatorStateTransition17996.hasExitTime = false;
			animatorStateTransition17996.hasFixedDuration = true;
			animatorStateTransition17996.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition17996.offset = 0f;
			animatorStateTransition17996.orderedInterruption = true;
			animatorStateTransition17996.isExit = true;
			animatorStateTransition17996.mute = false;
			animatorStateTransition17996.solo = false;
			animatorStateTransition17996.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition18504 = pistolAnimatorState21004.AddExitTransition();
			animatorStateTransition18504.canTransitionToSelf = true;
			animatorStateTransition18504.duration = 0.15f;
			animatorStateTransition18504.exitTime = 0f;
			animatorStateTransition18504.hasExitTime = false;
			animatorStateTransition18504.hasFixedDuration = true;
			animatorStateTransition18504.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition18504.offset = 0f;
			animatorStateTransition18504.orderedInterruption = true;
			animatorStateTransition18504.isExit = true;
			animatorStateTransition18504.mute = false;
			animatorStateTransition18504.solo = false;
			animatorStateTransition18504.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition17342 = dualPistolAnimatorState21626.AddExitTransition();
			animatorStateTransition17342.canTransitionToSelf = true;
			animatorStateTransition17342.duration = 0.15f;
			animatorStateTransition17342.exitTime = 0f;
			animatorStateTransition17342.hasExitTime = false;
			animatorStateTransition17342.hasFixedDuration = true;
			animatorStateTransition17342.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition17342.offset = 0f;
			animatorStateTransition17342.orderedInterruption = true;
			animatorStateTransition17342.isExit = true;
			animatorStateTransition17342.mute = false;
			animatorStateTransition17342.solo = false;
			animatorStateTransition17342.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition20116 = rocketLauncherAnimatorState21540.AddExitTransition();
			animatorStateTransition20116.canTransitionToSelf = true;
			animatorStateTransition20116.duration = 0.15f;
			animatorStateTransition20116.exitTime = 0f;
			animatorStateTransition20116.hasExitTime = false;
			animatorStateTransition20116.hasFixedDuration = true;
			animatorStateTransition20116.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition20116.offset = 0f;
			animatorStateTransition20116.orderedInterruption = true;
			animatorStateTransition20116.isExit = true;
			animatorStateTransition20116.mute = false;
			animatorStateTransition20116.solo = false;
			animatorStateTransition20116.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition18928 = shotgunAnimatorState21130.AddExitTransition();
			animatorStateTransition18928.canTransitionToSelf = true;
			animatorStateTransition18928.duration = 0.15f;
			animatorStateTransition18928.exitTime = 0f;
			animatorStateTransition18928.hasExitTime = false;
			animatorStateTransition18928.hasFixedDuration = true;
			animatorStateTransition18928.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition18928.offset = 0f;
			animatorStateTransition18928.orderedInterruption = true;
			animatorStateTransition18928.isExit = true;
			animatorStateTransition18928.mute = false;
			animatorStateTransition18928.solo = false;
			animatorStateTransition18928.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition20698 = sniperRifleAnimatorState20914.AddExitTransition();
			animatorStateTransition20698.canTransitionToSelf = true;
			animatorStateTransition20698.duration = 0.15f;
			animatorStateTransition20698.exitTime = 0f;
			animatorStateTransition20698.hasExitTime = false;
			animatorStateTransition20698.hasFixedDuration = true;
			animatorStateTransition20698.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition20698.offset = 0f;
			animatorStateTransition20698.orderedInterruption = true;
			animatorStateTransition20698.isExit = true;
			animatorStateTransition20698.mute = false;
			animatorStateTransition20698.solo = false;
			animatorStateTransition20698.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition16812 = shieldAnimatorState20818.AddExitTransition();
			animatorStateTransition16812.canTransitionToSelf = true;
			animatorStateTransition16812.duration = 0.15f;
			animatorStateTransition16812.exitTime = 0f;
			animatorStateTransition16812.hasExitTime = false;
			animatorStateTransition16812.hasFixedDuration = true;
			animatorStateTransition16812.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition16812.offset = 0f;
			animatorStateTransition16812.orderedInterruption = true;
			animatorStateTransition16812.isExit = true;
			animatorStateTransition16812.mute = false;
			animatorStateTransition16812.solo = false;
			animatorStateTransition16812.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition16946 = bowAnimatorState21300.AddExitTransition();
			animatorStateTransition16946.canTransitionToSelf = true;
			animatorStateTransition16946.duration = 0.15f;
			animatorStateTransition16946.exitTime = 0f;
			animatorStateTransition16946.hasExitTime = false;
			animatorStateTransition16946.hasFixedDuration = true;
			animatorStateTransition16946.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition16946.offset = 0f;
			animatorStateTransition16946.orderedInterruption = true;
			animatorStateTransition16946.isExit = true;
			animatorStateTransition16946.mute = false;
			animatorStateTransition16946.solo = false;
			animatorStateTransition16946.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			// State Machine Defaults.
			rollAnimatorStateMachine22338.anyStatePosition = new Vector3(36f, 156f, 0f);
			rollAnimatorStateMachine22338.defaultState = assaultRifleAnimatorState21680;
			rollAnimatorStateMachine22338.entryPosition = new Vector3(36f, 96f, 0f);
			rollAnimatorStateMachine22338.exitPosition = new Vector3(768f, 168f, 0f);
			rollAnimatorStateMachine22338.parentStateMachinePosition = new Vector3(744f, 84f, 0f);


			// State Machine Transitions.
			var animatorStateTransition18716 = baseStateMachine1368618418.AddAnyStateTransition(shieldAnimatorState20818);
			animatorStateTransition18716.canTransitionToSelf = false;
			animatorStateTransition18716.duration = 0.05f;
			animatorStateTransition18716.exitTime = 0.75f;
			animatorStateTransition18716.hasExitTime = false;
			animatorStateTransition18716.hasFixedDuration = true;
			animatorStateTransition18716.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition18716.offset = 0f;
			animatorStateTransition18716.orderedInterruption = true;
			animatorStateTransition18716.isExit = false;
			animatorStateTransition18716.mute = false;
			animatorStateTransition18716.solo = false;
			animatorStateTransition18716.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition18716.AddCondition(AnimatorConditionMode.Equals, 25f, "Slot1ItemID");

			var animatorStateTransition19256 = baseStateMachine1368618418.AddAnyStateTransition(dualPistolAnimatorState21626);
			animatorStateTransition19256.canTransitionToSelf = false;
			animatorStateTransition19256.duration = 0.05f;
			animatorStateTransition19256.exitTime = 0.75f;
			animatorStateTransition19256.hasExitTime = false;
			animatorStateTransition19256.hasFixedDuration = true;
			animatorStateTransition19256.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition19256.offset = 0f;
			animatorStateTransition19256.orderedInterruption = true;
			animatorStateTransition19256.isExit = false;
			animatorStateTransition19256.mute = false;
			animatorStateTransition19256.solo = false;
			animatorStateTransition19256.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition19256.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			animatorStateTransition19256.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot1ItemID");

			var animatorStateTransition15640 = baseStateMachine1368618418.AddAnyStateTransition(pistolAnimatorState21004);
			animatorStateTransition15640.canTransitionToSelf = false;
			animatorStateTransition15640.duration = 0.05f;
			animatorStateTransition15640.exitTime = 0.75f;
			animatorStateTransition15640.hasExitTime = false;
			animatorStateTransition15640.hasFixedDuration = true;
			animatorStateTransition15640.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition15640.offset = 0f;
			animatorStateTransition15640.orderedInterruption = true;
			animatorStateTransition15640.isExit = false;
			animatorStateTransition15640.mute = false;
			animatorStateTransition15640.solo = false;
			animatorStateTransition15640.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition15640.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			animatorStateTransition15640.AddCondition(AnimatorConditionMode.NotEqual, 2f, "Slot1ItemID");

			var animatorStateTransition19000 = baseStateMachine1368618418.AddAnyStateTransition(assaultRifleAnimatorState21680);
			animatorStateTransition19000.canTransitionToSelf = false;
			animatorStateTransition19000.duration = 0.05f;
			animatorStateTransition19000.exitTime = 0.75f;
			animatorStateTransition19000.hasExitTime = false;
			animatorStateTransition19000.hasFixedDuration = true;
			animatorStateTransition19000.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition19000.offset = 0f;
			animatorStateTransition19000.orderedInterruption = true;
			animatorStateTransition19000.isExit = false;
			animatorStateTransition19000.mute = false;
			animatorStateTransition19000.solo = false;
			animatorStateTransition19000.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition19000.AddCondition(AnimatorConditionMode.Equals, 1f, "Slot0ItemID");

			var animatorStateTransition18270 = baseStateMachine1368618418.AddAnyStateTransition(bowAnimatorState21300);
			animatorStateTransition18270.canTransitionToSelf = false;
			animatorStateTransition18270.duration = 0.05f;
			animatorStateTransition18270.exitTime = 0.75f;
			animatorStateTransition18270.hasExitTime = false;
			animatorStateTransition18270.hasFixedDuration = true;
			animatorStateTransition18270.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition18270.offset = 0f;
			animatorStateTransition18270.orderedInterruption = true;
			animatorStateTransition18270.isExit = false;
			animatorStateTransition18270.mute = false;
			animatorStateTransition18270.solo = false;
			animatorStateTransition18270.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition18270.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot1ItemID");

			var animatorStateTransition18118 = baseStateMachine1368618418.AddAnyStateTransition(sniperRifleAnimatorState20914);
			animatorStateTransition18118.canTransitionToSelf = false;
			animatorStateTransition18118.duration = 0.05f;
			animatorStateTransition18118.exitTime = 0.75f;
			animatorStateTransition18118.hasExitTime = false;
			animatorStateTransition18118.hasFixedDuration = true;
			animatorStateTransition18118.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition18118.offset = 0f;
			animatorStateTransition18118.orderedInterruption = true;
			animatorStateTransition18118.isExit = false;
			animatorStateTransition18118.mute = false;
			animatorStateTransition18118.solo = false;
			animatorStateTransition18118.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition18118.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemID");

			var animatorStateTransition18224 = baseStateMachine1368618418.AddAnyStateTransition(shotgunAnimatorState21130);
			animatorStateTransition18224.canTransitionToSelf = false;
			animatorStateTransition18224.duration = 0.05f;
			animatorStateTransition18224.exitTime = 0.75f;
			animatorStateTransition18224.hasExitTime = false;
			animatorStateTransition18224.hasFixedDuration = true;
			animatorStateTransition18224.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition18224.offset = 0f;
			animatorStateTransition18224.orderedInterruption = true;
			animatorStateTransition18224.isExit = false;
			animatorStateTransition18224.mute = false;
			animatorStateTransition18224.solo = false;
			animatorStateTransition18224.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition18224.AddCondition(AnimatorConditionMode.Equals, 3f, "Slot0ItemID");

			var animatorStateTransition20278 = baseStateMachine1368618418.AddAnyStateTransition(rocketLauncherAnimatorState21540);
			animatorStateTransition20278.canTransitionToSelf = false;
			animatorStateTransition20278.duration = 0.05f;
			animatorStateTransition20278.exitTime = 0.75f;
			animatorStateTransition20278.hasExitTime = false;
			animatorStateTransition20278.hasFixedDuration = true;
			animatorStateTransition20278.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition20278.offset = 0f;
			animatorStateTransition20278.orderedInterruption = true;
			animatorStateTransition20278.isExit = false;
			animatorStateTransition20278.mute = false;
			animatorStateTransition20278.solo = false;
			animatorStateTransition20278.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition20278.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemID");

			var baseStateMachine1395880976 = animatorController.layers[6].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine1395880976.stateMachines.Length; ++j) {
					if (baseStateMachine1395880976.stateMachines[j].stateMachine.name == "Roll") {
						baseStateMachine1395880976.RemoveStateMachine(baseStateMachine1395880976.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var swordRollIdleAnimationClip24602Path = AssetDatabase.GUIDToAssetPath("0e24b81f894df92458c8e8a5588622de"); 
			var swordRollIdleAnimationClip24602 = AnimatorBuilder.GetAnimationClip(swordRollIdleAnimationClip24602Path, "SwordRollIdle");
			var katanaRollIdleAnimationClip24604Path = AssetDatabase.GUIDToAssetPath("e9734da6e3b579041b65e31fa14305f9"); 
			var katanaRollIdleAnimationClip24604 = AnimatorBuilder.GetAnimationClip(katanaRollIdleAnimationClip24604Path, "KatanaRollIdle");
			var knifeRollIdleAnimationClip24606Path = AssetDatabase.GUIDToAssetPath("c7bccd5ba3087d24ab9b21627c71d781"); 
			var knifeRollIdleAnimationClip24606 = AnimatorBuilder.GetAnimationClip(knifeRollIdleAnimationClip24606Path, "KnifeRollIdle");

			// State Machine.
			var rollAnimatorStateMachine22240 = baseStateMachine1395880976.AddStateMachine("Roll", new Vector3(852f, 60f, 0f));

			// States.
			var assaultRifleAnimatorState21092 = rollAnimatorStateMachine22240.AddState("Assault Rifle", new Vector3(384f, -228f, 0f));
			assaultRifleAnimatorState21092.motion = assaultRifleRollIdleAnimationClip24562;
			assaultRifleAnimatorState21092.cycleOffset = 0f;
			assaultRifleAnimatorState21092.cycleOffsetParameterActive = false;
			assaultRifleAnimatorState21092.iKOnFeet = false;
			assaultRifleAnimatorState21092.mirror = false;
			assaultRifleAnimatorState21092.mirrorParameterActive = false;
			assaultRifleAnimatorState21092.speed = 1f;
			assaultRifleAnimatorState21092.speedParameterActive = false;
			assaultRifleAnimatorState21092.writeDefaultValues = true;

			var sniperRifleAnimatorState21764 = rollAnimatorStateMachine22240.AddState("Sniper Rifle", new Vector3(384f, 252f, 0f));
			sniperRifleAnimatorState21764.motion = sniperRifleRollIdleAnimationClip24572;
			sniperRifleAnimatorState21764.cycleOffset = 0f;
			sniperRifleAnimatorState21764.cycleOffsetParameterActive = false;
			sniperRifleAnimatorState21764.iKOnFeet = false;
			sniperRifleAnimatorState21764.mirror = false;
			sniperRifleAnimatorState21764.mirrorParameterActive = false;
			sniperRifleAnimatorState21764.speed = 1f;
			sniperRifleAnimatorState21764.speedParameterActive = false;
			sniperRifleAnimatorState21764.writeDefaultValues = true;

			var shotgunAnimatorState21006 = rollAnimatorStateMachine22240.AddState("Shotgun", new Vector3(384f, 192f, 0f));
			shotgunAnimatorState21006.motion = shotgunRollIdleAnimationClip24570;
			shotgunAnimatorState21006.cycleOffset = 0f;
			shotgunAnimatorState21006.cycleOffsetParameterActive = false;
			shotgunAnimatorState21006.iKOnFeet = false;
			shotgunAnimatorState21006.mirror = false;
			shotgunAnimatorState21006.mirrorParameterActive = false;
			shotgunAnimatorState21006.speed = 1f;
			shotgunAnimatorState21006.speedParameterActive = false;
			shotgunAnimatorState21006.writeDefaultValues = true;

			var rocketLauncherAnimatorState20830 = rollAnimatorStateMachine22240.AddState("Rocket Launcher", new Vector3(384f, 132f, 0f));
			rocketLauncherAnimatorState20830.motion = rocketLauncherRollIdleAnimationClip24568;
			rocketLauncherAnimatorState20830.cycleOffset = 0f;
			rocketLauncherAnimatorState20830.cycleOffsetParameterActive = false;
			rocketLauncherAnimatorState20830.iKOnFeet = false;
			rocketLauncherAnimatorState20830.mirror = false;
			rocketLauncherAnimatorState20830.mirrorParameterActive = false;
			rocketLauncherAnimatorState20830.speed = 1f;
			rocketLauncherAnimatorState20830.speedParameterActive = false;
			rocketLauncherAnimatorState20830.writeDefaultValues = true;

			var dualPistolAnimatorState21344 = rollAnimatorStateMachine22240.AddState("Dual Pistol", new Vector3(384f, -108f, 0f));
			dualPistolAnimatorState21344.motion = dualPistolRollIdleAnimationClip24566;
			dualPistolAnimatorState21344.cycleOffset = 0f;
			dualPistolAnimatorState21344.cycleOffsetParameterActive = false;
			dualPistolAnimatorState21344.iKOnFeet = false;
			dualPistolAnimatorState21344.mirror = false;
			dualPistolAnimatorState21344.mirrorParameterActive = false;
			dualPistolAnimatorState21344.speed = 1f;
			dualPistolAnimatorState21344.speedParameterActive = false;
			dualPistolAnimatorState21344.writeDefaultValues = true;

			var pistolAnimatorState21376 = rollAnimatorStateMachine22240.AddState("Pistol", new Vector3(384f, 72f, 0f));
			pistolAnimatorState21376.motion = pistolRollIdleAnimationClip24564;
			pistolAnimatorState21376.cycleOffset = 0f;
			pistolAnimatorState21376.cycleOffsetParameterActive = false;
			pistolAnimatorState21376.iKOnFeet = false;
			pistolAnimatorState21376.mirror = false;
			pistolAnimatorState21376.mirrorParameterActive = false;
			pistolAnimatorState21376.speed = 1f;
			pistolAnimatorState21376.speedParameterActive = false;
			pistolAnimatorState21376.writeDefaultValues = true;

			var swordAnimatorState21772 = rollAnimatorStateMachine22240.AddState("Sword", new Vector3(384f, 312f, 0f));
			swordAnimatorState21772.motion = swordRollIdleAnimationClip24602;
			swordAnimatorState21772.cycleOffset = 0f;
			swordAnimatorState21772.cycleOffsetParameterActive = false;
			swordAnimatorState21772.iKOnFeet = false;
			swordAnimatorState21772.mirror = false;
			swordAnimatorState21772.mirrorParameterActive = false;
			swordAnimatorState21772.speed = 1f;
			swordAnimatorState21772.speedParameterActive = false;
			swordAnimatorState21772.writeDefaultValues = true;

			var katanaAnimatorState20870 = rollAnimatorStateMachine22240.AddState("Katana", new Vector3(384f, -48f, 0f));
			katanaAnimatorState20870.motion = katanaRollIdleAnimationClip24604;
			katanaAnimatorState20870.cycleOffset = 0f;
			katanaAnimatorState20870.cycleOffsetParameterActive = false;
			katanaAnimatorState20870.iKOnFeet = false;
			katanaAnimatorState20870.mirror = false;
			katanaAnimatorState20870.mirrorParameterActive = false;
			katanaAnimatorState20870.speed = 1f;
			katanaAnimatorState20870.speedParameterActive = false;
			katanaAnimatorState20870.writeDefaultValues = true;

			var bowAnimatorState21108 = rollAnimatorStateMachine22240.AddState("Bow", new Vector3(384f, -168f, 0f));
			bowAnimatorState21108.motion = bowRollIdleAnimationClip24576;
			bowAnimatorState21108.cycleOffset = 0f;
			bowAnimatorState21108.cycleOffsetParameterActive = false;
			bowAnimatorState21108.iKOnFeet = false;
			bowAnimatorState21108.mirror = false;
			bowAnimatorState21108.mirrorParameterActive = false;
			bowAnimatorState21108.speed = 1f;
			bowAnimatorState21108.speedParameterActive = false;
			bowAnimatorState21108.writeDefaultValues = true;

			var knifeAnimatorState22088 = rollAnimatorStateMachine22240.AddState("Knife", new Vector3(384f, 12f, 0f));
			knifeAnimatorState22088.motion = knifeRollIdleAnimationClip24606;
			knifeAnimatorState22088.cycleOffset = 0f;
			knifeAnimatorState22088.cycleOffsetParameterActive = false;
			knifeAnimatorState22088.iKOnFeet = false;
			knifeAnimatorState22088.mirror = false;
			knifeAnimatorState22088.mirrorParameterActive = false;
			knifeAnimatorState22088.speed = 1f;
			knifeAnimatorState22088.speedParameterActive = false;
			knifeAnimatorState22088.writeDefaultValues = true;

			// State Transitions.
			var animatorStateTransition17416 = assaultRifleAnimatorState21092.AddExitTransition();
			animatorStateTransition17416.canTransitionToSelf = true;
			animatorStateTransition17416.duration = 0.15f;
			animatorStateTransition17416.exitTime = 0f;
			animatorStateTransition17416.hasExitTime = false;
			animatorStateTransition17416.hasFixedDuration = true;
			animatorStateTransition17416.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition17416.offset = 0f;
			animatorStateTransition17416.orderedInterruption = true;
			animatorStateTransition17416.isExit = true;
			animatorStateTransition17416.mute = false;
			animatorStateTransition17416.solo = false;
			animatorStateTransition17416.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition18100 = sniperRifleAnimatorState21764.AddExitTransition();
			animatorStateTransition18100.canTransitionToSelf = true;
			animatorStateTransition18100.duration = 0.15f;
			animatorStateTransition18100.exitTime = 0f;
			animatorStateTransition18100.hasExitTime = false;
			animatorStateTransition18100.hasFixedDuration = true;
			animatorStateTransition18100.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition18100.offset = 0f;
			animatorStateTransition18100.orderedInterruption = true;
			animatorStateTransition18100.isExit = true;
			animatorStateTransition18100.mute = false;
			animatorStateTransition18100.solo = false;
			animatorStateTransition18100.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition17394 = shotgunAnimatorState21006.AddExitTransition();
			animatorStateTransition17394.canTransitionToSelf = true;
			animatorStateTransition17394.duration = 0.15f;
			animatorStateTransition17394.exitTime = 0f;
			animatorStateTransition17394.hasExitTime = false;
			animatorStateTransition17394.hasFixedDuration = true;
			animatorStateTransition17394.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition17394.offset = 0f;
			animatorStateTransition17394.orderedInterruption = true;
			animatorStateTransition17394.isExit = true;
			animatorStateTransition17394.mute = false;
			animatorStateTransition17394.solo = false;
			animatorStateTransition17394.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition17690 = rocketLauncherAnimatorState20830.AddExitTransition();
			animatorStateTransition17690.canTransitionToSelf = true;
			animatorStateTransition17690.duration = 0.15f;
			animatorStateTransition17690.exitTime = 0f;
			animatorStateTransition17690.hasExitTime = false;
			animatorStateTransition17690.hasFixedDuration = true;
			animatorStateTransition17690.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition17690.offset = 0f;
			animatorStateTransition17690.orderedInterruption = true;
			animatorStateTransition17690.isExit = true;
			animatorStateTransition17690.mute = false;
			animatorStateTransition17690.solo = false;
			animatorStateTransition17690.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition16330 = dualPistolAnimatorState21344.AddExitTransition();
			animatorStateTransition16330.canTransitionToSelf = true;
			animatorStateTransition16330.duration = 0.15f;
			animatorStateTransition16330.exitTime = 0f;
			animatorStateTransition16330.hasExitTime = false;
			animatorStateTransition16330.hasFixedDuration = true;
			animatorStateTransition16330.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition16330.offset = 0f;
			animatorStateTransition16330.orderedInterruption = true;
			animatorStateTransition16330.isExit = true;
			animatorStateTransition16330.mute = false;
			animatorStateTransition16330.solo = false;
			animatorStateTransition16330.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition19864 = pistolAnimatorState21376.AddExitTransition();
			animatorStateTransition19864.canTransitionToSelf = true;
			animatorStateTransition19864.duration = 0.15f;
			animatorStateTransition19864.exitTime = 0f;
			animatorStateTransition19864.hasExitTime = false;
			animatorStateTransition19864.hasFixedDuration = true;
			animatorStateTransition19864.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition19864.offset = 0f;
			animatorStateTransition19864.orderedInterruption = true;
			animatorStateTransition19864.isExit = true;
			animatorStateTransition19864.mute = false;
			animatorStateTransition19864.solo = false;
			animatorStateTransition19864.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition15906 = swordAnimatorState21772.AddExitTransition();
			animatorStateTransition15906.canTransitionToSelf = true;
			animatorStateTransition15906.duration = 0.15f;
			animatorStateTransition15906.exitTime = 0f;
			animatorStateTransition15906.hasExitTime = false;
			animatorStateTransition15906.hasFixedDuration = true;
			animatorStateTransition15906.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition15906.offset = 0f;
			animatorStateTransition15906.orderedInterruption = false;
			animatorStateTransition15906.isExit = true;
			animatorStateTransition15906.mute = false;
			animatorStateTransition15906.solo = false;
			animatorStateTransition15906.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition18988 = katanaAnimatorState20870.AddExitTransition();
			animatorStateTransition18988.canTransitionToSelf = true;
			animatorStateTransition18988.duration = 15f;
			animatorStateTransition18988.exitTime = 0f;
			animatorStateTransition18988.hasExitTime = false;
			animatorStateTransition18988.hasFixedDuration = true;
			animatorStateTransition18988.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition18988.offset = 0f;
			animatorStateTransition18988.orderedInterruption = true;
			animatorStateTransition18988.isExit = true;
			animatorStateTransition18988.mute = false;
			animatorStateTransition18988.solo = false;
			animatorStateTransition18988.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition19126 = bowAnimatorState21108.AddExitTransition();
			animatorStateTransition19126.canTransitionToSelf = true;
			animatorStateTransition19126.duration = 0.15f;
			animatorStateTransition19126.exitTime = 0f;
			animatorStateTransition19126.hasExitTime = false;
			animatorStateTransition19126.hasFixedDuration = true;
			animatorStateTransition19126.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition19126.offset = 0f;
			animatorStateTransition19126.orderedInterruption = true;
			animatorStateTransition19126.isExit = true;
			animatorStateTransition19126.mute = false;
			animatorStateTransition19126.solo = false;
			animatorStateTransition19126.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			var animatorStateTransition19412 = knifeAnimatorState22088.AddExitTransition();
			animatorStateTransition19412.canTransitionToSelf = true;
			animatorStateTransition19412.duration = 0.15f;
			animatorStateTransition19412.exitTime = 0f;
			animatorStateTransition19412.hasExitTime = false;
			animatorStateTransition19412.hasFixedDuration = true;
			animatorStateTransition19412.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition19412.offset = 0f;
			animatorStateTransition19412.orderedInterruption = true;
			animatorStateTransition19412.isExit = true;
			animatorStateTransition19412.mute = false;
			animatorStateTransition19412.solo = false;
			animatorStateTransition19412.AddCondition(AnimatorConditionMode.NotEqual, 102f, "AbilityIndex");

			// State Machine Defaults.
			rollAnimatorStateMachine22240.anyStatePosition = new Vector3(48f, 48f, 0f);
			rollAnimatorStateMachine22240.defaultState = assaultRifleAnimatorState21092;
			rollAnimatorStateMachine22240.entryPosition = new Vector3(48f, 0f, 0f);
			rollAnimatorStateMachine22240.exitPosition = new Vector3(768f, 36f, 0f);
			rollAnimatorStateMachine22240.parentStateMachinePosition = new Vector3(744f, -48f, 0f);


			// State Machine Transitions.
			var animatorStateTransition19340 = baseStateMachine1395880976.AddAnyStateTransition(swordAnimatorState21772);
			animatorStateTransition19340.canTransitionToSelf = false;
			animatorStateTransition19340.duration = 0.05f;
			animatorStateTransition19340.exitTime = 0.75f;
			animatorStateTransition19340.hasExitTime = false;
			animatorStateTransition19340.hasFixedDuration = true;
			animatorStateTransition19340.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition19340.offset = 0f;
			animatorStateTransition19340.orderedInterruption = true;
			animatorStateTransition19340.isExit = false;
			animatorStateTransition19340.mute = false;
			animatorStateTransition19340.solo = false;
			animatorStateTransition19340.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition19340.AddCondition(AnimatorConditionMode.Equals, 22f, "Slot0ItemID");

			var animatorStateTransition19466 = baseStateMachine1395880976.AddAnyStateTransition(knifeAnimatorState22088);
			animatorStateTransition19466.canTransitionToSelf = false;
			animatorStateTransition19466.duration = 0.05f;
			animatorStateTransition19466.exitTime = 0.75f;
			animatorStateTransition19466.hasExitTime = false;
			animatorStateTransition19466.hasFixedDuration = true;
			animatorStateTransition19466.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition19466.offset = 0f;
			animatorStateTransition19466.orderedInterruption = true;
			animatorStateTransition19466.isExit = false;
			animatorStateTransition19466.mute = false;
			animatorStateTransition19466.solo = false;
			animatorStateTransition19466.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition19466.AddCondition(AnimatorConditionMode.Equals, 23f, "Slot0ItemID");

			var animatorStateTransition20468 = baseStateMachine1395880976.AddAnyStateTransition(katanaAnimatorState20870);
			animatorStateTransition20468.canTransitionToSelf = false;
			animatorStateTransition20468.duration = 0.05f;
			animatorStateTransition20468.exitTime = 0.75f;
			animatorStateTransition20468.hasExitTime = false;
			animatorStateTransition20468.hasFixedDuration = true;
			animatorStateTransition20468.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition20468.offset = 0f;
			animatorStateTransition20468.orderedInterruption = true;
			animatorStateTransition20468.isExit = false;
			animatorStateTransition20468.mute = false;
			animatorStateTransition20468.solo = false;
			animatorStateTransition20468.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition20468.AddCondition(AnimatorConditionMode.Equals, 24f, "Slot0ItemID");

			var animatorStateTransition16558 = baseStateMachine1395880976.AddAnyStateTransition(bowAnimatorState21108);
			animatorStateTransition16558.canTransitionToSelf = false;
			animatorStateTransition16558.duration = 0.05f;
			animatorStateTransition16558.exitTime = 0.75f;
			animatorStateTransition16558.hasExitTime = false;
			animatorStateTransition16558.hasFixedDuration = true;
			animatorStateTransition16558.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition16558.offset = 0f;
			animatorStateTransition16558.orderedInterruption = true;
			animatorStateTransition16558.isExit = false;
			animatorStateTransition16558.mute = false;
			animatorStateTransition16558.solo = false;
			animatorStateTransition16558.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition16558.AddCondition(AnimatorConditionMode.Equals, 4f, "Slot1ItemID");

			var animatorStateTransition19792 = baseStateMachine1395880976.AddAnyStateTransition(dualPistolAnimatorState21344);
			animatorStateTransition19792.canTransitionToSelf = false;
			animatorStateTransition19792.duration = 0.05f;
			animatorStateTransition19792.exitTime = 0.75f;
			animatorStateTransition19792.hasExitTime = false;
			animatorStateTransition19792.hasFixedDuration = true;
			animatorStateTransition19792.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition19792.offset = 0f;
			animatorStateTransition19792.orderedInterruption = true;
			animatorStateTransition19792.isExit = false;
			animatorStateTransition19792.mute = false;
			animatorStateTransition19792.solo = false;
			animatorStateTransition19792.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition19792.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			animatorStateTransition19792.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot1ItemID");

			var animatorStateTransition16010 = baseStateMachine1395880976.AddAnyStateTransition(shotgunAnimatorState21006);
			animatorStateTransition16010.canTransitionToSelf = false;
			animatorStateTransition16010.duration = 0.05f;
			animatorStateTransition16010.exitTime = 0.75f;
			animatorStateTransition16010.hasExitTime = false;
			animatorStateTransition16010.hasFixedDuration = true;
			animatorStateTransition16010.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition16010.offset = 0f;
			animatorStateTransition16010.orderedInterruption = true;
			animatorStateTransition16010.isExit = false;
			animatorStateTransition16010.mute = false;
			animatorStateTransition16010.solo = false;
			animatorStateTransition16010.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition16010.AddCondition(AnimatorConditionMode.Equals, 3f, "Slot0ItemID");

			var animatorStateTransition18894 = baseStateMachine1395880976.AddAnyStateTransition(pistolAnimatorState21376);
			animatorStateTransition18894.canTransitionToSelf = false;
			animatorStateTransition18894.duration = 0.05f;
			animatorStateTransition18894.exitTime = 0.75f;
			animatorStateTransition18894.hasExitTime = false;
			animatorStateTransition18894.hasFixedDuration = true;
			animatorStateTransition18894.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition18894.offset = 0f;
			animatorStateTransition18894.orderedInterruption = true;
			animatorStateTransition18894.isExit = false;
			animatorStateTransition18894.mute = false;
			animatorStateTransition18894.solo = false;
			animatorStateTransition18894.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition18894.AddCondition(AnimatorConditionMode.Equals, 2f, "Slot0ItemID");
			animatorStateTransition18894.AddCondition(AnimatorConditionMode.NotEqual, 2f, "Slot1ItemID");

			var animatorStateTransition17534 = baseStateMachine1395880976.AddAnyStateTransition(rocketLauncherAnimatorState20830);
			animatorStateTransition17534.canTransitionToSelf = false;
			animatorStateTransition17534.duration = 0.05f;
			animatorStateTransition17534.exitTime = 0.75f;
			animatorStateTransition17534.hasExitTime = false;
			animatorStateTransition17534.hasFixedDuration = true;
			animatorStateTransition17534.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition17534.offset = 0f;
			animatorStateTransition17534.orderedInterruption = true;
			animatorStateTransition17534.isExit = false;
			animatorStateTransition17534.mute = false;
			animatorStateTransition17534.solo = false;
			animatorStateTransition17534.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition17534.AddCondition(AnimatorConditionMode.Equals, 6f, "Slot0ItemID");

			var animatorStateTransition16156 = baseStateMachine1395880976.AddAnyStateTransition(assaultRifleAnimatorState21092);
			animatorStateTransition16156.canTransitionToSelf = false;
			animatorStateTransition16156.duration = 0.05f;
			animatorStateTransition16156.exitTime = 0.75f;
			animatorStateTransition16156.hasExitTime = false;
			animatorStateTransition16156.hasFixedDuration = true;
			animatorStateTransition16156.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition16156.offset = 0f;
			animatorStateTransition16156.orderedInterruption = true;
			animatorStateTransition16156.isExit = false;
			animatorStateTransition16156.mute = false;
			animatorStateTransition16156.solo = false;
			animatorStateTransition16156.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition16156.AddCondition(AnimatorConditionMode.Equals, 1f, "Slot0ItemID");

			var animatorStateTransition15844 = baseStateMachine1395880976.AddAnyStateTransition(sniperRifleAnimatorState21764);
			animatorStateTransition15844.canTransitionToSelf = false;
			animatorStateTransition15844.duration = 0.05f;
			animatorStateTransition15844.exitTime = 0.75f;
			animatorStateTransition15844.hasExitTime = false;
			animatorStateTransition15844.hasFixedDuration = true;
			animatorStateTransition15844.interruptionSource = TransitionInterruptionSource.None;
			animatorStateTransition15844.offset = 0f;
			animatorStateTransition15844.orderedInterruption = true;
			animatorStateTransition15844.isExit = false;
			animatorStateTransition15844.mute = false;
			animatorStateTransition15844.solo = false;
			animatorStateTransition15844.AddCondition(AnimatorConditionMode.Equals, 102f, "AbilityIndex");
			animatorStateTransition15844.AddCondition(AnimatorConditionMode.Equals, 5f, "Slot0ItemID");
		}
	}
}
