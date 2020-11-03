using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagement : MonoBehaviour
{
    public GameObject gamePrefab;
    private Vector3 sponPos=new Vector3(25,0,0);
    private float startDelay = 2f;
    private float repeatRates = 2f;


    void Start()
    {
        InvokeRepeating("SpawnObstical", startDelay, repeatRates);
    }

    void SpawnObstical()
    {
        Instantiate(gamePrefab, sponPos, gamePrefab.transform.rotation);
    }
}
