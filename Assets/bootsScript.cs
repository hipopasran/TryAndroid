﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bootsScript : MonoBehaviour {

    public GameObject player;
	    // Use this for initialization
	    void Start () {
		
	    }
	
	    // Update is called once per frame
	    void Update () {
        

        player.GetComponent<NewPlayer>().BootsLifetime();

        

    }

        void OnCollisionEnter2D(Collision2D coll)
        {
            if(coll.transform.tag=="enemy")
            {
                Destroy(coll.gameObject);
            }
            
        }

        //public IEnumerator Alive()
        //{
                    
        //    yield return new WaitForSeconds(15f);
           
        //}
}
