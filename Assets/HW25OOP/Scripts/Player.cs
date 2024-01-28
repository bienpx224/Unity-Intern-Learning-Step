using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class Player : Characters
{
    public static Player instance;
    public static Player Instnace { get => instance; }
    [SerializeField] protected Vector3 worldPosOOP;
    [SerializeField] protected float reloadTime = 2f;
    [SerializeField] protected int mag = 5;
    [SerializeField] public GunController gun;
    [SerializeField] public bool isReloading = false;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        InitStats();
        GunController.fireAction += Reload;
    }
    private void InitStats()
    {
        hp = 1;
        atk = 1;
    }
    void Update()
    {
        Movement();
      

    }
    private void FixedUpdate()
    {
        Onfire();
    }
    protected override void Movement()
    {
        base.Movement();
        worldPosOOP = InputOOP.InstanceOOP.MouseWorldPosOOP;
        Vector2 directionOOP = new Vector2(worldPosOOP.x-transform.position.x,worldPosOOP.y-transform.position.y);
        transform.up = directionOOP;
    }
    protected override void Onfire()
    {
        base.Onfire();
        if (InputOOP.InstanceOOP.isClick)
        {
            if (isReloading) return;
            gun.Onfiring();
        }
      
    }
    private void Reload()
    {
        mag--;
        if (mag != 0) return;
         StartCoroutine(IEReload());
    }
    IEnumerator IEReload()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);
        mag = 5;
        isReloading = false;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
