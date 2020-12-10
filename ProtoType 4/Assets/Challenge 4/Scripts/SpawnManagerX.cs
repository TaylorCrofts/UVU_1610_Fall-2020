using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;

    public float enemySpeed = 1.0f;

    private readonly float spawnRangeX = 10f;
    private readonly float spawnZMin = 15f; // set min spawn Z
    private readonly float spawnZMax = 25f; // set max spawn Z

    public int enemyCount;
    public int waveCount = 1;


    public GameObject player;

    private void Start()
    {
        SpawnEnemyWave(waveCount);
        SpawnPowerUps(waveCount);
    }

    private void Update()
    {
        enemyCount = FindObjectsOfType<EnemyX>().Length;

        if (enemyCount == 0)
        {
            enemySpeed++;
            waveCount++;
            SpawnEnemyWave(waveCount);
            SpawnPowerUps(waveCount);
        }
    }

    // Generate random spawn position for powerups and enemy balls
    private Vector3 GenerateSpawnPosition()
    {
        var xPos = Random.Range(-spawnRangeX, spawnRangeX);
        var zPos = Random.Range(spawnZMin, spawnZMax);
        return new Vector3(xPos, 0, zPos);
    }


    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        // Spawn number of enemy balls based on wave number
        for (var i = 0; i < enemiesToSpawn; i++)
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);

        waveCount++;
        enemyCount += 1;
        ResetPlayerPosition(); // put player back at start
    }

    private void SpawnPowerUps(int powerUpsToSpawn)
    {
        var powerupSpawnOffset = new Vector3(0, 0, -15); // make powerups spawn at player end

        // If no powerups remain, spawn a powerup
        if (GameObject.FindGameObjectsWithTag("Powerup").Length == 0) // check that there are zero powerups
            Instantiate(powerupPrefab, GenerateSpawnPosition() + powerupSpawnOffset, powerupPrefab.transform.rotation);
    }

    // Move player back to position in front of own goal
    private void ResetPlayerPosition()
    {
        player.transform.position = new Vector3(0, 1, -7);
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
