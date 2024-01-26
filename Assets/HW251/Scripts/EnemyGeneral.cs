using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyGeneral : MonoBehaviour
{
    [SerializeField] int healPoint = 5;
    [SerializeField] float enemySpeed = 3f;
    [SerializeField] Transform playerPosition;
    [SerializeField] Text healPointText;
    private void Start(){
        //GetPlayerPosition();
    }
    private void Update(){
        HealCheck();
        EnemyMovement();
        UpdateHealPoint();
    }
    private void HealCheck(){
        if (healPoint <= 0){
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
    }
    private void EnemyMovement(){
        Vector3 direction = (playerPosition.position-this.transform.position).normalized;
        transform.Translate(direction * enemySpeed * Time.deltaTime);
    }
    private void GetPlayerPosition(){
        playerPosition = transform.Find("=== Player");
    }
    private void UpdateHealPoint(){
        healPointText.text=healPoint.ToString();
    }
}
