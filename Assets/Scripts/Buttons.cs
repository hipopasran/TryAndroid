using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class Buttons : MonoBehaviour {

    
    public bool pause;
    //public string action;
    public GameObject resume,restart,pause1,home,rating,pause_text,options,stats;
    [SerializeField]
    private SettingPopup settingPopup;
    public bool activePopup=false;
   

    //void Start()
    //{
    //    // pause = false;
    //    Time.timeScale = 1;
    //}

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
    //void OnMouseDown()
    //{



    //}

    //void OnMouseUp()
    //{
    //    if (gameObject.name != "pause")
    //    {

    //    }
    //}

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
            case "stats":
                //Social.ShowLeaderboardUI();
                PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkIv-vamLwREAIQAQ");
                
                break;
            case "home":
                pause = false;
                Time.timeScale = 1;
                Application.LoadLevel("main");
                break;
            case "shop":
                Application.LoadLevel("shop");
                break;
            case "restart":
                pause = false;
                Time.timeScale = 1;
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
                    Time.timeScale = PlayerPrefs.GetFloat("GameScale");
                    settingPopup.Close();
                    rating.SetActive(false);
                    stats.SetActive(false);
                    pause = false;
                    options.SetActive(false);
                    resume.SetActive(false);
                    restart.SetActive(false);
                    home.SetActive(false);

                    pause_text.SetActive(false);
                }
                break;
            case "resume":
                Time.timeScale = PlayerPrefs.GetFloat("GameScale");
                options.SetActive(false);
                pause_text.SetActive(false);
                pause = false;
                resume.SetActive(false);
                restart.SetActive(false);
                home.SetActive(false);
                settingPopup.Close();
                break;
            case "options":
                if (activePopup== false)
                {
                    if (Application.loadedLevelName == "play")
                    {
                        pause_text.SetActive(false);
                    }
                    settingPopup.Open();
                    activePopup = true;


                }
                else if (activePopup == true)
                {

                    settingPopup.Close();
                    if (Application.loadedLevelName == "play")
                    {
                        pause_text.SetActive(true);
                    }
                   
                    activePopup = false;
                }
                break;
        }
    }
}
