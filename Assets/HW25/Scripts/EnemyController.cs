using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EnemyController : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject target;
    float movespeed =2f;
    Vector3 directionToTarget;
    public TMP_Text vaule;
    public float maxHealth = 100;   
    void Start()
    {
        target = GameObject.Find("PlayerHW25");
        rb=GetComponent<Rigidbody2D>();
        vaule.text = maxHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
        vaule.text = maxHealth.ToString();
    }
    void MoveEnemy()
    {
        if (target != null)
        {
            directionToTarget = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector2(directionToTarget.x * movespeed, directionToTarget.y * movespeed);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            maxHealth -= 1;
        }
    }
}
