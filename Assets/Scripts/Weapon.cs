using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float fireRate = 0f;
    public float Damage = 10f;
    public LayerMask notToHit;
    public Transform firePoint;

    private float timeToFire = 0f;

    void Awake()
    {
        
    }

    void Update()
    {
        if(fireRate == 0)
        {
            if(Input.GetButtonDown("Fire1"))
            {
                //Shoot();
            }
            else
            {
                if (Input.GetButton("Fire1") && Time.time > timeToFire)
                {
                    timeToFire = Time.time + 1 / fireRate;
                    //Shoot();
                }
            }
            //if standing in collider to loot or pick berries dont fire
        }
    }

    //Shoot()
    //{

    //}
}
