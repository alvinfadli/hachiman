using NUnit.Framework;
using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    [SerializeField] private PlayerStats stats;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            UseMana(1f);
        }
    }

    public void UseMana(float amount)
    {
        if (stats.Mana >= amount)
        {
            stats.Mana -= amount;

            if (stats.Mana <= 0)
            {
                stats.Mana = 0;
            }
        }
    }
}
