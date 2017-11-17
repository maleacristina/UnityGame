using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager4 : MonoBehaviour {

	public UIManager4 manager;



	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Police" || other.tag =="Enemy Car")
		{
			manager.score += 1; 
		}
	}
}
