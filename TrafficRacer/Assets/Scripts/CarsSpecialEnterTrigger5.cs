using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsSpecialEnterTrigger5 : MonoBehaviour
{


    public UIManager5 uiManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            uiManager.score -= 5;
        }
    }



}
