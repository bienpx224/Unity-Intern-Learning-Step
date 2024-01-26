using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
public class Gun25 : MonoBehaviour
{
    public GameObject Bullet;
    delegate void OnShootingProgress();
    OnShootingProgress onShootingProgress;
    //Fire rate
    float fireRate = 0.5f;
    float nextFire = 0;
    //TMP Text
    public TMP_Text totalFired;
    //Gun Mag
    [SerializeField]float mag = 5;
    float count=0;
    // Update is called once per frame
    void Update()
    {
        totalFired.text = count.ToString();
        
    }
    private void Start()
    {
        onShootingProgress += UpdateFireBoard;
    }
    private void FixedUpdate()
    {
        if (InputManagerHW25.Instance25.isClick25)
        {
            if (Time.time > nextFire && mag != 0)
            {
                onShootingProgress?.Invoke();
                mag--;
                nextFire = Time.time + fireRate;
                Instantiate(Bullet, transform.position, transform.rotation);
                if (mag == 0)
                    StartCoroutine(IEReload());
            }
        }
    }
    private void UpdateFireBoard()
    {
        count++;
    }
    IEnumerator IEReload()
    {
        yield return new WaitForSeconds(2f);
        mag = 5;
    }
}
