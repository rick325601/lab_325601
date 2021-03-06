﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    public GameObject[] enemies;

    private float zEnemySpawn = -49.0f;
    private float xEnemySpawn = 30.0f;

    private float startDelay = 0.5f;
    private float enemySpawnTime = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Startgame2()
    {
        InvokeRepeating("SpawnEnemy", startDelay, enemySpawnTime);
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xEnemySpawn, xEnemySpawn);
        int randomIndex = Random.Range(0, enemies.Length);
        
        Vector3 spawnPos = new Vector3(randomX, 0.75f, zEnemySpawn);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }
}