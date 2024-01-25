using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Gun25 : MonoBehaviour
{
    public GameObject Bullet;
    float fireRate = 1f;
    float nextFire = 0;
    public TMP_Text totalFired;

    [SerializeField]float mag = 5;
    float count=0;
    // Update is called once per frame
    void Update()
    {
        totalFired.text = count.ToString();
        
    }
    private void FixedUpdate()
    {
        if (InputManagerHW25.Instance25.isClick25)
        {
            if (Time.time > nextFire && mag != 0)
            {
                count++;
                mag--;
                nextFire = Time.time + fireRate;
                Instantiate(Bullet, transform.position, transform.rotation);
                if (mag == 0)
                    StartCoroutine(IEReload());
            }
        }
    }
    IEnumerator IEReload()
    {
        yield return new WaitForSeconds(2f);
        mag = 5;
    }
}
