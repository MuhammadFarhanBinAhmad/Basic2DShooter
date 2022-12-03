using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] Rigidbody2D the_RB;
    [SerializeField] GameObject effect_Hit;

    [SerializeField] float bullet_Speed;
    [SerializeField] float bullet_Damage;

    void Update()
    {
        the_RB.velocity = transform.up * bullet_Speed;
    }


    //OBJECTIVE: LEARN ABOUT HOW TO USE COLLIDER
    private void OnTriggerEnter2D(Collider2D other)
    {
       /* GameObject e = Instantiate(effect_Hit, transform.position, effect_Hit.transform.rotation);
        if (other.GetComponent<EnemyHealth>())
        {
            other.GetComponent<EnemyHealth>().TakingDamage(bullet_Damage);
            Destroy(gameObject);
        }*/
    }
}
