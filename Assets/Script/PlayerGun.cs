using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] Vector3 targetPos;
    [SerializeField] Transform Player;
    void Start()
    {
        if (Player == null)
            Player = transform.Find("=== Player");
    }

    // Update is called once per frame
    void Update()
    {
        GetDirection();
        GunRotation();
    }
    private void GetDirection()
    {
        targetPos=InputManager.Instance.mouseWorldPos;
    }
    private void GunRotation()
    {
        Vector3 gunRotaion = targetPos - transform.parent.position;
        gunRotaion.Normalize();
        float rotationZ = Mathf.Atan2(gunRotaion.y, gunRotaion.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
    }
}
