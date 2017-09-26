using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public GameObject groundEnemy;
    public GameObject flyEnemy;
    public GameObject StartCoin;
    public GameObject coins;
    public int enemyType;
    public float delay;
    public float timeDelay;

    public GameObject[] arr;

    public int NumberOfEnemy=0;

    // Use this for initialization
    void Start () {
        delay = 0;
        groundEnemy.SetActive(false);
        flyEnemy.SetActive(false);



    }

    // Update is called once per frame
    void Update () {

        
        
        delay = delay - Time.deltaTime;
        if (delay <= 0)
        {
            enemyType = Random.Range(1, 10);
            if (enemyType < 3)
            {
                groundEnemy.SetActive(false);
                
                
                int num = Random.Range(0, 1);

                
                Transform.Instantiate(arr[num], flyEnemy.transform.position, transform.rotation);
                NumberOfEnemy = NumberOfEnemy + 1;
            }
            if (enemyType >= 3)
            {
                groundEnemy.SetActive(true);
                
                int num = Random.Range(0, 1);
                int prep = Random.Range(1, 4);
                for (int t = 0; t < prep; t++)
                {
                    Transform.Instantiate(arr[num], groundEnemy.transform.position, transform.rotation);
                }
                NumberOfEnemy = NumberOfEnemy + 1;
            }
            
            timeDelay = Random.Range(2, 3);

            delay = timeDelay;
           
        }

        if(NumberOfEnemy >=4 && groundEnemy.active)
        {
            Transform.Instantiate(coins, StartCoin.transform.position, transform.rotation);
            groundEnemy.SetActive(false);
            //StartCoin.SetActive(true);
            NumberOfEnemy = 0;
        }
        else if(NumberOfEnemy < 4)
        {
            StartCoin.SetActive(false);
        }
        if (gameObject.activeInHierarchy == false)
        {
            delay = 0;
        }

    }
}
