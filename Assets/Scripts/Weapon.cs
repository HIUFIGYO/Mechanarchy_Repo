using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Mechanarchy/Create New Weapon", order = 0)]
public class Weapon : ScriptableObject
{
    [SerializeField] int maxAmmo = 0;
    [SerializeField] int clipSize = 0;
    [SerializeField] float damage = 0f;
    [SerializeField] float fireRate = 0f;
    [SerializeField] float reloadSpeed = 0f;
}
