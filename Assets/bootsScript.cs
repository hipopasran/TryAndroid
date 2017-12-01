using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bootsScript : MonoBehaviour {

    public GameObject player;
    public GameObject bootsIcon;
    float time;
    public float TimeAmt = 15;
	    // Use this for initialization
	    void Start () {
        time = TimeAmt;
	    }
	
	    // Update is called once per frame
	    void Update () {
        

        //player.GetComponent<NewPlayer>().BootsLifetime();
        if (time > 0)
        {
            time -= Time.deltaTime;
            
        }
        else
        {
            Start();
            this.gameObject.SetActive(false);
        }
       
        if(!player.activeInHierarchy)
        {
            Start();
            this.gameObject.SetActive(false);
        }


    }

        void OnCollisionEnter2D(Collision2D coll)
        {
            if(coll.transform.tag=="enemy")
            {
                Destroy(coll.gameObject);
            }
            
        }

        //public IEnumerator Alive()
        //{
                    
        //    yield return new WaitForSeconds(15f);
           
        //}
}
