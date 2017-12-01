using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bootsIcon : MonoBehaviour {

    public GameObject boots;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!boots.activeInHierarchy)
        {
            this.gameObject.SetActive(false);
        }
	}
}
