using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject Bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { 
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(Bullet);
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
        }
	}
}
