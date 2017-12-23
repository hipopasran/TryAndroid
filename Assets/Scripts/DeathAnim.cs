using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnim : MonoBehaviour {

    public Rigidbody2D rb;
    int x, y;
    
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        //rb.AddForce(GetComponent<Transform>().up*10f, ForceMode2D.Impulse);
        int x = Random.Range(-1, 1);
        int y = Random.Range(-1, 1);
        rb.AddForce(new Vector2(x,y) * 2.5f, ForceMode2D.Impulse);

    }

    void OnCollisionEnter2d(Collider2D other)
    {
        if(other.transform.tag=="enemy")
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	
}
