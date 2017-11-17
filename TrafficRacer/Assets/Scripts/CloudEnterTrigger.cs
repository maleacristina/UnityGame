using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudEnterTrigger : MonoBehaviour
{

    public UIManager5 uiManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Cloud")
        {
            uiManager.cloud += 1;
            uiManager.score -= 5;
        }
    }
}
