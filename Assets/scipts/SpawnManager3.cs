using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager3 : MonoBehaviour
{
    public GameObject[] enemies;

    private float zEnemySpawn = 17.0f;
    private float xEnemySpawn = 49.0f;

    private float startDelay = 0.5f;
    private float enemySpawnTime = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Startgame3()
    {
        InvokeRepeating("SpawnEnemy", startDelay, enemySpawnTime);
    }
    
    // Update is called once per frame
    public void Update()
    {
       
    }

    void SpawnEnemy()
    {
        float randomz = Random.Range(-zEnemySpawn, zEnemySpawn);
        int randomIndex = Random.Range(0, enemies.Length);
        
        Vector3 spawnPos = new Vector3(xEnemySpawn, 0.75f, randomz); 
        
        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation); 
    }
}
