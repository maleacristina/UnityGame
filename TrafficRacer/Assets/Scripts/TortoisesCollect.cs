using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TortoisesCollect : MonoBehaviour {

	public UIManager2 uiManager ; 

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Tortoises") 
		{
			//uiManager.GameOver ();
			Destroy (gameObject); 
			uiManager.GameOver ();
		}
	}
}
