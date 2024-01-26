using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOOP : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletMovement();
    }
    private void BulletMovement()
    {
        transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
    }
}
