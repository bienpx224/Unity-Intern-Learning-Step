using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;
    public static InputManager Instnace { get => instance;  }

    [SerializeField] protected Vector3 mouseWorldPos;

    public Vector3 MouseWorldPos { get => mouseWorldPos; }
    private void Awake()
    {
        InputManager.instance = this;
    }
    private void FixedUpdate()
    {
        this.GetMousePos();       
    }
    protected virtual void GetMousePos()
    {
        this.mouseWorldPos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}

