using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Enemy : Charater
{
    [SerializeField] Transform playerPos;
    [SerializeField] TextMeshProUGUI healPointText;
    private void OnEnable(){
        healPointText.text = "HP: " + healPoint.ToString();
    }
    private void Update()
    {
        CharacterMovement(moveSpeed, playerPos);

    }
    protected override void TakingDamage()
    {
        base.TakingDamage();
        healPoint--;
        healPointText.text = "HP: " +  healPoint.ToString();
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
