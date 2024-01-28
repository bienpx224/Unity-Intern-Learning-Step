using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerController : MonoBehaviour
{
    [SerializeField] private float spawnRadius = 7, time = 3.5f;
    public GameObject enemies;
    public GameObject player;
    void Start()
    {
        StartCoroutine(IESpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator IESpawnEnemy()
    {
        Vector2 spawnPos = player.transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;
        Instantiate(enemies, spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(time);
        StartCoroutine(IESpawnEnemy());
    }
}
