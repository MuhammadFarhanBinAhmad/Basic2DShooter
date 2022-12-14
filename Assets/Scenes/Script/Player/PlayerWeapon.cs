using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class PlayerWeapon : MonoBehaviour
{
    [Header("WeaponStats")]
    [SerializeField] float stats_WeaponFireRate;
    [SerializeField] GameObject weapon_Projectile;
    [SerializeField] Transform projectile_SpawnPoint;
    public float magn, rough, fadeIn, fadeOut;
    Vector3 posInf = new Vector3(0.25f, 0.25f, 0.25f);
    Vector3 rotInf = new Vector3(1, 1, 1);
    int weapon_Mode =1;

    [Header("WeaponEffect")]
    [SerializeField] ParticleSystem weapon_Effect;
    [SerializeField] GameObject weapon_Light;
    float nexttime_ToFire;

    CameraShakeInstance shake;

    private void Update()
    {
        /*
         * OBJECTIVE:
         * Create a condition where the player can chage weapon state(rapid fire and single fire)
         * 
        if (Input.GetKeyDown(KeyCode.Q))
        {
            weapon_Mode++;
            if (weapon_Mode == 2)
            {
                weapon_Mode = 0;
            }
        }

        switch (weapon_Mode)
        {
            case 0:
                if (Input.GetButtonDown("Fire") && Time.time >= nexttime_ToFire)
                {
                    nexttime_ToFire = Time.time + 1f / stats_WeaponFireRate;
                    Shoot();
                }
                break;
            case 1:
                if (Input.GetButton("Fire") && Time.time >= nexttime_ToFire)
                {
                    nexttime_ToFire = Time.time + 1f / stats_WeaponFireRate;
                    Shoot();
                }
                break;
                
        }
        /*if (Input.GetButtonDown("Fire") && Time.time >= nexttime_ToFire)
        {
            nexttime_ToFire = Time.time + 1f / stats_WeaponFireRate;
            Shoot();
        }*/
    }

    void Shoot()
    {
        GameObject p = Instantiate(weapon_Projectile, projectile_SpawnPoint.transform.position, projectile_SpawnPoint.transform.rotation);
        GameObject l = Instantiate(weapon_Light, projectile_SpawnPoint.transform.position, projectile_SpawnPoint.transform.rotation);
        CameraShakeInstance c = CameraShaker.Instance.ShakeOnce(magn, rough, fadeIn, fadeOut);
        c.PositionInfluence = posInf;
        c.RotationInfluence = rotInf;

        weapon_Effect.Play();
    }
}
