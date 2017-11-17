using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager5 : MonoBehaviour
{

    public UIManager5 uiManager;



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy Car")
        {
            uiManager.score += 2;
        }
    }
}
