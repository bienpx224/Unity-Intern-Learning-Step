using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGeneral : MonoBehaviour
{
    [SerializeField] protected float bulletSpeed = 10f;
    [SerializeField] protected Vector3 directon = Vector3.up;
    [SerializeField] public int bulletDamage = 1;
    protected void BulletFly()
    {
        transform.Translate(this.directon * bulletSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision){
        Destroy(this.gameObject);
    }
}
