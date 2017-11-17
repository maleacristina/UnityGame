using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilEnterTrigger : MonoBehaviour {

	public UIManager3 uiManager ; 

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Oil")
		{
			uiManager.oil += 1;
            uiManager.score -= 10;
		}
	}
}
