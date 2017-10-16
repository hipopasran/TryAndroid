using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class GameScript : MonoBehaviour {

	// Use this for initialization
	void Awake() {
        PlayGamesPlatform.Activate();


        //if (!Social.localUser.authenticated)
        //{
        //    Social.localUser.Authenticate((bool success) =>
        //    {
        //        // Удачно или нет?
        //        if (success) print("123");
        //        else print("456");
        //    });
        //}

        
    }
	
	
}
