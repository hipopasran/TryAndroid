using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSpawn : MonoBehaviour {

    public GameObject[] arr;
    public float delay;
    public float timeDelay = 2f;

	void Start () {
        delay = 0;
	}
	
	// Update is called once per frame
	void Update () {
        delay = delay - Time.deltaTime;

        if(delay<=0 && gameObject.activeInHierarchy == true)
        {
            int num = Random.Range(0, 1);
            Transform.Instantiate(arr[num], transform.position, transform.rotation);

            delay = timeDelay;
        }
	}
}
