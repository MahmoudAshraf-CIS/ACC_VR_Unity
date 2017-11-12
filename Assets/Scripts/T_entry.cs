using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_entry : MonoBehaviour
{
    public GameObject targer_prefap;
    public List<Transform> Instantiation_points;
    public GameObject targets_parent;

	// Use this for initialization
	void Start () {
      
        //t.transform.rotation = Instantiation_point.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (Instantiation_points != null)
        {
            for (int i = 0; i < Instantiation_points.Count; i++)
            {
                var t = Instantiate(targer_prefap);
                t.transform.position = Instantiation_points[i].position;
                t.transform.rotation = Instantiation_points[i].rotation;
                t.transform.SetParent(targets_parent.transform);
            }
        }
    }

}
