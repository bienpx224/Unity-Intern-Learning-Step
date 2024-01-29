using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed = 1f;
    [SerializeField] private TextMeshPro enemyHP;
    private Rigidbody2D rb;
    private int hp = 100;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enemyHP.SetText(hp.ToString());
    }
    private void Update()
    {
        if (!target)
        {
            GetTarget();
        }
        else
        {
            RotateTowardsTarget();
            MoveTowardsTarget();
        }
    }
    private void GetTarget()
    {
        target = GameObject.FindWithTag("Player").transform;
    }
    private void RotateTowardsTarget()
    {
        var offset = 90f;
        Vector2 direction = target.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));
    }
    private void MoveTowardsTarget()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    public void TakeDamage(int damage)
    {
        hp -= damage;
        enemyHP.SetText(hp.ToString());
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
