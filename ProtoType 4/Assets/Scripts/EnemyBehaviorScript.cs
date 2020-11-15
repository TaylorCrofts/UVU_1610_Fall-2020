using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorScript : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody enemyRB;
    private GameObject player;
    
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player =GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 determineDirection = (player.transform.position - transform.position).normalized;
        enemyRB.AddForce( determineDirection * speed);
    }
}