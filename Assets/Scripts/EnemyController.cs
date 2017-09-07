using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public GameObject groundEnemy;
    public GameObject flyEnemy;
    public int enemyType;
    public float delay;
    public float timeDelay = 3f;

    // Use this for initialization
    void Start () {
        delay = 0;



    }

    // Update is called once per frame
    void Update () {
        delay = delay - Time.deltaTime;
        if (delay <= 0)
        {
            enemyType = Random.Range(1, 3);
            if (enemyType == 1)
            {
                groundEnemy.SetActive(true);
                flyEnemy.SetActive(false);
            }
            if (enemyType > 1)
            {
                groundEnemy.SetActive(false);
                flyEnemy.SetActive(true);
            }
            delay = timeDelay;
        }
        
    }
}
