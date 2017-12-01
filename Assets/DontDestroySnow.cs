using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroySnow : MonoBehaviour {

    void Start()
    {
        if (GameObject.FindGameObjectsWithTag("Snow").Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }


    }
}
