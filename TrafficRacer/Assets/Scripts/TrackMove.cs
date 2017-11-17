using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class TrackMove : MonoBehaviour {
    public float speed;
    Vector2 offset;

	public UIManager3 ui ; 

	//public UIManager uiManager; 
	 
	
	// Update is called once per frame
	void Update () 
	{
		//if (uiManager.score % 10 == 0)
		//{
		//	speed += 0.001f; 
		//}
		if ((ui.jalon + 1) % 7 == 0) {
			speed += 0.01f; 
		} 
		else 
		{
			speed = speed;
		}
        offset = new Vector2(0, Time.time * speed);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
