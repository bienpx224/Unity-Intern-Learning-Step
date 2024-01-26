using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputOOP : MonoBehaviour
{
    public static InputOOP instanceOOP;
    public static InputOOP InstanceOOP { get => instanceOOP; }

    [SerializeField] protected Vector3 mouseWorldPosOOP;

    public Vector3 MouseWorldPosOOP { get => mouseWorldPosOOP; }

    private void Awake()
    {
        InputOOP.instanceOOP = this;
    }

    private void FixedUpdate()
    {
        this.GetMousePosOOP();   
    }
    protected virtual void GetMousePosOOP()
    {
        this.mouseWorldPosOOP = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
