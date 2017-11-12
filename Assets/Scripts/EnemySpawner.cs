using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;

    private float timer;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if( timer > 0)
        {
            timer -= Time.deltaTime;
            return;
        }

        timer = 2f;

        var randPos = this.transform.position;
        randPos.x += Random.Range(-40f, 40f);

        var enemy = Instantiate(EnemyPrefab);
        enemy.transform.SetParent(this.transform);
        enemy.transform.position = randPos;
    }
}
