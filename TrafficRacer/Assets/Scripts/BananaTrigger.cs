using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaTrigger : MonoBehaviour {

    public UIManager uiManager; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Banana")
        {
            uiManager.bananas += 1;
            Destroy(other.gameObject);
        }
    }
}
