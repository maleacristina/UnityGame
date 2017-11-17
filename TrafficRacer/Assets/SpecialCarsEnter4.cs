using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCarsEnter4 : MonoBehaviour {

    public UIManager4 ui; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            ui.score -= 5; 
        }
    }
}
