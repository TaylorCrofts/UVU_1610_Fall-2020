using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    public GameObject playerGoal;
    
    void Start()
    {
    //There has yet to be an "enemy" gameObject that is instanced in start so the script doesn't know what it's doing.
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there     Rotation?
        Vector3 lookDirection = (playerGoal.transform.position + transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal" && other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
            Debug.Log("GOAL!");
        }
    }

}
