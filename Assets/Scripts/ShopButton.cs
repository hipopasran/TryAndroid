using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour {

    public GameObject whichModel;
    public GameObject selectBtn;
    public GameObject chooseBtn;
    public GameObject buyBtn;
    public Text Cost;
   


    void OnMouseUpAsButton()
    {
        switch(gameObject.name)
        {
            case "buy":
                if(PlayerPrefs.GetInt("Coins")>=500)
                {
                    AudioSource audio =whichModel.GetComponent<AudioSource>();
                    audio.Play();
                    PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 500);
                    PlayerPrefs.SetString(whichModel.GetComponent<SelectModel>().nowModel, "Choose");
                    PlayerPrefs.SetString(PlayerPrefs.GetString("AnimType"), "Open");
                    PlayerPrefs.SetString("AnimType",  whichModel.GetComponent<SelectModel>().nowModel);
                    selectBtn.SetActive(false);
                    chooseBtn.SetActive(true);
                    buyBtn.SetActive(false);
                    Cost.text = "";
                    PlayerPrefs.SetInt(whichModel.GetComponent<SelectModel>().ModelInTrigger.name  + "active",1);


                }
                break;
            case "select":
                PlayerPrefs.SetString(whichModel.GetComponent<SelectModel>().nowModel, "Choose");
                PlayerPrefs.SetString(PlayerPrefs.GetString("AnimType"), "Open");
                PlayerPrefs.SetString("AnimType", whichModel.GetComponent<SelectModel>().nowModel);
                selectBtn.SetActive(false);
                chooseBtn.SetActive(true);
                buyBtn.SetActive(false);
                break;

        }
    }
}
