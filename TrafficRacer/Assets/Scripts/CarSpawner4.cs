using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Random;

public class CarSpawner4 : MonoBehaviour
{

    public GameObject[] cars;
    int carNo;
    public float maxPos = 2.2f;
    public float delayTimer = 1f;
    float timer;
    //int timp;


    int k;

    // Use this for initialization
    void Start()
    {
        timer = delayTimer;
        //timp = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //timp++;
        timer -= Time.deltaTime;
        if (timer <= 0)

        {

            k = Random.Range(0, 5);
            /*if (timp == 1)
            {
                //Vector3 carPos = new Vector3(Random.Range(-1.95f, 1.50f), transform.position.y, transform.position.z);
                Vector3 carPos1 = new Vector3(Random.Range(-1.61f, -1.61f), transform.position.y, transform.position.z);
                Instantiate(cars[carNo], carPos1, transform.rotation);
                Vector3 carPos2 = new Vector3(Random.Range(-0.53f, -0.53f), transform.position.y, transform.position.z);
                Instantiate(cars[carNo], carPos2, transform.rotation);
            }*/

            if (k == 1)
            {
                Vector3 carPos1 = new Vector3(Random.Range(-1.62f, -1.62f), transform.position.y, transform.position.z);
                Instantiate(cars[carNo], carPos1, transform.rotation);

            }
            if (k == 2)
            {
                Vector3 carPos2 = new Vector3(Random.Range(-0.51f, -0.51f), transform.position.y, transform.position.z);
                Instantiate(cars[carNo], carPos2, transform.rotation);

            }
            if (k == 3)
            {
                Vector3 carPos3 = new Vector3(Random.Range(0.57f, 0.57f), transform.position.y, transform.position.z);
                Instantiate(cars[carNo], carPos3, transform.rotation);

            }
            if (k == 4)
            {
                Vector3 carPos4 = new Vector3(Random.Range(1.65f, 1.65f), transform.position.y, transform.position.z);
                Instantiate(cars[carNo], carPos4, transform.rotation);

            }
            carNo = Random.Range(0, 2);
            //Instantiate(cars[carNo], carPos, transform.rotation);
            //Instantiate(cars[carNo], carPos2, transform.rotation);
            timer = delayTimer;
        }
    }
}
