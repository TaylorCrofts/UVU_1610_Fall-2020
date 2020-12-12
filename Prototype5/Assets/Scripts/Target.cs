using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    
    private void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(Vector3.up * Random.Range(12, 18), ForceMode.Impulse);
        targetRb.AddTorque(Random.Range(-10,10), Random.Range(-10,10), Random.Range(-10,10), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-4,4), -6);
    }
    
    // private void Update()
    // {
    //     
    // }
}
