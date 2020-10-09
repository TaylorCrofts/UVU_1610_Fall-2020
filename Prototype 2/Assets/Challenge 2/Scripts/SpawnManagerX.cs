using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private readonly float spawnLimitXR = 10f;
    private readonly float spawnLimitXL = -35.5f;
    private readonly float spawnPosY = 30f;

    private readonly float startDelay = 2.0f;

    // Start is called before the first frame update
    private void Start()
    {
        var spawnInterval = Random.Range(3, 5f);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    private void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        var spawnPos = new Vector3(Random.Range(spawnLimitXL, spawnLimitXR), spawnPosY, 0);
        //Creates random ball generation when called.
        var ballindex = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballindex], spawnPos, ballPrefabs[ballindex].transform.rotation);
    }

}
