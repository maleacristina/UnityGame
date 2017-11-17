using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JalonEnterTrigger : MonoBehaviour {

	public UIManager3 uiManager ; 

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Jalon") 
		{
			uiManager.jalon += 1;
            uiManager.score -= 5;
        }
	}
}
