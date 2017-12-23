using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPersActive : MonoBehaviour {

    public GameObject Tutor;
    // Use this for initialization
    void Start()
    {

        //if ((PlayerPrefs.GetString("NewPers") == "") && (Tutor.gameObject.activeInHierarchy==false))
        //{
        //    gameObject.SetActive(true);
        //    PlayerPrefs.SetString("NewPers", "yes");
        //}
         if(Tutor.activeInHierarchy==true)
        {
            gameObject.SetActive(false);
        }
        //else
        //{
        //    gameObject.SetActive(false);
        //}
    }
}
