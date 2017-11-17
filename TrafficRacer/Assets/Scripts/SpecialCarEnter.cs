using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCarEnter : MonoBehaviour {

	public UIManager uiManager; 

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Enemy")
		{

            uiManager.score -= 3;
            //uiManager.healthNumber -= 1;


        }
	}
}
