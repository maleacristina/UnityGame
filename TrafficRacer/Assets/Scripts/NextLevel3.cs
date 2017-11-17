using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ; 

public class NextLevel3 : MonoBehaviour {

	public UIManager2 uiManager ; 

	void Update() 
	{
		if (uiManager.score > 30) 
		{
			SceneManager.LoadScene ("Level3"); 
		}
	}
}
