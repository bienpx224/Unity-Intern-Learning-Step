using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int hp = 100;
    public int atk = 1;
    public float moveSpeed = 3f;
    public float bulletSpeed = 10f;

    void Fire() { }
    void TakeDamage()
    {
        hp -= atk;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    void Movement() { }
}
