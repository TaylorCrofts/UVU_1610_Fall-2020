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
    
    void Update()
    {
      
        Vector3 ObjectiveDirection = (playerGoal.transform.position - transform.position).normalized;
        
        enemyRb.AddForce(ObjectiveDirection * speed);

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
            Debug.Log("GOAL!");
        }
    }

}
