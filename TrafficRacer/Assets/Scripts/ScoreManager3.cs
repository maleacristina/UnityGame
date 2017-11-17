using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager3 : MonoBehaviour {

	public UIManager3 uiManager ;



	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Enemy Car" || other.tag == "Ambulance")
		{
			uiManager.score+= 1; 
		}
	}
}
