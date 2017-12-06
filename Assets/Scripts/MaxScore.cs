using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;


public class MaxScore : MonoBehaviour {

 void Start()
    {
        PlayGamesPlatform.Activate();
        GetComponent<Text>().text = PlayerPrefs.GetInt("Points").ToString();
        Social.ReportScore(PlayerPrefs.GetInt("Points"), "CgkIv-vamLwREAIQAQ", (success) => {
            // Удачно или нет?
        });

    }
}
