using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ; 

public class NextLevel2 : MonoBehaviour {


	public UIManager uiManager ; 

	void Update() 
	{
		if (uiManager.score > 60) 
		{
			SceneManager.LoadScene ("Level2"); 
		}
	}

}
