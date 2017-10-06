using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Advertisements;

public class GameControll : MonoBehaviour {

    void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("1566118", true);
        }
    }

   
}
