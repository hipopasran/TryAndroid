using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectModel : MonoBehaviour {

    public string nowModel;
    public GameObject ModelInTrigger;

    public GameObject selectModel, buyModel, chooseModel;
    public Text NameOfModel;
    public Text Cost;
   


    void Awake()
    {
        //PlayerPrefs.SetInt("Coins", 1000);
        //PlayerPrefs.SetString("рыцарь2", "");
        //PlayerPrefs.SetString("run", "");
        //PlayerPrefs.SetString("Doctor", "");
        //PlayerPrefs.SetString("Sherif", "");
        //PlayerPrefs.SetString("AnimType", "Knight");
        //PlayerPrefs.SetString("Redskin", "");
        //PlayerPrefs.SetString("Security guard", "");
        //PlayerPrefs.SetString("Pirate", "");
        //PlayerPrefs.SetString("Ninja", "");
        //PlayerPrefs.SetString("Fashionable guy", "");
        //PlayerPrefs.SetString("Knight", "");
        //PlayerPrefs.SetString("Santa Claus", "");

        PlayerPrefs.SetString("Scroll Objects", "");

        if (PlayerPrefs.GetString("AnimType") != "Knight")
        {
            PlayerPrefs.SetString("Knight", "Open");
        }

        if (PlayerPrefs.GetString("Santa Claus") == "")
        {
            PlayerPrefs.SetString("Santa Claus", "Open");
        }
            // if ((PlayerPrefs.GetString("Knight") != "Choose" && PlayerPrefs.GetString("Knight") != "Open") || PlayerPrefs.GetString("Knight") == "")
            if ( PlayerPrefs.GetString("Knight") == "")
            {
                PlayerPrefs.SetString("Knight", "Choose");
            }
       
        if (PlayerPrefs.GetString("Knight") == "Open")
        {
            chooseModel.SetActive(false);
            selectModel.SetActive(true);
            buyModel.SetActive(false);
            
        }
        else if (PlayerPrefs.GetString("Knight") == "Choose")
        {
            selectModel.SetActive(false);
            buyModel.SetActive(false);
            chooseModel.SetActive(true);

        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        nowModel = other.gameObject.name;
        if (other.gameObject.name != "Scroll Objects" && other.gameObject.name!="ImageSnow")
        {
            ModelInTrigger = other.gameObject;
            NameOfModel.text = other.gameObject.name;

            if (PlayerPrefs.GetString(other.gameObject.name) != "")
            {
                Cost.text = "";
            }
            else
            {
                Cost.text = "350";
            }
            other.transform.localScale += new Vector3(0.5f, 0.5f);




            //other.transform.localScale += new Vector3(0.5f, 0.5f);
            if (PlayerPrefs.GetString(other.gameObject.name) == "Open")
            {
                chooseModel.SetActive(false);
                selectModel.SetActive(true);
                buyModel.SetActive(false);
            }
            else if (PlayerPrefs.GetString(other.gameObject.name) == "Choose")
            {
                selectModel.SetActive(false);
                buyModel.SetActive(false);
                chooseModel.SetActive(true);

            }
            else if ((PlayerPrefs.GetString(other.gameObject.name) != "Choose") && (PlayerPrefs.GetString(other.gameObject.name) != "Open") && (other.gameObject.name != "Scroll Objects") && (other.gameObject.name != "ImageSnow"))
            {
                selectModel.SetActive(false);
                buyModel.SetActive(true);
                chooseModel.SetActive(false);

            }
        }
    }
    //void OnTriggerStay(Collider2D other)
    //{
        
    //    if (PlayerPrefs.GetString(other.gameObject.name) == "Open")
    //    {
    //        chooseModel.SetActive(false);
    //        selectModel.SetActive(true);
    //        buyModel.SetActive(false);
    //    }
    //    else if (PlayerPrefs.GetString(other.gameObject.name) == "Choose")
    //    {
    //        selectModel.SetActive(false);
    //        buyModel.SetActive(false);
    //        chooseModel.SetActive(true);

    //    }
    //    else
    //    {
    //        selectModel.SetActive(false);
    //        buyModel.SetActive(true);
    //        chooseModel.SetActive(false);

    //    }
    //}

    void OnTriggerExit2D(Collider2D other)
    {

        other.transform.localScale -= new Vector3(0.5f, 0.5f);
    }
}
