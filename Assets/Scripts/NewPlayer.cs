using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : MonoBehaviour
{

    Rigidbody2D rd;
    float speed = 7f;

    public bool IsGround;
    Transform grounded;
    public LayerMask layerMask;


    // Use this for initialization
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();

        grounded = GameObject.Find(this.name + "/grounded").transform;
    }

    // Update is called once per frame
    void Update()
    {
        IsGround = Physics2D.Linecast(transform.position, grounded.position, layerMask);
    }
    void OnMouseDown()
    {
        if (IsGround)
        {
            Jump();
        }
      
    }

    public void Jump()
    {
        rd.velocity = speed * Vector2.up;
    }


    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.transform.tag == "enemy")
        {

            Destroy(gameObject);
        }

    }
}