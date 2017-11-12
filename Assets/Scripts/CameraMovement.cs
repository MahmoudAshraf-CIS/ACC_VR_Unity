using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 currRot;

    // Use this for initialization
    void Start()
    {
        currRot.y = 180f;
    }

    // Update is called once per frame
    void Update()
    {
        currRot.x -= Input.GetAxis("Mouse Y") * 4f;
        currRot.x = Mathf.Clamp(currRot.x, -90, 90);
        currRot.y += Input.GetAxis("Mouse X") * 4f;
        transform.localRotation = Quaternion.Euler(currRot);
    }
}
