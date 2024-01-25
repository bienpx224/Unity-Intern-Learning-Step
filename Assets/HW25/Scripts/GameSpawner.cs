using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject[] enemyPrefabs;
    int randomSpawnPoint;
    int randomEnemy;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, 10f);
    }
    void SpawnEnemy()
    {
        randomSpawnPoint = Random.Range(0, spawnPoint.Length);

        randomEnemy = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[randomEnemy], spawnPoint[randomSpawnPoint].position, Quaternion.identity);

    }
}
