using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager2 : MonoBehaviour {

	public UIManager2 uiManager ;



	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Enemy Car")
		{
			uiManager.score += 2; 
		}
	}
}
