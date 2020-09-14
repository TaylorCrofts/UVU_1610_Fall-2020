using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed= 20;
    
    // Start is called before the first frame update
    void Start()
    {
        print("Is moving");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward *Time.deltaTime*speed);
        //move the vehicle 
    }
}
