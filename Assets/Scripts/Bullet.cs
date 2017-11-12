using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    private float DestroyAfterInSeconds = 15f;
    public static ScoreManager scoreManager;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, DestroyAfterInSeconds);
        scoreManager = FindObjectOfType<ScoreManager>();

	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, 0.2f);
	}


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.tag == "Target")
        {
            Debug.Log("collision Target");
            Destroy(collision.gameObject);
            TargetHit();
        }
        Destroy(this.gameObject);
    }

    void TargetHit()
    {
        if (scoreManager != null)
        {
            scoreManager.AddTargetHit();
        }       
    }
}
