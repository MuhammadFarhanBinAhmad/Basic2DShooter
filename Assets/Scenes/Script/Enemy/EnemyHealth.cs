using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health;

    [Header("Effects")]
    [SerializeField] GameObject effect_Explosion;
    
    internal void TakingDamage(float dmg)
    {
        if (health > 0)
        {
            health -= dmg;
        }
        if (health <= 0)
        {
            GameObject E = Instantiate(effect_Explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
