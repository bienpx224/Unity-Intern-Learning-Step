using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Charater : MonoBehaviour
{
    [SerializeField] int healPoint = 5;
    [SerializeField] int damage = 1;
    [SerializeField] float moveSpeed = 5f;

    public virtual void CharacterMovement(int moveSpeed, Transform target){
        transform.Translate(target.position*moveSpeed*Time.deltaTime);
    }
    public virtual void TakingDamage(){
        
    }
    public virtual void Firing(){

    }
}
