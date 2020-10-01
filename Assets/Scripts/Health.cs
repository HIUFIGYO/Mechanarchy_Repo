using UnityEngine;

namespace Mechanarchy.Stats
{
    public class Health : MonoBehaviour
    {
        [Header("Stats")]
        [SerializeField] float health = 100f;
        [SerializeField] float tempHealth = 0f;
        [SerializeField] float bleedoutHealth = 300f;
        [SerializeField] Weapon weapon;

        [Header("Control")]
        [SerializeField] bool isPlayer = true;
        [Tooltip("In Seconds")] [SerializeField] float tempHealthTime = 3f;
        [Tooltip("In Seconds")] [SerializeField] float bleedoutHealthTime = 1f;

        bool isDead = false;

        float timerTempHealth = 0f;
        float timerBleedout = 0f;

        private void Update()
        {
            ProcessTimers();
        }

        private void ProcessTimers()
        {
            timerTempHealth += Time.deltaTime;
            timerBleedout += Time.deltaTime;

            if (timerTempHealth >= tempHealthTime)
            {
                timerTempHealth = 0f;
                if (tempHealth > 0)
                {
                    TakeDamage(1f);
                }
            }

            if (timerBleedout >= bleedoutHealthTime)
            {
                timerBleedout = 0f;
                if (Mathf.Approximately(tempHealth, 0f) && Mathf.Approximately(health, 0f))
                {
                    TakeDamage(1f);
                }
            }
        }

        private void DamageEnemy(float damage)
        {
            health -= damage;
            if (health <= 0f)
            {
                health = 0f;
                Die();
            }
        }

        private float DamageTemp(float remainingDamage)
        {
            if (tempHealth > 0)
            {
                if (remainingDamage >= tempHealth)
                {
                    remainingDamage -= tempHealth;
                    tempHealth = 0f;
                }
                else
                {
                    tempHealth -= remainingDamage;
                    remainingDamage = 0f;
                }
            }

            return remainingDamage;
        }

        private float DamageHealth(float remainingDamage)
        {
            if (health > 0)
            {
                if (remainingDamage >= health)
                {
                    remainingDamage -= health;
                    health = 0f;
                }
                else
                {
                    health -= remainingDamage;
                    remainingDamage = 0f;
                }
            }

            return remainingDamage;
        }

        private void DamageBleedout(float remainingDamage)
        {
            if (remainingDamage >= bleedoutHealth)
            {
                bleedoutHealth = 0f;
                Die();
            }
            else
            {
                bleedoutHealth -= remainingDamage;
            }
        }

        private void Die()
        {
            if (isDead) { return; }

            isDead = true;
        }

        public bool IsDead()
        {
            return isDead;
        }

        public void TakeDamage(float damage)
        {
            if (!isPlayer)
            {
                DamageEnemy(damage);
            }
            else
            {
                float remainingDamage = damage;
                remainingDamage = DamageTemp(remainingDamage);
                remainingDamage = DamageHealth(remainingDamage);
                DamageBleedout(remainingDamage);

            }
        }
    }
}
