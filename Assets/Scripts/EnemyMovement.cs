using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform camTrans;

    // Use this for initialization
    void Start()
    {
        camTrans = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // getting direction then normalizing it
        var direction = (camTrans.position - this.transform.position).normalized;
        
        transform.Translate(direction * 0.2f);
    }
}
