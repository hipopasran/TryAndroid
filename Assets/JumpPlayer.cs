using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer : MonoBehaviour {


    public bool IsGround;
    Transform grounded;
    public float speed = 7f;
    public LayerMask layerMask;


    public Transform telo;


    Rigidbody2D rd;
    //// Use this for initialization
    void Start()
    {
        grounded = GameObject.Find(this.name + "/grounded").transform;
        rd = GetComponent<Rigidbody2D>();
    }

    //// Update is called once per frame
    void Update()
    {
        IsGround = Physics2D.Linecast(transform.position, grounded.position, layerMask);
    }



    public void Jump()
    {
        if (IsGround && Time.timeScale != 0)
        {
            //AudioSource audio = GetComponent<AudioSource>();
            //audio.Play();

            rd.velocity = speed * Vector2.up;
        }
    }

    public void Rotation()
    {


        StartCoroutine(Rot());

    }

    public IEnumerator Rot()
    {
        //Debug.Log(Time.time);
        if (telo.transform.localRotation.z == 0)
        {
            telo.Rotate(Vector3.forward * -90);
        }
        yield return new WaitForSeconds(1f);
        //else if (tr.rotation.z < 0)
        if (telo.transform.localRotation.z < 0)
        {
            telo.Rotate(Vector3.forward * 90);
        }


        //Debug.Log(Time.time);
    }
}
