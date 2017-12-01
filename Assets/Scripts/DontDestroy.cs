using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(GameObject.FindGameObjectsWithTag("Audio").Length==1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        
	}
	
	
}
