using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class Buttons : MonoBehaviour {

    
    public bool pause;
    //public string action;
    public GameObject resume,restart,pause1,home,rating,pause_text,options,stats;
    [SerializeField]
    private SettingPopup settingPopup;
    public bool activePopup=false;

   void Awake()
    {
        PlayGamesPlatform.Activate();
    }

    void Start()
    {
        //    // pause = false;
        //    Time.timeScale = 1;

        //PlayGamesPlatform.Activate();
        if (!Social.localUser.authenticated)
        {
            Social.localUser.Authenticate((bool success) =>
            {
                // Удачно или нет?
                if (success) print("123");
                else print("456");
            });
        }

    }

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
                if (Social.localUser.authenticated)
                {
                   
                    //Social.ShowLeaderboardUI();
                    //PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkIv-vamLwREAIQAQ");
                    ((PlayGamesPlatform)Social.Active).ShowLeaderboardUI("CgkIv-vamLwREAIQAQ");
                }
                else
                {
                   // Application.LoadLevel("main");
                }
                break;
            case "home":
                pause = false;
                Time.timeScale = 1;
                Application.LoadLevel("main");
                break;
            case "shop":

                Social.ReportProgress("CgkIv-vamLwREAIQBg", 100.0f, (bool success) => {
                    // Удачно или нет?
                });

                Application.LoadLevel("shop");
                break;
            case "restart":
                pause = false;
                Time.timeScale = 1;
                Application.LoadLevel(Application.loadedLevel);
                break;
           
            case "pause":

                Social.ReportProgress("CgkIv-vamLwREAIQBQ", 100.0f, (bool success) => {
                    // Удачно или нет?
                });

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
