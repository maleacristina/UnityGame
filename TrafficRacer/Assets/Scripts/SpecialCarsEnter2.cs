using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCarsEnter2 : MonoBehaviour {


	public UIManager2 uiManager; 

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Enemy")
		{

			uiManager.score -= 3; 
			 

		}
	}
}
