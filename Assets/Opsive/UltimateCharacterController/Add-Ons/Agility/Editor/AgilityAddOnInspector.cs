/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

namespace Opsive.UltimateCharacterController.AddOns.Agility.Editor
{
    using Opsive.UltimateCharacterController.AddOns.Shared.Editor;
    using Opsive.UltimateCharacterController.Editor.Managers;
    using UnityEditor.Animations;
    using UnityEngine;

    /// <summary>
    /// Draws the inspector for the agility add-on.
    /// </summary>
    [OrderedEditorItem("Agility Pack", 2)]
    public class AgilityAddOnInspector : AddOnInspector, IAbilityAddOnInspector
    {
        private GameObject m_Character;
        private AnimatorController m_AnimatorController;

        public GameObject Character { get { return m_Character; } set { m_Character = value; } }
        public AnimatorController AnimatorController { get { return m_AnimatorController; } set { m_AnimatorController = value; } }
        public AnimatorController FirstPersonAnimatorController { get { return null; } set { } }
        public string AddOnName { get { return "Agility"; } }
        public string AbilityNamespace { get { return "Opsive.UltimateCharacterController.AddOns.Agility"; } }
        public bool ShowFirstPersonAnimatorController { get { return false; } }

        /// <summary>
        /// Draws the add-on inspector.
        /// </summary>
        public override void DrawInspector()
        {
            AddOnInspectorUtility.DrawInspector(this);
        }
    }
}