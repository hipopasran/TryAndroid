﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bootsScript : MonoBehaviour {

    public GameObject player;
    public GameObject bootsIcon;
    public GameObject AfterJump;
    public GameObject AfJumpPos;

    public GameObject activeBoots;
    float time;
    public float TimeAmt = 15;
	    // Use this for initialization
	    void Start () {
        time = TimeAmt;
	    }
	
	    // Update is called once per frame
	    void Update () {
        

        //player.GetComponent<NewPlayer>().BootsLifetime();
        if (time > 0)
        {
            time -= Time.deltaTime;
            
        }
        else
        {
            Start();
            activeBoots.transform.localPosition = new Vector3(0, 0, -10);
            this.gameObject.SetActive(false);
        }
       
        if(!player.activeInHierarchy)
        {
            Start();
            activeBoots.transform.localPosition = new Vector3(0, 0, -10);
            this.gameObject.SetActive(false);
        }


    }

        void OnCollisionEnter2D(Collision2D coll)
        {
            if(coll.transform.tag=="enemy")
            {
                Destroy(coll.gameObject);
            }
            if (coll.transform.tag=="ground" && time<14)
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();
                Transform.Instantiate(AfterJump, AfJumpPos.transform.position, AfterJump.transform.rotation);
            }
    }
            
        //public IEnumerator Alive()
        //{
                    
        //    yield return new WaitForSeconds(15f);
           
        //}
}
