﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnRate = 1.0f;
    private int Score;
    public TextMeshProUGUI scoreText;
    
    
    void Start()
    {
        StartCoroutine(SpawnTarget());
        Score = 0;
        UpdateScore(0);
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void UpdateScore(int scoreAdd)
    {
        Score += scoreAdd;
        scoreText.text = "Score: " + Score;
    }
}
