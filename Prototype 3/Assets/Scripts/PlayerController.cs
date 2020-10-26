using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRB;
    
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(Vector3.up*10,ForceMode.Impulse);
        }
    }
}
