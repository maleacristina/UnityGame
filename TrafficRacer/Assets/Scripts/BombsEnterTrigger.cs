using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombsEnterTrigger : MonoBehaviour
{

    public UIManager4 uiManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bomb")
        {
            uiManager.bomb += 1;
            uiManager.score -= 5;
        }
    }
}
