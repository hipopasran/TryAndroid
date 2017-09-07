using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    //public GameObject enemy;
    //public Transform StartPosition;
    public bool alife;
    

	// Use this for initialization
    void Awaik()
    {
        alife = true;
    }
	void Start () {
       
	}
	void Update()
    {
       
    }
	

    void OnCollisionEnter2D(Collision2D coll)
    {
        transform.parent = coll.transform.parent;

        if(coll.transform.tag=="endplat")
        {
            alife = false;
            Destroy(gameObject);
        }
        
    }
   
}
