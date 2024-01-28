using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GunController : MonoBehaviour
{
    [SerializeField] private Transform bullet;
    public delegate void FireAction();
    public static event FireAction OnFire;
    private Transform rotationToLookAtTarget;
    public Transform LookAtTarget(){
        rotationToLookAtTarget=transform.parent;
        Vector3 distance = (InputManager.Instance.mouseWorldPos - transform.position);
        distance.Normalize();
        float rotateZ = Mathf.Atan2(distance.y, distance.x) * Mathf.Rad2Deg;
        rotationToLookAtTarget.transform.rotation = Quaternion.Euler(0f, 0f, rotateZ - 90);
        return rotationToLookAtTarget;
    }
    public void Fire(){
        if(OnFire!=null){
            OnFire();
        }
        transform.rotation = LookAtTarget().rotation;
        bullet.gameObject.SetActive(true);
        Instantiate(bullet, transform.position,LookAtTarget().rotation);
        bullet.gameObject.SetActive(false);

    }
   
}
