using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCloud : MonoBehaviour {


    public UIManager5 uiManager;


    // Update is called once per frame
    void Update()
    {

        if ((uiManager.cloud + 1) % 3 == 0)
            {
            uiManager.health = uiManager.nr_vieti_ramase;  
        }
	}
}
