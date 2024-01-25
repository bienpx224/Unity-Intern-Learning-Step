using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagerHW25 : MonoBehaviour
{
    public static InputManagerHW25 instance25;
    public static InputManagerHW25 Instance25 { get => instance25; }

    [SerializeField] protected Vector3 mouseWorldPos25;
    public Vector3 MouseWorldPos25 { get => mouseWorldPos25; }
    public bool isClick25 = false;
    private void Awake()
    {
        InputManagerHW25.instance25 = this;
    }
    private void FixedUpdate()
    {
        this.GetMousePos25();
        this.OnClickMouse();
    }
    protected virtual void GetMousePos25()
    {
        this.mouseWorldPos25 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnClickMouse()
    {
        isClick25 = Input.GetButton("Fire1");
    }
}
