using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Enemy : Charater
{
    private static Enemy instance;
    public static Enemy Instance { get => instance; }
    [SerializeField] public float spawnTime = 5f;
    [SerializeField] GameObject playerPos;
    [SerializeField] TextMeshProUGUI healPointText;
    private void Awake()
    {
        instance = this;
    }
    private void OnEnable()
    {
        playerPos= GameObject.FindGameObjectWithTag("Player");
        healPointText.text = "HP: " + healPoint.ToString();
    }
    private void Update()
    {
        CharacterMovement(moveSpeed, playerPos.transform);

    }
    protected override void TakingDamage()
    {
        base.TakingDamage();
        healPoint--;
        healPointText.text = "HP: " + healPoint.ToString();
        if (healPoint <= 0)
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Bullet"))
        {
            TakingDamage();
        }
    }
}
