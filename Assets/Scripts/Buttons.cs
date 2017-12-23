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
    public GameObject resume,restart,pause1,home,rating,pause_text,options,stats,rate,vk,facebook,achiv,services,sign_out;
    [SerializeField]
    private SettingPopup settingPopup;
    [SerializeField]
    private SettingPopup Snow;
    public bool activePopup=false;
    public GameObject Tutor;
    public int month;

   void Awake()
    {
        PlayGamesPlatform.Activate();
    }

    void Start()
    {
        month = System.DateTime.Now.Month;
        //    // pause = false;
        //    Time.timeScale = 1;

        //PlayGamesPlatform.Activate();

        //    if (!Social.localUser.authenticated && services.activeInHierarchy==false)
        //    {
        //        Social.localUser.Authenticate((bool success) =>
        //        {
        //           // Удачно или нет ?
        //            if (success)
        //            {
        //                achiv.SetActive(true);
        //                stats.SetActive(true);
        //                services.SetActive(false);
        //                sign_out.SetActive(true);
        //                print("123");
        //            }
        //            else if (!success && Application.loadedLevel == 0)
        //            {

        //                achiv.SetActive(false);
        //                stats.SetActive(false);
        //                services.SetActive(true);
        //                print("456");
        //                sign_out.SetActive(false);
        //            }
        //});
        //    }
        if (!Social.localUser.authenticated)
        {
            if (Application.loadedLevel == 0)
            {
                achiv.SetActive(false);
                stats.SetActive(false);
                services.SetActive(true);
                print("456");
                sign_out.SetActive(false);
            }
            if(Application.loadedLevel==1)
            {
                sign_out.SetActive(false);
            }
        }
        else
        {
            if (Application.loadedLevel == 0)
            {
                achiv.SetActive(true);
                stats.SetActive(true);
                services.SetActive(false);
                sign_out.SetActive(true);
                print("123");
            }
            if(Application.loadedLevel==1)
            {
                sign_out.SetActive(true);
            }
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
            case "achiv":
                Social.ShowAchievementsUI();
                break;
            case "sign_out":
                PlayGamesPlatform.Instance.SignOut();
                achiv.SetActive(false);
                stats.SetActive(false);
                services.SetActive(true);
                sign_out.SetActive(false);
                break;

            case "services":
                Social.localUser.Authenticate((bool success) =>
                {
                    // Удачно или нет?
                    if (success)
                    {
                        achiv.SetActive(true);
                        stats.SetActive(true);
                        services.SetActive(false);
                        print("123");
                        sign_out.SetActive(true);
                        Social.ReportScore(PlayerPrefs.GetInt("Points"), "CgkIv-vamLwREAIQAQ", (bool success1) => {
                            // Удачно или нет?
                        });
                    }
                    else print("456");
                });
                break;
            case "facebook":
                Application.OpenURL("https://www.facebook.com/groups/1172761489491919/");
                break;
            case "vk":
                Application.OpenURL("https://vk.com/denoustudio");
                break;
            case "rate":
                Application.OpenURL("market://details?id=com.KedaVladimir.Helljump");
                break;

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
                    Social.localUser.Authenticate((bool success) =>
                    {
                        // Удачно или нет?
                        if (success)
                        {
                            ((PlayGamesPlatform)Social.Active).ShowLeaderboardUI("CgkIv-vamLwREAIQAQ");
                            services.SetActive(false);
                            print("123");
                            sign_out.SetActive(true);
                            
                        }
                        else
                        {
                            sign_out.SetActive(false);
                            print("456");
                        }
                    });
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
                    activePopup = true;
                    if (Application.loadedLevelName == "play")
                    {
                        pause_text.SetActive(false);
                    }
                    if (month == 12 || month == 1 || month == 2)
                    {
                        Snow.Open();
                    }
                    else
                    {
                        settingPopup.Open();
                    }
                    Tutor.SetActive(false);
                    activePopup = true;

                }
                else if (activePopup == true)
                {
                    activePopup = false;
                    if (month == 12 || month == 1 || month == 2)
                    {
                        Snow.Close();
                    }
                    else
                    {
                        settingPopup.Close();
                        
                    }

                    
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
