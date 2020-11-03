using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagement : MonoBehaviour
{
    public GameObject gamePrefab;
    private Vector3 sponPos=new Vector3(25,2,0);
    private float startDelay = 2f;
    private float repeatRates = 2f;
    public PlayerController playerControllerScript;

    void Start()
    {
        InvokeRepeating("SpawnObstical", startDelay, repeatRates);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstical()
    {
        if (playerControllerScript.gameOver==false)
        {
            Instantiate(gamePrefab, sponPos, gamePrefab.transform.rotation);
        }
    }
}