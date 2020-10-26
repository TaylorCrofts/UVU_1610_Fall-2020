using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpModifier = 10f;
    public float gravityModifier = 1f;
    public bool isOnGround = true;
    private Rigidbody playerRB;
    
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRB.AddForce(Vector3.up*jumpModifier,ForceMode.Impulse);
            isOnGround = false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}