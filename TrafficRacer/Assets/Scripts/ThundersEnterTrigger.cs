using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThundersEnterTrigger : MonoBehaviour
{

    public UIManager4 uiManager;
    public CarController4 car; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Thunder")
        {
            uiManager.thunder += 1;
            car.carSpeed -= 0.01f; 
           
        }
    }
}
