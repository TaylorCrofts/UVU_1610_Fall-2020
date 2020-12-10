﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class PlayerControler : MonoBehaviour
{
    public float speed = 20f;
    public float jumpModifier = 10f;
    public float gravityModifier = 1f;
    private Rigidbody playerRB;
    public bool hasAbilityBash;
    public GameObject powerIndicator;


   void Start()
   { //Onstart we alert the inspector to check the rigidbody assigned.
       playerRB = GetComponent<Rigidbody>();
       Physics.gravity *= gravityModifier;
         
     }
    
   private void Update()
   {
      
   }
   private void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("PowerUp"))
       {
           hasAbilityBash = true;
           powerIndicator.gameObject.SetActive(true);
           Destroy(other.gameObject);
           StartCoroutine(PowerUpCountDownRoutine());
       }
   }

   private IEnumerator PowerUpCountDownRoutine()
   {
       yield return new WaitForSeconds(7);
       hasAbilityBash = false;
       powerIndicator.gameObject.SetActive(false);
   }
  
   private void OnCollisionWithAbility(Collision collision)
   {
       if (collision.gameObject.CompareTag("obsticle") && hasAbilityBash)
       {
           
       }
   }

   private void MoveControl(Physics physics)
   {
       if (Input.GetKeyDown(KeyCode.Space))
       {
           playerRB.AddForce(Vector3.up*jumpModifier,ForceMode.Impulse);
       }

       if (Input.GetKeyDown(KeyCode.D))
       {
           playerRB.AddForce(Vector3.right * speed, ForceMode.Force);
       } 
   }
}
 //On start I want the game to  auto apply a starting forward momentum.
        //and this will trigger a starting animation "wiggle"
 //I want players to be able to "jump" and "wreak" 
//OnCollision enter && health && bashPower triggered will destroy game object and apply damage to
//to health
      //Decided to let player control forward momentum for the time but later I want the game to auto start that movement
//forward or backward momentum they will gain speed as they go.
//player will need animations tied to speed, health, and ability use
//Ability "bash" is a downward applied force that that is equal to half the speed 
//player is making. obsticals that take enough force will be destroyed 
//obsticals that are destroid by the player obsorb the momentum and so the player is slowed

//Goals:
// #1. Get player to move - Check!
