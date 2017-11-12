using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
       
    protected int score=0, step = 1;
    public Text screenScoreTxt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void AddTargetHit(){
       score += step;
       screenScoreTxt.text = "Score :- " + score.ToString();
    }

}
