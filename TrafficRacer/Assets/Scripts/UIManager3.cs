using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager3 : MonoBehaviour
{

    public Button[] buttons;
    public Text scoreText;
    bool gameOver;
	public int score;
	public int maxHealth = 8; 
	public int health  ; 
	public Text healtText;  
	public Text oilText;  
	public int oil ; 
	public int jalon ; 
	public Text jalonText; 

    // Use this for initialization
    void Start()
    {
        gameOver = false;
        score = 0;
		oil = 0; 
		jalon = 0; 
		health = maxHealth; 
      //  InvokeRepeating("scoreUpdate", 1.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
		healtText.text = "" + health; 
		oilText.text = "" + oil; 
		jalonText.text = "" + jalon; 

		if (score < 0) 
		{
			score = 0; 
		}

		gameOverActivated (); 
    }
  //  public void scoreUpdate()
  // {
     ///   if (gameOver == false)
      //  {
      //      score += 5;
      //  }

  //  }
    public void gameOverActivated()
	{
		if (health <= 0) {
			score = 0; 
			health = 0;
			gameOver = true;
			foreach (Button button in buttons) {
				button.gameObject.SetActive (true);
			}
		}
	}
    public void Play()
    {
        Application.LoadLevel("Level3");
    }
    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;

        }

    }
    //public void Replay()
    //{
    // Application.LoadLevel(Application.loadedLevel);
    //}
    public void Menu()
    {
        Application.LoadLevel("MenuScene");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
