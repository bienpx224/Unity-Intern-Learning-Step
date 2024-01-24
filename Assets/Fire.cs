using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] protected Transform bullet;

    void Start()
    {

    }
    void Update()
    {
        isFire();
    }

    private void isFire()
    {
        if (InputManager.Instance.isClick)
        {
            Vector3 spawnPos = transform.parent.position;
            Quaternion rotation = transform.parent.rotation;
            Instantiate(this.bullet, spawnPos, rotation);
        }
    }
}
