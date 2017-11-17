using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEnterTrigger3 : MonoBehaviour {

	public UIManager3 uiManager; 

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Enemy Car")
		{

			//uiManager.score -= 3; 
			uiManager.health-= 1; 

		}
	}
}
