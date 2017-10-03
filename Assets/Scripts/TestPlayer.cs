using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour {

    Rigidbody2D rd;
    public float speed = 7f;
    public int coins;
    Transform tr;

    public float gravity = -9.8f;

    public Transform telo;


    public bool IsGround;
    Transform grounded;
    public LayerMask layerMask;

    public int points = 0;
   

    


    // Use this for initialization
    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");
        rd = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
        tr = GetComponent<Transform>();

        tr.Rotate( Vector3.zero);

        grounded = GameObject.Find(this.name + "/grounded").transform;
    }

    // Update is called once per frame
    void Update()
    {
        IsGround = Physics2D.Linecast(transform.position, grounded.position, layerMask);

       


        //if (rd.velocity == 0 * Vector2.up && IsGround == false)
        //{
        //    rd.velocity = 2 * gravity * Vector2.up;
        //    rd.gravityScale = 5;
        //}


    }
   
    public void Rotation()
    {
       
        
            StartCoroutine(Rot());
        
    }

    ////void OnMouseDown()
    ////{
    ////    StartCoroutine(Rot());
    ////    Jump();
    ////}

    public void Jump()
    {
        //AudioSource audio = GetComponent<AudioSource>();
        //audio.Play();

        rd.velocity = speed * Vector2.up;
    }

    //void Rot()
    //{
    //    if (tr.rotation.z == 0)
    //    {
    //      tr.Rotate(Vector3.forward * -90);
    //    }
    //    Delay();
    //    //else if (tr.rotation.z < 0)
    //    //{ 
    //        tr.Rotate(Vector3.forward * 90);
    //    //}
    //}

    public IEnumerator Rot()
    {
        Debug.Log(Time.time);
        if(telo.transform.localRotation.z==0)
        {
            telo.Rotate(Vector3.forward * -90);
        }
        yield return new WaitForSeconds(1f);
        //else if (tr.rotation.z < 0)
        if(telo.transform.rotation.z < 0)
        {
            telo.Rotate(Vector3.forward * 90);
        }
        
        
        Debug.Log(Time.time);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.transform.tag == "enemy")
        {

            
           
            Destroy(gameObject);

        }
    }

    }
