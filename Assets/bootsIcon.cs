using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bootsIcon : MonoBehaviour {

    public GameObject boots;
    float time;
    public float timeAmt = 16;
    Image TimeBar;

    Image thisImage;
    public Sprite layer_up, layer_down;

   

    // Use this for initialization
    void Start () {
        thisImage = GetComponent<Image>();
        TimeBar = this.GetComponent<Image>();
        time = timeAmt;
	}
	
	// Update is called once per frame
	void Update () {
        if (boots.activeInHierarchy)
        {
            if (time > 1)
            {
                if (time > timeAmt - 11)
                {
                    thisImage.sprite = layer_down;
                }

                if (time <= timeAmt - 11)
                {
                    thisImage.sprite = layer_up;
                }
                time -= Time.deltaTime;
                TimeBar.fillAmount = time / timeAmt;
            }

            //else if(!boots.activeInHierarchy)
            else
            {
                Start();
                this.gameObject.SetActive(false);
            }
        }
        else
        {
            Start();
            this.gameObject.SetActive(false);
        }
	}
}
