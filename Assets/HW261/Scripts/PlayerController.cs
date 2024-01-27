using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : Charater
{
    [SerializeField] private GunController gun;
    private void Update()
    {
        Firing();
    }
    protected override void Firing()
    {
        if (InputManager.Instance.isClick)
        {
            gun.OnFire();
        }
    }
    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("Enemy")){
            TakingDamage();
        }
    }
    protected override void TakingDamage()
    {
        healPoint--;
        if (healPoint == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
