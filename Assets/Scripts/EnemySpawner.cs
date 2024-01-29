using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float minSpawnRate;
    [SerializeField] private float maxSpawnRate;
    private float timeUntilSpawn;
    private void Awake()
    {
        SetTimeUntilSpawn();
    }
    private void Update()
    {
        timeUntilSpawn -= Time.deltaTime;
        if (timeUntilSpawn <= 0)
        {
            SpawnEnemy();
            SetTimeUntilSpawn();
        }
    }
    private void SetTimeUntilSpawn()
    {
        timeUntilSpawn = Random.Range(minSpawnRate, maxSpawnRate);
    }
    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}
