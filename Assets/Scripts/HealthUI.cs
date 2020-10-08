using UnityEngine;
using Mechanarchy.Stats;

namespace Mechanarchy.UI
{
    public class HealthUI : MonoBehaviour
    {
        [SerializeField] RectTransform healthFillArea = default;

        Health health;

        private void Start()
        {
            health = GameObject.FindWithTag("Player").GetComponent<Health>();
        }

        private void Update()
        {
            healthFillArea.localScale = new Vector2(health.GetHealthFraction(), 1);
        }
    }
}
