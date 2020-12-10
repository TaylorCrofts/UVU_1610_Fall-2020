using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManagment : MonoBehaviour
{

    public GameObject player;
    private Vector3 distance = new Vector3(0,6,-14);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + distance;
    }
}
