using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private float maxSpeed = 12f;
    private float minSpeed = 18f;
    private float torques = 10f;
    private float xRangeX = 4f;
    private float ySponPos = 6f;
    
    
    private void Start()
    {
        targetRb = GetComponent<Rigidbody>(); //Tells the game to check for rigidbody.
        
        targetRb.AddForce(RandomForce(), ForceMode.Impulse); //See RandomForce method.
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);//see RandomTorque method.
        transform.position = (RandomSpawnPos()); //see RandomSpawnPos function.
    }
    
    // private void Update()
    // {
    //     
    // }

    Vector3 RandomForce() //Adds a random amount of force upward as GO's instantiate onto scene.
    {
        return Vector3.up * Random.Range(maxSpeed, minSpeed);
    }

    float RandomTorque() //Adds a random spin to the GO's as they move in game.
    {
        return Random.Range(-torques,torques);
    }

    Vector3 RandomSpawnPos() //Creates a random spawn position.
    {
        return new Vector3(Random.Range(-xRangeX,xRangeX), -ySponPos);
    }
    
}
