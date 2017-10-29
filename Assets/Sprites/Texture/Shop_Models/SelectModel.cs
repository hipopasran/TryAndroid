using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectModel : MonoBehaviour {

    public string nowModel;

    public GameObject selectModel, buyModel, chooseModel;
    

    void Awake()
    {
       


            if (PlayerPrefs.GetString("рыцарь2") != "Choose" || PlayerPrefs.GetString("рыцарь2") == "")
            {
                PlayerPrefs.SetString("рыцарь2", "Choose");
            }
       
        if (PlayerPrefs.GetString("рыцарь2") == "Open")
        {
            chooseModel.SetActive(false);
            selectModel.SetActive(true);
            buyModel.SetActive(false);
        }
        else if (PlayerPrefs.GetString("рыцарь2") == "Choose")
        {
            selectModel.SetActive(false);
            buyModel.SetActive(false);
            chooseModel.SetActive(true);

        }

    }

	void OnTriggerEnter2D(Collider2D other)
    {

        nowModel = other.gameObject.name;

        other.transform.localScale += new Vector3(0.5f, 0.5f);
        if(PlayerPrefs.GetString(other.gameObject.name)=="Open")
        {
            chooseModel.SetActive(false);
            selectModel.SetActive(true);
            buyModel.SetActive(false);
        }
        else if(PlayerPrefs.GetString(other.gameObject.name)=="Choose")
        {
            selectModel.SetActive(false);
            buyModel.SetActive(false);
            chooseModel.SetActive(true);

        }
        else if((PlayerPrefs.GetString(other.gameObject.name) != "Choose")&&(PlayerPrefs.GetString(other.gameObject.name)!="Open") && (other.gameObject.name !="Scroll Objects"))
        {
            selectModel.SetActive(false);
            buyModel.SetActive(true);
            chooseModel.SetActive(false);

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
