using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] private int bulletDamage = 1;
    [SerializeField] private float bulletSpeed = 10f;
    [SerializeField] private Color bulletColor ;
    private Vector3 bulletVector= Vector3.up;
    private void Update(){
        bulletMovement();
    }
    public virtual void bulletMovement(){
        transform.Translate(bulletVector * bulletSpeed * Time.deltaTime);
    }
    public virtual void OnCollisionEnter2D(){

    }
}
