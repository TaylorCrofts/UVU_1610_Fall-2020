using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{ //array holds multiples of values
    //0 is the first in a sequence when tha placeholder is being followed by an array.
   
    public GameObject[] animalPrefabs;
    public float spawnRangeX =20f;
    public float spawnPossZ =20f;
    private float startDelay = 2f;

    private void Start()
    {
        var spawnInterval= Random.Range(2, 5f);
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0, spawnPossZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length); Debug.Log(animalIndex);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}

 //NOTES:
            //randomly generate animals at random transform.positions
            //Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0, spawnPossZ);
            //("prefab".Length gives you the max that is assigned and available to be called)
            //int animalIndex = Random.Range(0, animalPrefabs.Length);
            //debug.log (takes variable) gives you its call (Number, name)
            //Debug.Log(animalIndex);
            //instantiate has 3 parts. The thing you want to bring into the scene (gameobject/prefab, the spawn position of the object, and the rotation of the object)
            //Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);