using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public float moveleftspeed = 5f;
    
    void Update()
    {
        transform.Translate(Vector3.left* Time.deltaTime * moveleftspeed);
    }
}
