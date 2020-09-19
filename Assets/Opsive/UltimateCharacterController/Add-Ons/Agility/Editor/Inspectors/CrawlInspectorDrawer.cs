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
	/// Draws a custom inspector for the Crawl Ability.
	/// </summary>
	[InspectorDrawer(typeof(Crawl))]
	public class CrawlInspectorDrawer : AbilityInspectorDrawer
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
			var baseStateMachine12 = animatorController.layers[12].stateMachine;

			// The state machine should start fresh.
			for (int i = 0; i < animatorController.layers.Length; ++i) {
				for (int j = 0; j < baseStateMachine12.stateMachines.Length; ++j) {
					if (baseStateMachine12.stateMachines[j].stateMachine.name == "Crawl") {
						baseStateMachine12.RemoveStateMachine(baseStateMachine12.stateMachines[j].stateMachine);
						break;
					}
				}
			}

			// AnimationClip references.
			var m_CrawlBwdTurnLeftAnimationClip21644Path = AssetDatabase.GUIDToAssetPath("75b8972d94de91d4598aa090536b8daf"); 
			var m_CrawlBwdTurnLeftAnimationClip21644 = AnimatorBuilder.GetAnimationClip(m_CrawlBwdTurnLeftAnimationClip21644Path, "CrawlBwdTurnLeft");
			var m_CrawlBwdAnimationClip18720Path = AssetDatabase.GUIDToAssetPath("e66f1ee8858e9694cbd519fd40d37b71"); 
			var m_CrawlBwdAnimationClip18720 = AnimatorBuilder.GetAnimationClip(m_CrawlBwdAnimationClip18720Path, "CrawlBwd");
			var m_CrawlBwdTurnRightAnimationClip21646Path = AssetDatabase.GUIDToAssetPath("75b8972d94de91d4598aa090536b8daf"); 
			var m_CrawlBwdTurnRightAnimationClip21646 = AnimatorBuilder.GetAnimationClip(m_CrawlBwdTurnRightAnimationClip21646Path, "CrawlBwdTurnRight");
			var m_CrawlStrafeAnimationClip15706Path = AssetDatabase.GUIDToAssetPath("416047b55078be24a9e0531434953979"); 
			var m_CrawlStrafeAnimationClip15706 = AnimatorBuilder.GetAnimationClip(m_CrawlStrafeAnimationClip15706Path, "CrawlStrafe");
			var m_CrawlIdleAnimationClip17190Path = AssetDatabase.GUIDToAssetPath("dad2b6b732153c743bc5764038943df6"); 
			var m_CrawlIdleAnimationClip17190 = AnimatorBuilder.GetAnimationClip(m_CrawlIdleAnimationClip17190Path, "CrawlIdle");
			var m_CrawlFwdTurnLeftAnimationClip21648Path = AssetDatabase.GUIDToAssetPath("75b8972d94de91d4598aa090536b8daf"); 
			var m_CrawlFwdTurnLeftAnimationClip21648 = AnimatorBuilder.GetAnimationClip(m_CrawlFwdTurnLeftAnimationClip21648Path, "CrawlFwdTurnLeft");
			var m_CrawlFwdAnimationClip12546Path = AssetDatabase.GUIDToAssetPath("40930071f4f826547a10efb4ca391bd3"); 
			var m_CrawlFwdAnimationClip12546 = AnimatorBuilder.GetAnimationClip(m_CrawlFwdAnimationClip12546Path, "CrawlFwd");
			var m_CrawlFwdTurnRightAnimationClip21650Path = AssetDatabase.GUIDToAssetPath("75b8972d94de91d4598aa090536b8daf"); 
			var m_CrawlFwdTurnRightAnimationClip21650 = AnimatorBuilder.GetAnimationClip(m_CrawlFwdTurnRightAnimationClip21650Path, "CrawlFwdTurnRight");
			var m_CrawlStartAnimationClip19134Path = AssetDatabase.GUIDToAssetPath("87de1b796b9f8184ab60676491a00064"); 
			var m_CrawlStartAnimationClip19134 = AnimatorBuilder.GetAnimationClip(m_CrawlStartAnimationClip19134Path, "CrawlStart");
			var m_CrawlCrouchStartAnimationClip23068Path = AssetDatabase.GUIDToAssetPath("d1b7e9ce6c89fc64581d452313b5d25b"); 
			var m_CrawlCrouchStartAnimationClip23068 = AnimatorBuilder.GetAnimationClip(m_CrawlCrouchStartAnimationClip23068Path, "CrawlCrouchStart");
			var m_CrawlStopAnimationClip13022Path = AssetDatabase.GUIDToAssetPath("88d87302bce822749814fdaca20ed08d"); 
			var m_CrawlStopAnimationClip13022 = AnimatorBuilder.GetAnimationClip(m_CrawlStopAnimationClip13022Path, "CrawlStop");
			var m_CrawlCrouchStopAnimationClip13624Path = AssetDatabase.GUIDToAssetPath("dd9fead20f0e0914b9cbb9b4edcfb7d3"); 
			var m_CrawlCrouchStopAnimationClip13624 = AnimatorBuilder.GetAnimationClip(m_CrawlCrouchStopAnimationClip13624Path, "CrawlCrouchStop");
			var m_CrawlIdleTurnAnimationClip16312Path = AssetDatabase.GUIDToAssetPath("822d43966b2a09948b0887e36a4749ac"); 
			var m_CrawlIdleTurnAnimationClip16312 = AnimatorBuilder.GetAnimationClip(m_CrawlIdleTurnAnimationClip16312Path, "CrawlIdleTurn");

			// State Machine.
			var m_CrawlAnimatorStateMachine420360 = baseStateMachine12.AddStateMachine("Crawl", new Vector3(624f, 156f, 0f));

			// States.
			var m_CrawlMovementAnimatorState420152 = m_CrawlAnimatorStateMachine420360.AddState("Crawl Movement", new Vector3(624f, 36f, 0f));
			var m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096 = new BlendTree();
			AssetDatabase.AddObjectToAsset(m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096, animatorController);
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096.hideFlags = HideFlags.HideInHierarchy;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096.blendParameter = "HorizontalMovement";
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096.blendParameterY = "ForwardMovement";
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096.blendType = BlendTreeType.SimpleDirectional2D;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096.maxThreshold = 7f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096.minThreshold = -1f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096.name = "Blend Tree";
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096.useAutomaticThresholds = false;
			var m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child0=  new ChildMotion();
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child0.motion = m_CrawlBwdTurnLeftAnimationClip21644;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child0.cycleOffset = 0f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child0.directBlendParameter = "HorizontalMovement";
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child0.mirror = false;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child0.position = new Vector2(-1f, -1f);
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child0.threshold = -1f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child0.timeScale = -1.25f;
			var m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child1=  new ChildMotion();
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child1.motion = m_CrawlBwdAnimationClip18720;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child1.cycleOffset = 0f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child1.directBlendParameter = "HorizontalMovement";
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child1.mirror = false;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child1.position = new Vector2(0f, -1f);
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child1.threshold = 0f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child1.timeScale = 1.25f;
			var m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child2=  new ChildMotion();
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child2.motion = m_CrawlBwdTurnRightAnimationClip21646;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child2.cycleOffset = 0f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child2.directBlendParameter = "HorizontalMovement";
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child2.mirror = false;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child2.position = new Vector2(1f, -1f);
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child2.threshold = 1f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child2.timeScale = -1.25f;
			var m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child3=  new ChildMotion();
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child3.motion = m_CrawlStrafeAnimationClip15706;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child3.cycleOffset = 0f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child3.directBlendParameter = "HorizontalMovement";
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child3.mirror = false;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child3.position = new Vector2(-1f, 0f);
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child3.threshold = 2f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child3.timeScale = 1.5f;
			var m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child4=  new ChildMotion();
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child4.motion = m_CrawlIdleAnimationClip17190;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child4.cycleOffset = 0f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child4.directBlendParameter = "HorizontalMovement";
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child4.mirror = false;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child4.position = new Vector2(0f, 0f);
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child4.threshold = 3f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child4.timeScale = 1f;
			var m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child5=  new ChildMotion();
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child5.motion = m_CrawlStrafeAnimationClip15706;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child5.cycleOffset = 0f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child5.directBlendParameter = "HorizontalMovement";
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child5.mirror = false;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child5.position = new Vector2(1f, 0f);
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child5.threshold = 4f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child5.timeScale = -1.5f;
			var m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child6=  new ChildMotion();
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child6.motion = m_CrawlFwdTurnLeftAnimationClip21648;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child6.cycleOffset = 0f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child6.directBlendParameter = "HorizontalMovement";
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child6.mirror = false;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child6.position = new Vector2(-1f, 1f);
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child6.threshold = 5f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child6.timeScale = 1.5f;
			var m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child7=  new ChildMotion();
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child7.motion = m_CrawlFwdAnimationClip12546;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child7.cycleOffset = 0f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child7.directBlendParameter = "HorizontalMovement";
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child7.mirror = false;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child7.position = new Vector2(0f, 1f);
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child7.threshold = 6f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child7.timeScale = 1.5f;
			var m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child8=  new ChildMotion();
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child8.motion = m_CrawlFwdTurnRightAnimationClip21650;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child8.cycleOffset = 0f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child8.directBlendParameter = "HorizontalMovement";
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child8.mirror = false;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child8.position = new Vector2(1f, 1f);
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child8.threshold = 7f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child8.timeScale = 1.5f;
			m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096.children = new ChildMotion[] {
				m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child0,
				m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child1,
				m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child2,
				m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child3,
				m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child4,
				m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child5,
				m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child6,
				m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child7,
				m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096Child8
			};
			m_CrawlMovementAnimatorState420152.motion = m_CrawlMovementAnimatorState420152m_BlendTreeBlendTree418096;
			m_CrawlMovementAnimatorState420152.cycleOffset = 0f;
			m_CrawlMovementAnimatorState420152.cycleOffsetParameterActive = false;
			m_CrawlMovementAnimatorState420152.iKOnFeet = true;
			m_CrawlMovementAnimatorState420152.mirror = false;
			m_CrawlMovementAnimatorState420152.mirrorParameterActive = false;
			m_CrawlMovementAnimatorState420152.speed = 1f;
			m_CrawlMovementAnimatorState420152.speedParameterActive = false;
			m_CrawlMovementAnimatorState420152.writeDefaultValues = true;

			var m_CrawlStartAnimatorState420024 = m_CrawlAnimatorStateMachine420360.AddState("Crawl Start", new Vector3(264f, -108f, 0f));
			var m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740 = new BlendTree();
			AssetDatabase.AddObjectToAsset(m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740, animatorController);
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740.hideFlags = HideFlags.HideInHierarchy;
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740.blendParameter = "Height";
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740.blendParameterY = "HorizontalMovement";
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740.blendType = BlendTreeType.Simple1D;
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740.maxThreshold = 1f;
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740.minThreshold = 0f;
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740.name = "Blend Tree";
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740.useAutomaticThresholds = false;
			var m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child0=  new ChildMotion();
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child0.motion = m_CrawlStartAnimationClip19134;
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child0.cycleOffset = 0f;
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child0.directBlendParameter = "HorizontalMovement";
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child0.mirror = false;
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child0.position = new Vector2(0f, 0f);
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child0.threshold = 0f;
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child0.timeScale = 1f;
			var m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child1=  new ChildMotion();
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child1.motion = m_CrawlCrouchStartAnimationClip23068;
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child1.cycleOffset = 0f;
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child1.directBlendParameter = "HorizontalMovement";
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child1.mirror = false;
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child1.position = new Vector2(0f, 0f);
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child1.threshold = 1f;
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child1.timeScale = 1f;
			m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740.children = new ChildMotion[] {
				m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child0,
				m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740Child1
			};
			m_CrawlStartAnimatorState420024.motion = m_CrawlStartAnimatorState420024m_BlendTreeBlendTree417740;
			m_CrawlStartAnimatorState420024.cycleOffset = 0f;
			m_CrawlStartAnimatorState420024.cycleOffsetParameterActive = false;
			m_CrawlStartAnimatorState420024.iKOnFeet = true;
			m_CrawlStartAnimatorState420024.mirror = false;
			m_CrawlStartAnimatorState420024.mirrorParameterActive = false;
			m_CrawlStartAnimatorState420024.speed = 1.5f;
			m_CrawlStartAnimatorState420024.speedParameterActive = false;
			m_CrawlStartAnimatorState420024.writeDefaultValues = true;

			var m_CrawlStopAnimatorState420000 = m_CrawlAnimatorStateMachine420360.AddState("Crawl Stop", new Vector3(624f, 168f, 0f));
			var m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040 = new BlendTree();
			AssetDatabase.AddObjectToAsset(m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040, animatorController);
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040.hideFlags = HideFlags.HideInHierarchy;
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040.blendParameter = "Height";
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040.blendParameterY = "HorizontalMovement";
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040.blendType = BlendTreeType.Simple1D;
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040.maxThreshold = 1f;
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040.minThreshold = 0f;
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040.name = "Blend Tree";
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040.useAutomaticThresholds = false;
			var m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child0=  new ChildMotion();
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child0.motion = m_CrawlStopAnimationClip13022;
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child0.cycleOffset = 0f;
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child0.directBlendParameter = "HorizontalMovement";
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child0.mirror = false;
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child0.position = new Vector2(0f, 0f);
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child0.threshold = 0f;
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child0.timeScale = 1f;
			var m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child1=  new ChildMotion();
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child1.motion = m_CrawlCrouchStopAnimationClip13624;
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child1.cycleOffset = 0f;
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child1.directBlendParameter = "HorizontalMovement";
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child1.mirror = false;
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child1.position = new Vector2(0f, 0f);
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child1.threshold = 1f;
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child1.timeScale = 1f;
			m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040.children = new ChildMotion[] {
				m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child0,
				m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040Child1
			};
			m_CrawlStopAnimatorState420000.motion = m_CrawlStopAnimatorState420000m_BlendTreeBlendTree418040;
			m_CrawlStopAnimatorState420000.cycleOffset = 0f;
			m_CrawlStopAnimatorState420000.cycleOffsetParameterActive = false;
			m_CrawlStopAnimatorState420000.iKOnFeet = true;
			m_CrawlStopAnimatorState420000.mirror = false;
			m_CrawlStopAnimatorState420000.mirrorParameterActive = false;
			m_CrawlStopAnimatorState420000.speed = 1.5f;
			m_CrawlStopAnimatorState420000.speedParameterActive = false;
			m_CrawlStopAnimatorState420000.writeDefaultValues = true;

			var m_CrawlIdleAnimatorState420232 = m_CrawlAnimatorStateMachine420360.AddState("Crawl Idle", new Vector3(264f, 36f, 0f));
			var m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880 = new BlendTree();
			AssetDatabase.AddObjectToAsset(m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880, animatorController);
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880.hideFlags = HideFlags.HideInHierarchy;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880.blendParameter = "Yaw";
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880.blendParameterY = "ForwardMovement";
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880.blendType = BlendTreeType.Simple1D;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880.maxThreshold = 12f;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880.minThreshold = -12f;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880.name = "Blend Tree";
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880.useAutomaticThresholds = false;
			var m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child0=  new ChildMotion();
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child0.motion = m_CrawlIdleTurnAnimationClip16312;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child0.cycleOffset = 0f;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child0.directBlendParameter = "HorizontalMovement";
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child0.mirror = false;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child0.position = new Vector2(-1f, 0f);
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child0.threshold = -12f;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child0.timeScale = 2f;
			var m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child1=  new ChildMotion();
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child1.motion = m_CrawlIdleTurnAnimationClip16312;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child1.cycleOffset = 0f;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child1.directBlendParameter = "HorizontalMovement";
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child1.mirror = false;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child1.position = new Vector2(-0.96f, 0.26f);
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child1.threshold = -6f;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child1.timeScale = 1f;
			var m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child2=  new ChildMotion();
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child2.motion = m_CrawlIdleAnimationClip17190;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child2.cycleOffset = 0f;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child2.directBlendParameter = "HorizontalMovement";
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child2.mirror = false;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child2.position = new Vector2(-0.87f, 0.5f);
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child2.threshold = 0f;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child2.timeScale = 1f;
			var m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child3=  new ChildMotion();
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child3.motion = m_CrawlIdleTurnAnimationClip16312;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child3.cycleOffset = 0f;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child3.directBlendParameter = "HorizontalMovement";
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child3.mirror = false;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child3.position = new Vector2(-0.71f, 0.71f);
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child3.threshold = 6f;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child3.timeScale = -1f;
			var m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child4=  new ChildMotion();
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child4.motion = m_CrawlIdleTurnAnimationClip16312;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child4.cycleOffset = 0f;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child4.directBlendParameter = "HorizontalMovement";
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child4.mirror = false;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child4.position = new Vector2(-0.5f, 0.87f);
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child4.threshold = 12f;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child4.timeScale = -2f;
			m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880.children = new ChildMotion[] {
				m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child0,
				m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child1,
				m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child2,
				m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child3,
				m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880Child4
			};
			m_CrawlIdleAnimatorState420232.motion = m_CrawlIdleAnimatorState420232m_BlendTreeBlendTree417880;
			m_CrawlIdleAnimatorState420232.cycleOffset = 0f;
			m_CrawlIdleAnimatorState420232.cycleOffsetParameterActive = false;
			m_CrawlIdleAnimatorState420232.iKOnFeet = true;
			m_CrawlIdleAnimatorState420232.mirror = false;
			m_CrawlIdleAnimatorState420232.mirrorParameterActive = false;
			m_CrawlIdleAnimatorState420232.speed = 1f;
			m_CrawlIdleAnimatorState420232.speedParameterActive = false;
			m_CrawlIdleAnimatorState420232.writeDefaultValues = true;

			// State Transitions.
			var m_AnimatorStateTransition418506 = m_CrawlMovementAnimatorState420152.AddTransition(m_CrawlStopAnimatorState420000);
			m_AnimatorStateTransition418506.canTransitionToSelf = true;
			m_AnimatorStateTransition418506.duration = 0.15f;
			m_AnimatorStateTransition418506.exitTime = 0.92f;
			m_AnimatorStateTransition418506.hasExitTime = false;
			m_AnimatorStateTransition418506.hasFixedDuration = true;
			m_AnimatorStateTransition418506.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418506.offset = 0f;
			m_AnimatorStateTransition418506.orderedInterruption = true;
			m_AnimatorStateTransition418506.isExit = false;
			m_AnimatorStateTransition418506.mute = false;
			m_AnimatorStateTransition418506.solo = false;
			m_AnimatorStateTransition418506.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var m_AnimatorStateTransition418748 = m_CrawlMovementAnimatorState420152.AddTransition(m_CrawlIdleAnimatorState420232);
			m_AnimatorStateTransition418748.canTransitionToSelf = true;
			m_AnimatorStateTransition418748.duration = 0.2f;
			m_AnimatorStateTransition418748.exitTime = 0.8849694f;
			m_AnimatorStateTransition418748.hasExitTime = false;
			m_AnimatorStateTransition418748.hasFixedDuration = true;
			m_AnimatorStateTransition418748.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418748.offset = 0f;
			m_AnimatorStateTransition418748.orderedInterruption = true;
			m_AnimatorStateTransition418748.isExit = false;
			m_AnimatorStateTransition418748.mute = false;
			m_AnimatorStateTransition418748.solo = false;
			m_AnimatorStateTransition418748.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var m_AnimatorStateTransition418934 = m_CrawlStartAnimatorState420024.AddTransition(m_CrawlMovementAnimatorState420152);
			m_AnimatorStateTransition418934.canTransitionToSelf = true;
			m_AnimatorStateTransition418934.duration = 0.2f;
			m_AnimatorStateTransition418934.exitTime = 0.8f;
			m_AnimatorStateTransition418934.hasExitTime = true;
			m_AnimatorStateTransition418934.hasFixedDuration = true;
			m_AnimatorStateTransition418934.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition418934.offset = 0f;
			m_AnimatorStateTransition418934.orderedInterruption = true;
			m_AnimatorStateTransition418934.isExit = false;
			m_AnimatorStateTransition418934.mute = false;
			m_AnimatorStateTransition418934.solo = false;
			m_AnimatorStateTransition418934.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			var m_AnimatorStateTransition419874 = m_CrawlStartAnimatorState420024.AddTransition(m_CrawlIdleAnimatorState420232);
			m_AnimatorStateTransition419874.canTransitionToSelf = true;
			m_AnimatorStateTransition419874.duration = 0.2f;
			m_AnimatorStateTransition419874.exitTime = 0.8f;
			m_AnimatorStateTransition419874.hasExitTime = true;
			m_AnimatorStateTransition419874.hasFixedDuration = true;
			m_AnimatorStateTransition419874.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419874.offset = 0f;
			m_AnimatorStateTransition419874.orderedInterruption = true;
			m_AnimatorStateTransition419874.isExit = false;
			m_AnimatorStateTransition419874.mute = false;
			m_AnimatorStateTransition419874.solo = false;
			m_AnimatorStateTransition419874.AddCondition(AnimatorConditionMode.IfNot, 0f, "Moving");

			var m_AnimatorStateTransition419152 = m_CrawlStartAnimatorState420024.AddTransition(m_CrawlStopAnimatorState420000);
			m_AnimatorStateTransition419152.canTransitionToSelf = true;
			m_AnimatorStateTransition419152.duration = 0.15f;
			m_AnimatorStateTransition419152.exitTime = 0.8f;
			m_AnimatorStateTransition419152.hasExitTime = false;
			m_AnimatorStateTransition419152.hasFixedDuration = true;
			m_AnimatorStateTransition419152.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419152.offset = 0f;
			m_AnimatorStateTransition419152.orderedInterruption = true;
			m_AnimatorStateTransition419152.isExit = false;
			m_AnimatorStateTransition419152.mute = false;
			m_AnimatorStateTransition419152.solo = false;
			m_AnimatorStateTransition419152.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			var m_AnimatorStateTransition419856 = m_CrawlStopAnimatorState420000.AddTransition(m_CrawlStartAnimatorState420024);
			m_AnimatorStateTransition419856.canTransitionToSelf = true;
			m_AnimatorStateTransition419856.duration = 0.15f;
			m_AnimatorStateTransition419856.exitTime = 0.8f;
			m_AnimatorStateTransition419856.hasExitTime = false;
			m_AnimatorStateTransition419856.hasFixedDuration = true;
			m_AnimatorStateTransition419856.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419856.offset = 0f;
			m_AnimatorStateTransition419856.orderedInterruption = true;
			m_AnimatorStateTransition419856.isExit = false;
			m_AnimatorStateTransition419856.mute = false;
			m_AnimatorStateTransition419856.solo = false;
			m_AnimatorStateTransition419856.AddCondition(AnimatorConditionMode.Equals, 103f, "AbilityIndex");
			m_AnimatorStateTransition419856.AddCondition(AnimatorConditionMode.Equals, 0f, "AbilityIntData");

			var m_AnimatorStateTransition419630 = m_CrawlStopAnimatorState420000.AddExitTransition();
			m_AnimatorStateTransition419630.canTransitionToSelf = true;
			m_AnimatorStateTransition419630.duration = 0.25f;
			m_AnimatorStateTransition419630.exitTime = 0.95f;
			m_AnimatorStateTransition419630.hasExitTime = false;
			m_AnimatorStateTransition419630.hasFixedDuration = true;
			m_AnimatorStateTransition419630.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419630.offset = 0f;
			m_AnimatorStateTransition419630.orderedInterruption = false;
			m_AnimatorStateTransition419630.isExit = true;
			m_AnimatorStateTransition419630.mute = false;
			m_AnimatorStateTransition419630.solo = false;
			m_AnimatorStateTransition419630.AddCondition(AnimatorConditionMode.NotEqual, 103f, "AbilityIndex");

			var m_AnimatorStateTransition419826 = m_CrawlIdleAnimatorState420232.AddTransition(m_CrawlMovementAnimatorState420152);
			m_AnimatorStateTransition419826.canTransitionToSelf = true;
			m_AnimatorStateTransition419826.duration = 0.2f;
			m_AnimatorStateTransition419826.exitTime = 0.8231132f;
			m_AnimatorStateTransition419826.hasExitTime = false;
			m_AnimatorStateTransition419826.hasFixedDuration = true;
			m_AnimatorStateTransition419826.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419826.offset = 0f;
			m_AnimatorStateTransition419826.orderedInterruption = true;
			m_AnimatorStateTransition419826.isExit = false;
			m_AnimatorStateTransition419826.mute = false;
			m_AnimatorStateTransition419826.solo = false;
			m_AnimatorStateTransition419826.AddCondition(AnimatorConditionMode.If, 0f, "Moving");

			var m_AnimatorStateTransition419578 = m_CrawlIdleAnimatorState420232.AddTransition(m_CrawlStopAnimatorState420000);
			m_AnimatorStateTransition419578.canTransitionToSelf = true;
			m_AnimatorStateTransition419578.duration = 0.15f;
			m_AnimatorStateTransition419578.exitTime = 0.8231132f;
			m_AnimatorStateTransition419578.hasExitTime = false;
			m_AnimatorStateTransition419578.hasFixedDuration = true;
			m_AnimatorStateTransition419578.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419578.offset = 0f;
			m_AnimatorStateTransition419578.orderedInterruption = true;
			m_AnimatorStateTransition419578.isExit = false;
			m_AnimatorStateTransition419578.mute = false;
			m_AnimatorStateTransition419578.solo = false;
			m_AnimatorStateTransition419578.AddCondition(AnimatorConditionMode.Equals, 1f, "AbilityIntData");

			// State Machine Defaults.
			m_CrawlAnimatorStateMachine420360.anyStatePosition = new Vector3(48f, 48f, 0f);
			m_CrawlAnimatorStateMachine420360.defaultState = m_CrawlIdleAnimatorState420232;
			m_CrawlAnimatorStateMachine420360.entryPosition = new Vector3(72f, -36f, 0f);
			m_CrawlAnimatorStateMachine420360.exitPosition = new Vector3(876f, 48f, 0f);
			m_CrawlAnimatorStateMachine420360.parentStateMachinePosition = new Vector3(852f, -48f, 0f);

			// State Machine Transitions.
			var m_AnimatorStateTransition419126 = baseStateMachine12.AddAnyStateTransition(m_CrawlStartAnimatorState420024);
			m_AnimatorStateTransition419126.canTransitionToSelf = false;
			m_AnimatorStateTransition419126.duration = 0.15f;
			m_AnimatorStateTransition419126.exitTime = 0.75f;
			m_AnimatorStateTransition419126.hasExitTime = false;
			m_AnimatorStateTransition419126.hasFixedDuration = true;
			m_AnimatorStateTransition419126.interruptionSource = TransitionInterruptionSource.None;
			m_AnimatorStateTransition419126.offset = 0f;
			m_AnimatorStateTransition419126.orderedInterruption = true;
			m_AnimatorStateTransition419126.isExit = false;
			m_AnimatorStateTransition419126.mute = false;
			m_AnimatorStateTransition419126.solo = false;
			m_AnimatorStateTransition419126.AddCondition(AnimatorConditionMode.If, 0f, "AbilityChange");
			m_AnimatorStateTransition419126.AddCondition(AnimatorConditionMode.Equals, 103f, "AbilityIndex");
		}
	}
}
