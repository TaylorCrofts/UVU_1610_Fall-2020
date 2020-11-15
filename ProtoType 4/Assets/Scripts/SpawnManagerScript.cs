using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnR = 9.0f;
    void Start()
    {
        Instantiate(enemyPrefab, GenerateSpawnPos(), enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 GenerateSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnR, spawnR);
        float spawnPosZ = Random.Range(-spawnR, spawnR);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}
