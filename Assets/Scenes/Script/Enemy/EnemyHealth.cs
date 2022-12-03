using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health;

    [Header("Effects")]
    [SerializeField] GameObject effect_Explosion;
    
    //OBJECTIVE:
    //Create a function call TakingDamage which takes in a float paramater
    /*Whats needed:
     * The paramater "dmg" contain the value that the enemy will take damage
     * Use this value as the amount of damage the enemy will take
     * There is a also a visual effect call effect_Explosion has been set. Spawn this object when the enemy has ran out of health
     */
    public void TakingDamage(float dmg)
    {
        /*
         * if (enemy health > 0)
         * enemy health -  dmg
         * else
         * destroy enemy
         * Spawn effect
         */
    }
}
