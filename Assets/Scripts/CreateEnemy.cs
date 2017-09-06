using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour {
    public Transform startFly;
    public Transform startGround;
    public GameObject enemy;
	// Use this for initialization
	void Start () {
        GameObject createEnemy = Instantiate(enemy, startGround.position, transform.rotation) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
