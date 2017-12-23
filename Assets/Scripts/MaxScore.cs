using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;


public class MaxScore : MonoBehaviour {

    public GameObject snow;
    private int month;

 void Start()
    {
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

   
}
