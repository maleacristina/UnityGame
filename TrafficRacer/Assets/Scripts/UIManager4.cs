using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager4 : MonoBehaviour
{

    public Button[] buttons;
    public Text scoreText;
	public Text healhText; 
	public int maxHealth = 10; 
	public int health ; 
    bool gameOver;
	public int score;
    public Text bombText;
    public int bomb;
    public Text thunderText;
    public int thunder;

    // Use this for initialization
    void Start()
    {
        gameOver = false;
        score = 0;
        bomb = 0;
        thunder = 0;
        health = maxHealth; 
     //   InvokeRepeating("scoreUpdate", 1.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
		healhText.text = "" + health;
        thunderText.text = "" + thunder;
        bombText.text = "" + bomb;
        if (score < 0)
        {
            score = 0; 
        }
        gameOverActivated ();
    }
 //   public void scoreUpdate()
   /// {
      //  if (gameOver == false)
      //  {
      //      score += 5;
      //  }

//   }
    public void gameOverActivated ()
	{
		if (health <= 0) {

			health = 0; 
			score = 0; 
			gameOver = true;
			foreach (Button button in buttons) {
				button.gameObject.SetActive (true);
			}
		}
	}

    public void Play()
    {
        Application.LoadLevel("Level4");
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
