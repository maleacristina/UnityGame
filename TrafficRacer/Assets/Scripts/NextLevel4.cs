using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ; 

public class NextLevel4 : MonoBehaviour {


	public UIManager3 uiManager ; 

	void Update() 
	{
		if (uiManager.score >= 100 ) 
		{
			SceneManager.LoadScene ("Level4"); 
		}
	}
}
