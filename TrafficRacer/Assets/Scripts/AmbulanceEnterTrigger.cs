using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbulanceEnterTrigger : MonoBehaviour {

	public UIManager3 uiManager; 

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Ambulance")
		{

			//uiManager.score -= 3; 
			uiManager.health-= 2; 

		}
	}
}
