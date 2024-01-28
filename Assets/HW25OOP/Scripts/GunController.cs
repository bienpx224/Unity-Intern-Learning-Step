using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public static GunController instance;
    public static GunController Instnace { get => instance; }
    [SerializeField] public GameObject Bullet;
    public delegate void FireActtion();
    public static FireActtion fireAction;
    float fireRate = 0.3f;
    float nextFire = 0;
    public float bulletCount = 0;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

    }
    void Update()
    {
    
    }
    public void Onfiring()
    {
        if (Time.time > nextFire)
        {
            fireAction?.Invoke();
            bulletCount++;
            nextFire = Time.time + fireRate;
            Instantiate(Bullet, transform.position, transform.rotation);
        }
          
    }
}
