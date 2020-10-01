using UnityEngine;

namespace Mechanarchy.Stats
{
    [CreateAssetMenu(fileName = "New Class", menuName = "Mechanarchy/Create New Class", order = 0)]
    public class CharacterClass : ScriptableObject
    {
        [Header("Weapons")]
        public Weapon primaryWeapon = null;
        public Weapon secondaryWeapon = null;
        public Weapon grenade = null;

        [Header("Class Specific")]
        public Skill classSkill = null;
        public Skill passiveSkill = null;
    }
}
