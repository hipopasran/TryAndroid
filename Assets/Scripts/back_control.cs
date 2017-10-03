using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back_control : MonoBehaviour {


    public GameObject background;
    public Transform start;
    public Transform rip;
    Transform tr;
    Rigidbody2D back;
    public float speed;

	// Use this for initialization
	void Start () {
        tr = GetComponent<Transform>();
        back = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        Vector2 vel = back.velocity;
        vel.x = -1 * speed;
        back.velocity = vel;

        if (tr.position.x<=rip.position.x)
        {
            Transform.Instantiate(background, start.transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
