using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : Charater
{
    [SerializeField] private GunController gun;
    private void Update(){
        Fire();
    }
    private void Fire(){
        if(InputManager.Instance.isClick){
            gun.OnFire();
        }
    }
}
