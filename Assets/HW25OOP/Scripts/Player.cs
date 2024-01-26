using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class Player : Characters
{
    [SerializeField] protected Vector3 worldPosOOP;
    [SerializeField] protected float reloadTime = 2f;
    [SerializeField] protected int mag = 5;
    public GunOOP gun;
    void Start()
    {
        InitStats();
    }
    private void InitStats()
    {
        hp = 1;
        atk = 1;
    }
   
    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    private void FixedUpdate()
    {
        Onfire();
    }
    public override void Movement()
    {
        base.Movement();
        worldPosOOP = InputOOP.InstanceOOP.MouseWorldPosOOP;
        Vector2 directionOOP = new Vector2(worldPosOOP.x-transform.position.x,worldPosOOP.y-transform.position.y);
        transform.up = directionOOP;
    }
}
