using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

    public Sprite layer_one, layer_two;
    private bool pause = false;
    //public string action;

	void OnMouseDown()
    {

        GetComponent<SpriteRenderer>().sprite = layer_two;

    }

    void OnMouseUp()
    {
        if (gameObject.name != "pause")
        {
            GetComponent<SpriteRenderer>().sprite = layer_one;
        }
    }

    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "play":
                Application.LoadLevel("play");
                break;
            case "rating":
                Application.OpenURL("http://google.com");
                break;
            case "pause":
                if (pause == false)
                {
                    Time.timeScale = 0;
                    GetComponent<SpriteRenderer>().sprite = layer_two;
                    pause = true;
                }
               else if(pause==true)
                {
                    Time.timeScale = 1;
                    GetComponent<SpriteRenderer>().sprite = layer_one;
                    pause = false;
                }
                break;
        }
    }
}
