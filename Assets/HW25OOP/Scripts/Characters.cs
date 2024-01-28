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
    protected virtual void Onfire()
    {

    }
    protected virtual void TakeDamage()
    {

    }
    protected virtual void Movement()
    {

    }  
}
