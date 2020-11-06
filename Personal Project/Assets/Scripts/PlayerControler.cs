using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        //On start I want the game to auto apply a starting forward momentum.
        //and this will trigger a starting animation "wiggle"
    }

    // Update is called once per frame
    void Update()
    {
        //I want players to be able to "jump" and "wreak" 
        //But since the point is to keep going the player doesn't need to control
        //forward or backward momentum they will gain speed as they go.
    }
}
//player will need animations tied to speed, health, and ability use
//Ability "bash" is a downward applied force that that is equal to half the speed 
//player is making. obsticals that take enough force will be destroyed 
//obsticals that are destroid by the player obsorb the momentum and so the player is slowed


