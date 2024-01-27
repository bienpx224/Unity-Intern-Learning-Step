using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get => instance; }
    public Vector3 mouseWorldPos;
    [SerializeField] private Camera cam;
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
        mouseWorldPos= cam.ScreenToWorldPoint(Input.mousePosition);
    }
    private void GetMouseClick(){
        isClick = Input.GetButtonDown("Fire1");
    }
    public Transform LookAtTarget(Transform rotationToLookAtTarget){
        Vector3 distance = (rotationToLookAtTarget.position - transform.position);
        distance.Normalize();
        float rotateZ = Mathf.Atan2(distance.y, distance.x) * Mathf.Rad2Deg;
        rotationToLookAtTarget.transform.rotation = Quaternion.Euler(0f, 0f, rotateZ - 90);
        return rotationToLookAtTarget;
    }
}
