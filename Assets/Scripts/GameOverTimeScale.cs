using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTimeScale : MonoBehaviour {
    public float timeRemaining = 10f;

    public GameObject coin;
	// Update is called once per frame
	
        void Update () {

        coin = GameObject.Find("coin(Clone)");
        Destroy(coin);
            if (timeRemaining > 0)
            {
                //Debug.Log("Waitting..." + timeRemaining);
                timeRemaining -= Time.deltaTime;
                if (timeRemaining < 1) { Time.timeScale = 0; }
            }

        }
    
}
