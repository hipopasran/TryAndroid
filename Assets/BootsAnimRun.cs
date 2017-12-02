using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootsAnimRun : MonoBehaviour {

    public Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (gameObject.activeInHierarchy)
        {
            anim.Play("New Animation");
        }
    }
}
