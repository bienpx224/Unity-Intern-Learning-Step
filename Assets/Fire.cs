using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] protected Transform bullet;
    private static Fire instance;
    public static Fire Instance {get => instance;}
    public int count=0;
    void Start()
    {
        instance=this;
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
            count++;
        }
    }
}
