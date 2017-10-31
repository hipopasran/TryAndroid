using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins_main : MonoBehaviour {

    public Text textCoin;

	// Use this for initialization
	void Update () {
        textCoin.text=PlayerPrefs.GetInt("Coins").ToString();
    }
	
	
}
