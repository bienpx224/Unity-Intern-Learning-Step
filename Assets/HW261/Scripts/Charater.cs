using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Charater : MonoBehaviour
{
    [SerializeField] protected int healPoint = 5;
    [SerializeField] protected int damage = 1;
    [SerializeField] protected float moveSpeed = 5f;

    protected virtual void CharacterMovement(float moveSpeed, Transform target)
    {
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
    protected virtual void TakingDamage()
    {

    }
    protected virtual void Firing()
    {

    }
}
