using UnityEngine;

public class SpawnManager : MonoBehaviour
{ //array holds multiples of values
    //0 is the first in a sequence when tha placeholder is being followed by an array.
   
    public GameObject[] animalPrefabs;
    public int animalIndex;
    public float spawnRangeX =20f;
    public float spawnPossZ =20f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //randomly generate animals at random transform.positions
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0, spawnPossZ);
            
            //("prefab".Length gives you the max that is assigned and available to be called)
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            
            //debug.log (takes variable) gives you its call (Number, name)
            Debug.Log(animalIndex);
           
            //instantiate has 3 parts. The thing you want to bring into the scene (gameobject/prefab, the spawn position of the object, and the rotation of the object)
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
