using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsEnterTrigger2 : MonoBehaviour {

	public UIManager2 uiManager; 

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Enemy Car")
		{

			//uiManager.score -= 3; 
			uiManager.health -= 1; 

		}
	}
}
