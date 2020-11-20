using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    
    void Start()
    { 
        playerGoal = GameObject.Find("Player Goal");
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there. The computer should determine that the space the ball needs to move
        //is it's own position - the position of the goal.
        Vector3 ObjectiveDirection = (playerGoal.transform.position - transform.position).normalized;
        
        //This should add force to enemy to get it to move.
        enemyRb.AddForce(ObjectiveDirection * speed);

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
