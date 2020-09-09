using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//class name and file name need to be the same.
public class Playercontroller : MonoBehaviour
{
    //only things assigned as public, are public variables.
    public int speed =20; //Speed is a variable 
    //usually if something is private you can't see it int the inspector.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0,0,5); Vector3 is the (x,y,z).
        //translate requires direcional imput.

        //+(Causes Errors, don't know why, NEEDS WORK) Transform.Translate(Vector3.forward * Time.deltaTime * speed);
       
        //becasue update runs on frame and frame is variable based on computer
        //we uses time.deltatime to go based off of seconds.
        //we made a variable to explain the speed(named it speed)=value
    }
}
