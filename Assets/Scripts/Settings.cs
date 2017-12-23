using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {


    public GameObject music_on, music_off, sound_on, sound_off;
    public GameObject snow_on, snow_off;
    
    void Update()
    {
        if (PlayerPrefs.GetString("Music") == "off")
        {
            music_on.SetActive(false);
            music_off.SetActive(true);
        }
        if (PlayerPrefs.GetString("Music") == "on")
        {
            music_on.SetActive(true);
            music_off.SetActive(false);
        }
        if (PlayerPrefs.GetString("Sound") == "off")
        {
            sound_on.SetActive(false);
            sound_off.SetActive(true);
        }
        if (PlayerPrefs.GetString("Sound") == "on")
        {
            sound_on.SetActive(true);
            sound_off.SetActive(false);
        }
        if (PlayerPrefs.GetString("Snow") == "off")
        {
            snow_on.SetActive(false);
            snow_off.SetActive(true);
        }
        if (PlayerPrefs.GetString("Snow") == "on")
        {
            snow_on.SetActive(true);
            snow_off.SetActive(false);
        }

    }

    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "music_on":
                PlayerPrefs.SetString("Music", "off");
                

                break;
            case "music_off":
                PlayerPrefs.SetString("Music", "on");

                break;
            case "sounds_on":
                PlayerPrefs.SetString("Sound", "off");

                break;
            case "sounds_off":
                PlayerPrefs.SetString("Sound", "on");

                break;
            case "snow_on":
                
                PlayerPrefs.SetString("Snow", "off");

                break;
            case "snow_off":
                
                PlayerPrefs.SetString("Snow", "on");

                break;
        }

    }

      
}
