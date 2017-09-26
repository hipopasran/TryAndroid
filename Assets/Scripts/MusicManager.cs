using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    
    
	
	// Update is called once per frame
	void Update () {
        AudioSource audio = GetComponent<AudioSource>();
        if (PlayerPrefs.GetString("Music")=="off")
        {
            audio.mute = true;
        }
        if (PlayerPrefs.GetString("Music") == "on")
        {
            audio.mute = false;
        }
    }
}
