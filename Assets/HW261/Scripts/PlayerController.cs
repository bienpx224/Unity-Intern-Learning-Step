using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : Charater
{
    private static PlayerController instance;
    public static PlayerController Instance { get => instance; }
    [SerializeField] private GunController gun;
    [SerializeField] private int bulletMag = 5;
    [SerializeField] public int bulletInMag = 5;
    [SerializeField] private bool isReloading = false;
    [SerializeField] private float reloadDuration = 2f;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        GunController.OnFire += ReloadManager;
    }
    private void Update()
    {
        Firing();
    }
    private void ReloadManager()
    {
        bulletInMag--;
        if (bulletInMag != 0) return;
        StartCoroutine(IEOnReload());
    }
    private IEnumerator IEOnReload()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadDuration);
        bulletInMag = bulletMag;
        isReloading = false;
    }
    protected override void Firing()
    {
        if (InputManager.Instance.isClick)
        {
            if (isReloading) return;
            gun.Fire();
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            TakingDamage();
        }
    }
    protected override void TakingDamage()
    {
        healPoint--;
        if (healPoint >= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
