using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorActive : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetString("Tutor")=="")
        {
            gameObject.SetActive(true);
            PlayerPrefs.SetString("Tutor", "yes");
        }
        else
        {
            gameObject.SetActive(false);
        }
	}
	
	
}
