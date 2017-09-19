using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

    public Text pointText;

    public float points = 0;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        pointText.text = " "+points;
        

    }

    void FixedUpdate()
    {
        if (Time.timeScale > 0)
        {
            points = points + 1;
        }
    }
}
