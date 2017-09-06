using UnityEngine;
using System.Collections;

public class characterController : MonoBehaviour {
	public float Speed;
	public float jumpForce=300f;
	bool facingRight = true;
	bool grounded = false;
	public Transform groundCheck;
	public float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float score;
	public float move;
    public float SpawnX, SpawnY;

    
    

   

    
   

   

    

    // Use this for initialization
    void Start () {
        SpawnX = transform.position.x;
        SpawnY = transform.position.y;
        
	}


    void OnMouseDown()
    {
        //grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        //if (grounded)
        //{
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
        //}
    }

    //   // Update is called once per frame
    void FixedUpdate () {


     grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

	


       
	}

	void Update(){

        


    }

    

   

 //   void OnGUI()
 //   {
 //       //GUI.Box(new Rect(0, 0, 60, 50), "Stars: " + score);
       

 //       //if(GUI.Button(new Rect(Screen.width - 100, 0, 100, 50), "Выход"))
 //       //{
 //       //    Application.LoadLevel("Menu");
 //       //}
 //   }

}
