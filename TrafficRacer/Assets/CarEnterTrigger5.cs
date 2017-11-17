using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEnterTrigger5 : MonoBehaviour {

    public UIManager5 ui;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy Car")
        {
            ui.health -= 1; 
        }
    }
}
