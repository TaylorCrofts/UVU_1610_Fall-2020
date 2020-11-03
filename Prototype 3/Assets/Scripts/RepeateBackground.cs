using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeateBackground : MonoBehaviour
{
    private Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    
    void Update()
    {
        if (transform.position.x <startPos.x -50)
        {
            transform.position = startPos;
        }
    }
}
