using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;

    private float zEnemySpawn = 49.0f;
    private float xEnemySpawn = 30.0f;

    private float startDelay = 0.5f;
    private float enemySpawnTime = 0.8f;
    
    public bool Alive;
    
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnEnemy", startDelay, enemySpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        //als de player leeft is dit actief
        if (Alive)
        {
            float randomX = Random.Range(-xEnemySpawn, xEnemySpawn);
            int randomIndex = Random.Range(0, enemies.Length);
        
            Vector3 spawnPos = new Vector3(randomX, 0.75f, zEnemySpawn);

            Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
        }
    }
}
