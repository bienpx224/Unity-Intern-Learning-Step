using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float minSpawnTime;
    [SerializeField] private float maxSpawnTime;
    [SerializeField] private Transform target;
    private float spawnTime;
    private float moveSpeed = 0.1f;
    private void Awake()
    {
        SetTimeUntilSpawn();
    }
    private void Update()
    {
        spawnTime -= Time.deltaTime;
        if(spawnTime <= 0)
        {
            var newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            Rigidbody2D enemyRb = new Rigidbody2D();
            SetTimeUntilSpawn();
        }
        transform.LookAt(target);
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
    void SetTimeUntilSpawn()
    {
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }
}
