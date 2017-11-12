using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
    }

    public void AddEnemyKill()
    {
        score += 10;
    }

    public void AddPlayerHit()
    {
        score -= 1;
    }
}
