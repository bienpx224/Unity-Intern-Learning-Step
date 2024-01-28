using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    [SerializeField] private Vector3 spawnPos = new Vector3(3f, 3f, 3f);
    [SerializeField] private GameObject playerPos;
    [SerializeField] private float spawnRadius = 4f;
    [SerializeField] private float angleInDegrees = 45f;
    [SerializeField] private float spawnTime = 3f;
    [SerializeField] private Transform enemyPrefab;

    private void OnEnable()
    {
        SpawnEnemy();
    }
    private void SpawnEnemy()
    {
        StartCoroutine(IESpawnEnemy());
    }
    private void SetSpawnPosition()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player");
        if (playerPos == null) return;
        float randomAngle = Random.value;
        angleInDegrees = randomAngle * 360;
        float angleInRadians = Mathf.Deg2Rad * angleInDegrees;
        float spawnX = playerPos.transform.position.x + spawnRadius * Mathf.Cos(angleInRadians);
        float spawnY = playerPos.transform.position.y + spawnRadius * Mathf.Sin(angleInRadians);
        spawnPos = new Vector3(spawnX, spawnY, 0);
    }
    private IEnumerator IESpawnEnemy()
    {
        while (true)
        {
            SetSpawnPosition();
            yield return new WaitForSeconds(spawnTime);
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }
    }
}
