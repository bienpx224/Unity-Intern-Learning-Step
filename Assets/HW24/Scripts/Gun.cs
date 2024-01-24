using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public GameObject Bullet;
    float fireRate = 0.5f;
    float nextFire = 0;
    public TMP_Text totalFired;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
    
    }
    void Update()
    {
        totalFired.text = count.ToString();
    }
    private void FixedUpdate()
    {
        if (Time.time > nextFire)
        {
            count++;
            nextFire = Time.time + fireRate;
            Instantiate(Bullet, transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
   
}
