using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovement : MonoBehaviour
{
    private void Update(){
        GunRotation();
    }
    public void GunRotation(){
        Vector3 distance = (InputManager.Instance.mouseWorldPos - transform.position);
        distance.Normalize();
        float rotateZ = Mathf.Atan2(distance.y,distance.x)*Mathf.Rad2Deg;
        transform.rotation=Quaternion.Euler(0f,0f,rotateZ - 90);
    }
    

}
