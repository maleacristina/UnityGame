using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Random;

public class CarSpawnPos1 : MonoBehaviour
{

    public GameObject[] cars;
    int carNo;
    //public float maxPos1 = 0.69f;
    public float maxPos2 = 0.69f;
    public float delayTimer = 1f;
    float timer;



    int k;

    // Use this for initialization
    void Start()
    {
        timer = delayTimer;

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)

        {

            k = Random.Range(0, 3);
            /*if (k == 1)
            {
                Vector3 carPos1 = new Vector3(Random.Range(-1.58f, -1.58f), transform.position.y, transform.position.z);
                Instantiate(cars[carNo], carPos1, transform.rotation);

            }
            if (k == 2)
            {
                Vector3 carPos2 = new Vector3(Random.Range(-0.49f, -0.49f), transform.position.y, transform.position.z);
                Instantiate(cars[carNo], carPos2, transform.rotation);

            }*/
            if (k == 1)
            {
                Vector3 carPos3 = new Vector3(Random.Range(0.58f, 0.58f), transform.position.y, transform.position.z);
                Instantiate(cars[carNo], carPos3, transform.rotation);

            }
            if (k == 2)
            {
                Vector3 carPos4 = new Vector3(Random.Range(1.69f, 1.69f), transform.position.y, transform.position.z);
                Instantiate(cars[carNo], carPos4, transform.rotation);

            }
            carNo = Random.Range(0, 3);
            timer = delayTimer;
        }
    }
}
