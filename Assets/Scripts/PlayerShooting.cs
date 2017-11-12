using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject BulletPrefab;

    public Transform MuzzleTrans;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(BulletPrefab);
            bullet.transform.position = MuzzleTrans.position;
            bullet.transform.rotation = MuzzleTrans.rotation;
        }
    }
}
