using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public float moveleftspeed = 5f;
    private float leftBound = -15f;
    public PlayerController playerControllerscript;

    private void Start()
    {
        playerControllerscript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (playerControllerscript.gameOver==false)
        {
           transform.Translate(Vector3.left* Time.deltaTime * moveleftspeed); 
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstical"))
        {
          Destroy(gameObject);  
        }
    }
}
