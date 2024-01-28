using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Enemy : Characters
{
    [SerializeField] public GameObject playerPos;
    [SerializeField] public float speed = 1f;
    [SerializeField] public TextMeshProUGUI enemyHP;
    [SerializeField] public int maxHealth = 100;

    public static Enemy instance;
    public static Enemy Instance { get => instance; }
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        hp = 100;
        enemyHP.text = hp.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        Movement();
        enemyHP.text = hp.ToString();
    }
    protected override void Movement()
    {
        Vector3 direction = (playerPos.transform.position - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            hp--;
        }
    }
}
