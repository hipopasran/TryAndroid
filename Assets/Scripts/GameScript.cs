using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class GameScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayGamesPlatform.Activate();

        Social.localUser.Authenticate((bool success) => {
            // Удачно или нет?
            if (success) print("123");
            else print("456");
        });
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
