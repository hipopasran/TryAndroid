using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewPlayer : MonoBehaviour
{

    Rigidbody2D rd;
    float speed = 7f;
    public int coins=0;
    public Text text;

    public bool IsGround;
    Transform grounded;
    public LayerMask layerMask;


    // Use this for initialization
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;

        grounded = GameObject.Find(this.name + "/grounded").transform;
    }

    // Update is called once per frame
    void Update()
    {
        IsGround = Physics2D.Linecast(transform.position, grounded.position, layerMask);
        
    }
    void OnMouseDown()
    {
        if (IsGround && Time.timeScale != 0)
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
            Time.timeScale = 0;
            Destroy(gameObject);
        }
        if(coll.transform.tag == "coins")
        {
            Destroy(coll.gameObject);
            coins = coins + 1;
            text.text = coins.ToString();
        }

    }
}