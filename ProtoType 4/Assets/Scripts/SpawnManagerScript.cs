using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;
    public float spawnR = 9.0f;
    public int enemyCount;
    public int waveNumber = 1;
    
    void Start()
    {
        SpawnPowerUps(waveNumber);
        SpawnEnemyWave(waveNumber);
    }
    void Update()
    {
        enemyCount = FindObjectsOfType<EnemyBehaviorScript>().Length;
       
        if (enemyCount== 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            SpawnPowerUps(waveNumber);
        }
    }

    void SpawnPowerUps(int powerUpsToSpawn)
    {
        for (int i = 0; i < powerUpsToSpawn; i++)
        {
            Instantiate(powerUpPrefab, GenerateSpawnPos(), powerUpPrefab.transform.rotation);
        }
    }
    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPos(), enemyPrefab.transform.rotation);
        }
    }
    private Vector3 GenerateSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnR, spawnR);
        float spawnPosZ = Random.Range(-spawnR, spawnR);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}
