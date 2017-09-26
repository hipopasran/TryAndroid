using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

    
    public bool pause = false;
    //public string action;
    public GameObject resume,restart,pause1,home,rating,pause_text,options;
    [SerializeField]
    private SettingPopup settingPopup;
    public bool activePopup=false;


    void Update()
    {
        if(Time.timeScale == 0)
        {
            pause = true;
           
        }
        else
        {
            pause = false;
            
        }
    }
    void OnMouseDown()
    {



    }

    void OnMouseUp()
    {
        if (gameObject.name != "pause")
        {

        }
    }

    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "play":
                Application.LoadLevel("play");
                break;
            case "rating":
                Application.OpenURL("http://google.com");
                break;
            case "home":
                Application.LoadLevel("main");
                break;
            case "restart":
                Application.LoadLevel(Application.loadedLevel);
                break;
           
            case "pause":
                if (pause == false)
                {

                    Time.timeScale = 0;
                    options.SetActive(true);
                    pause_text.SetActive(true);
                    pause = true;
                    resume.SetActive(true);
                    restart.SetActive(true);
                    home.SetActive(true);
                }
               else if(pause==true)
                {
                    Time.timeScale = 1;
                    
                    pause = false;
                    options.SetActive(false);
                    resume.SetActive(false);
                    restart.SetActive(false);
                    home.SetActive(false);
                    pause_text.SetActive(false);
                }
                break;
            case "resume":
                Time.timeScale = 1;
                options.SetActive(false);
                pause_text.SetActive(false);
                pause = false;
                resume.SetActive(false);
                restart.SetActive(false);
                home.SetActive(false);
                break;
            case "options":
                if (activePopup== false)
                {
                    pause_text.SetActive(false);
                    settingPopup.Open();
                    activePopup = true;


                }
                else if (activePopup == true)
                {

                    settingPopup.Close();
                    pause_text.SetActive(true);
                    activePopup = false;
                }
                break;
        }
    }
}
