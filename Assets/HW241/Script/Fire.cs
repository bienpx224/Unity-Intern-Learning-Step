using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] protected Transform bullet;
    private static Fire instance;
    public static Fire Instance {get => instance;}
    [SerializeField] private int bulletMagazine = 5;
    private bool isOnReload = false;
    void Start()
    {
        instance=this;
    }
    void Update()
    {
        IsFire();
        Reload();
    }
    private void Reload(){
        if(bulletMagazine > 0) return;
        StartCoroutine(Reloading());
    }
    private IEnumerator Reloading(){
        isOnReload = true;
        yield return new WaitForSeconds(2f);
        bulletMagazine = 5;
        isOnReload = false;
    }
    private void IsFire()
    {
        if (InputManager.Instance.isClick && !isOnReload)
        {
            Vector3 spawnPos = transform.parent.position;
            Quaternion rotation = transform.parent.rotation;
            Instantiate(this.bullet, spawnPos, rotation);
            bulletMagazine--;
        }
    }
}
