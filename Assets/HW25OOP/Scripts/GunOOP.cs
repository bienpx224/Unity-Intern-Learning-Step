using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunOOP : MonoBehaviour
{
    [SerializeField] public GameObject Bullet;
    [SerializeField] public float reloadTime = 2f;
    [SerializeField] public float nextFire = 0;
    [SerializeField] public float fireRate = 0.5f;
    delegate void Shooting();
    Shooting shooting;

    void Start()
    {
        
    }
    void Update()
    {
        Onfire();   
    }
    public void Onfire()
    {
        if(Time.time > nextFire)
        {
            nextFire = Time.time+fireRate;
            Instantiate(Bullet, transform.position, transform.rotation);

        }
     
    }

}
