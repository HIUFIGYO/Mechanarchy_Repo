using UnityEngine;

namespace Mechanarchy.Stats
{
    [RequireComponent(typeof(Health))]
    public class Armor : MonoBehaviour
    {
        [Header("Stats")]
        [SerializeField] float armor = 50f;
        [SerializeField] float shield = 25f;

        [Header("Control")]
        [SerializeField] float shieldRechargeRate = 1f;
        [SerializeField] float shieldRechargeDelay = 10f;
        [SerializeField] float flatDamageReduction = 5f;
        [Tooltip("Percent")][Range(0f, 1f)][SerializeField] float damageDistributionRatio = 0.75f;

        Health health;

        float rechargeTimer = 0f;

        float maxArmor;
        float maxShield;

        private void Awake()
        {
            health = GetComponent<Health>();
        }

        private void Start()
        {
            maxArmor = armor;
            maxShield = shield;
        }

        private void Update()
        {
            RechargeShield();
            if(Input.GetButtonDown("Fire1"))
            {
                TakeDamage(5.5f);
            }
        }

        private void RechargeShield()
        {
            rechargeTimer += Time.deltaTime;
            if (rechargeTimer > shieldRechargeDelay && shield < maxShield)
            {
                shield += shieldRechargeRate * Time.deltaTime;
                if (shield > maxShield)
                {
                    shield = maxShield;
                }
            }
        }

        public void RepairArmour(float repairValue)
        {
            armor += repairValue;
            if(armor > maxArmor)
            {
                armor = maxArmor;
            }
        }

        public void TakeDamage(float damage)
        {
            rechargeTimer = 0f;

            if(shield > 0)
            {
                shield -= damage;
                if(shield < 0f)
                {
                    shield = 0f;
                }
                return;
            }

            if(armor <= 0f)
            {
                health.TakeDamage(damage);
                return;
            }

            damage -= flatDamageReduction;
            if (damage <= 0f) { return; }

            float damageToArmor = damage * damageDistributionRatio;
            float damageToHealth = damage - damageToArmor;

            if(armor < damageToArmor)
            {
                damageToHealth += (damageToArmor - armor);
                armor = 0f;
            }
            else
            {
                armor -= damageToArmor;
            }

            health.TakeDamage(damageToHealth);
        }
    }
}
