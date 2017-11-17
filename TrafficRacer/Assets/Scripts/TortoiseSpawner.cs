using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Random;

public class TortoiseSpawner : MonoBehaviour
{

    public GameObject[] cars;
    int carNo;
    public float maxPos = 2.2f;
    public float delayTimer = 1f;
    float timer;
  
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
           
            Vector3 carPos = new Vector3(Random.Range(-1.95f, 1.50f), transform.position.y, transform.position.z);
           
   
            carNo = Random.Range(0, 3);
            Instantiate(cars[carNo], carPos, transform.rotation);
            //Instantiate(cars[carNo], carPos2, transform.rotation);
            timer = delayTimer;
        }
    }
}
