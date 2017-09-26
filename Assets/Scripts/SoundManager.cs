using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
        AudioSource audio = GetComponent<AudioSource>();
        if (PlayerPrefs.GetString("Sound") == "off")
        {
            audio.mute = true;
        }
        if (PlayerPrefs.GetString("Sound") == "on")
        {
            audio.mute = false;
        }
    }
}
