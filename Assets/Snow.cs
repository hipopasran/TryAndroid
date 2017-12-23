using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetString("Snow") == "off")
        {
            gameObject.GetComponent<ParticleSystem>().Stop();
        }
        if(PlayerPrefs.GetString("Snow") == "on")
        {
            gameObject.GetComponent<ParticleSystem>().Play();
        }
	}
}
