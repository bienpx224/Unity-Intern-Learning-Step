using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get => instance; }
    public Vector3 mouseWorldPos;
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

    private void GetMousePositsion()
    {
        mouseWorldPos = Input.mousePosition;
        
    }
    private void GetMouseClick(){
        isClick = Input.GetButtonDown("Fire1");
    }
}
