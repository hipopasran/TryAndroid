using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour {
    public Transform startFly;
    public Transform startGround;
    //public GameObject enemy;
    public bool alife;
    public Enemy enemy;
	// Use this for initialization
	void Start () {
        GameObject createEnemy = Instantiate(enemy.gameObject, startGround.position, transform.rotation);

    }
	
	// Update is called once per frame
	void Update ()
    {
        Alife(enemy.alife);
        if (alife==false)
        {
            GameObject createEnemy = Instantiate(enemy.gameObject, startGround.position, transform.rotation);
            alife = enemy.alife;
        }    
       
        
        
    }
    void Alife(bool alife)
    {
        
    }
}
