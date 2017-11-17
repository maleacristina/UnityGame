using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEnterTrigger4 : MonoBehaviour
{

    public UIManager4 uiManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Police" || other.tag == "Enemy Car")
        {

            //uiManager.score -= 3; 
            uiManager.health -= 1;

        }
    }
}
