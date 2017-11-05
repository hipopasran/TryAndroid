using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelColor : MonoBehaviour {
    void Start() {
        //PlayerPrefs.SetInt(gameObject.name + "active", 0);

    }
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt(gameObject.name + "active") == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
	}
}
