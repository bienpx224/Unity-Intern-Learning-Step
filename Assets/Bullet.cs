using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] protected float bulletSpeed = 10f;
    [SerializeField] protected Vector3 directon = Vector3.up;
    private void Update()
    {
        BulletFly();
    }
    protected void BulletFly()
    {
        transform.Translate(this.directon * bulletSpeed * Time.deltaTime);
    }
}
