using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    private ScoreManager scoreMgr;

    // Use this for initialization
    void Start()
    {
        scoreMgr = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);

        var tag = collision.gameObject.tag;

        if (tag == "Player")
            scoreMgr.AddPlayerHit();
        if (tag == "Bullet")
            scoreMgr.AddEnemyKill();
    }
}
