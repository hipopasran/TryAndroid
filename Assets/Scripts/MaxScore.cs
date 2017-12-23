using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;


public class MaxScore : MonoBehaviour {

    public GameObject snow;
    public GameObject Tutor;
    public GameObject NewPers;
    private int month;

 void Start()
    {
        PlayerPrefs.SetString("Tutor", "");
        PlayerPrefs.SetString("NewPers", "");
        PlayGamesPlatform.Activate();
        GetComponent<Text>().text = PlayerPrefs.GetInt("Points").ToString();
        Social.ReportScore(PlayerPrefs.GetInt("Points"), "CgkIv-vamLwREAIQAQ", (success) => {
            // Удачно или нет?
        });

        month = System.DateTime.Now.Month;
        if ((month == 12 || month <= 2))
        {
            snow.SetActive(true);
        }
        else
        {
            snow.SetActive(false);
        }
        
    }
    
    void Update()
    {
        if (PlayerPrefs.GetString("Tutor") == "")
        {
            Tutor.SetActive(true);
            PlayerPrefs.SetString("Tutor", "yes");
        }
        if ((PlayerPrefs.GetString("NewPers") == "") && (Tutor.gameObject.activeInHierarchy == false))
        {
            NewPers.SetActive(true);
            PlayerPrefs.SetString("NewPers", "yes");
        }
    }
  
   
}
