using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] private int bulletDamage = 1;
    [SerializeField] private float bulletSpeed = 10f;
    [SerializeField] private Color bulletColor;
    [SerializeField] private float timeAlive = 2f;
    private Vector3 bulletVector = Vector3.up;
    private void OnEnable()
    {
        KillBulletByTime();
    }
    private void Update()
    {
        BulletMovement();
    }
    public virtual void BulletMovement()
    {
        transform.Translate(bulletVector * bulletSpeed * Time.deltaTime);
    }
    protected virtual void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Enemy")){
            Destroy(gameObject);
        }
    }
    protected virtual void KillBulletByTime()
    {
        StartCoroutine(IETimeToKillBullet());
    }
    private IEnumerator IETimeToKillBullet()
    {
        yield return new WaitForSeconds(timeAlive);
        Destroy(this.gameObject);
    }
}
