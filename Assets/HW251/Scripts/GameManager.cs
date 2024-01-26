using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform enemy;
    private Vector3 example = new Vector3(4f,4f,4f);
    private void SpawnEnemy()
    {
        Instantiate(enemy,example,Quaternion.identity);
    }
    private void EnemySpawnTime(){
        StartCoroutine(TimeToSpawn());
    }
    private IEnumerator TimeToSpawn(){
        yield return new WaitForSeconds(3f);   
        SpawnEnemy();
    }
}
