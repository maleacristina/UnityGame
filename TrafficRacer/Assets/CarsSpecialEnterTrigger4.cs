using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsSpecialEnterTrigger4 : MonoBehaviour
{


    public UIManager4 uiManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy" || other.tag=="Police")
        {
            uiManager.score -= 5;
        }
    }



}
