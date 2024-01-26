using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Characters : MonoBehaviour
{
    [SerializeField] public int hp;
    [SerializeField] public int atk;
    [SerializeField] public float atkSpd;
    [SerializeField] public float moveSpeed;

    public Characters()
    {

    }
    public virtual void SetData(Characters c)
    {
        hp = c.hp;
        atk = c.atk;
        atkSpd= c.atkSpd;
        moveSpeed = c.moveSpeed;
    }
    public virtual void Onfire()
    {

    }
    public virtual void TakeDamage()
    {

    }
    public virtual void Movement()
    {

    }  
}
