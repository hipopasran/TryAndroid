using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewPlayer : MonoBehaviour
{

    Rigidbody2D rd;
    public float speed = 7f;
    public int coins;
    public Text text;

    public float gravity = -9.8f;

    public Text score_death;
    

    public bool IsGround;
    Transform grounded;
    public LayerMask layerMask;

    public int points = 0;
    public Text pointText;

    public GameObject restart, home, ratimg, share,pause;


    // Use this for initialization
    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");
        rd = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;

        grounded = GameObject.Find(this.name + "/grounded").transform;
    }

    // Update is called once per frame
    void Update()
    {
        IsGround = Physics2D.Linecast(transform.position, grounded.position, layerMask);

        pointText.text = " " + points;
        text.text =" "+ coins.ToString();


        if (rd.velocity == 0 * Vector2.up && IsGround == false)
        {
            rd.velocity = 2 * gravity * Vector2.up;
            rd.gravityScale = 5;
        }


    }
    void FixedUpdate()
    {
        if (Time.timeScale > 0)
        {
            points = points + 1;
        }
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
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        
        rd.velocity = speed * Vector2.up;
    }


    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.transform.tag == "enemy")
        {
            
            PlayerLose();
            score_death.text = "YOURE SCORE: " + (points-1).ToString();
            score_death.gameObject.SetActive(true);
            Time.timeScale = 0;
            ratimg.SetActive(true);
            share.SetActive(true);
            restart.SetActive(true);
            home.SetActive(true);
            pause.SetActive(false);
            Destroy(gameObject);

        }
        if(coll.transform.tag == "coins")
        {
            
            Destroy(coll.gameObject);
            coins = coins + 1;
            text.text = coins.ToString();
        }

    }

    void PlayerLose()
    {
        if(PlayerPrefs.GetInt("Points") < points)
        {
            PlayerPrefs.SetInt("Points", points);
        }
        
        PlayerPrefs.SetInt("Coins", coins);
        
    }
}