using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get => instance; }
    public Vector3 mouseWorldPos;
    [SerializeField] private Camera camera;
    public bool isClick=false;

    private void Start()
    {
        instance = this;
    }
    private void Update()
    {
        GetMousePositsion();
        GetMouseClick();
    }

    protected virtual void GetMousePositsion()
    {
        mouseWorldPos= camera.ScreenToWorldPoint(Input.mousePosition);
    }
    private void GetMouseClick(){
        isClick = Input.GetButtonDown("Fire1");
    }
}
