using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButton : MonoBehaviour {

    public GameObject whichModel;
    public GameObject selectBtn;
    public GameObject chooseBtn;
    public GameObject buyBtn;


	void OnMouseUpAsButton()
    {
        switch(gameObject.name)
        {
            case "buy":
                if(PlayerPrefs.GetInt("Coins")>=200)
                {
                    PlayerPrefs.SetString(whichModel.GetComponent<SelectModel>().nowModel, "Open");
                    selectBtn.SetActive(false);
                    chooseBtn.SetActive(true);
                    gameObject.SetActive(false);
                }
                break;
            case "select":

                break;

        }
    }
}
