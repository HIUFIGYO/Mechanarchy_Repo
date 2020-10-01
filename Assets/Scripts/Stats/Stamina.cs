using UnityEngine;

namespace Mechanarchy.Stats
{
    public class Stamina : MonoBehaviour
    {
        [SerializeField] float stamina = 100f;
        [Tooltip("Stamina Points/s")][SerializeField] float staminaRecoverRate = 20f;
        [SerializeField] float recoverDelay = 1f;

        float delayTimer = 0f;
        float maxStamina;

        private void Awake()
        {
            maxStamina = stamina;
        }

        private void Update()
        {
            ProcessTimers();
        }

        private void ProcessTimers()
        {
            delayTimer += Time.deltaTime;
            if (delayTimer >= recoverDelay)
            {
                if (stamina < maxStamina)
                {
                    stamina += staminaRecoverRate * Time.deltaTime;
                    if (stamina > maxStamina)
                    {
                        stamina = maxStamina;
                    }
                }
            }
        }

        public bool CanPerformAction(float staminaCost)
        {
            delayTimer = 0f;
            if (stamina >= staminaCost)
            {
                stamina -= staminaCost;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
