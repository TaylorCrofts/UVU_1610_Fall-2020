using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagement : MonoBehaviour
{
    public GameObject gamePrefab;
    private Vector3 sponPos = new Vector3(25,0,-1);
    void Start()
    {
        Instantiate(gamePrefab, sponPos, gamePrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
