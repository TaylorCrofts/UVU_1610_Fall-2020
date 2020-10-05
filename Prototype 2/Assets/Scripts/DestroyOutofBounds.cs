using System;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    public float topBounds = 30f;
    public float lowerBounds= -10f;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (transform.position.z>topBounds)
        {
            Destroy(gameObject);
            //Will destroy object exiting the topbounds of camera view
        }
        else if (transform.position.z < lowerBounds)
        {
            Debug.Log("GameOver");
            Destroy(gameObject);
            Time.timeScale = 0;
            //will destroy object exiting lowerbounds of camera view
        }
    }
}