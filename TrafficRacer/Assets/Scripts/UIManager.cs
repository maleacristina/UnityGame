using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

    public CarController carController; 
    public Button[] buttons;
    public Text scoreText;
    public Text bananasText;
	public Text healthText; 
	public Text coinsText ;  
    bool gameOver;
    public int score;
    public int bananas;
	public int healthNumber; 
	public int healthMaxNumber =5 ; 
	public int coins ; 


    //private Rigidbody2D rb2d;

    // Use this for initialization
    void Start () {
        //rb2d = GetComponent<Rigidbody2D>();
        //carController = GetComponent<CarController>(); 
        gameOver = false;
        score = 0;
        bananas = 0;
		coins = 0; 
		healthNumber = healthMaxNumber; 
       // InvokeRepeating("scoreUpdate", 2.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score;
        bananasText.text = "Bananas: " + bananas;
		healthText.text =" " + healthNumber;
		coinsText.text = " " + coins; 
		UpdateCoins ();
		if (score < 0) 
		{
			score = 0; 

		}

		gameOverActivated (); 
	}
 
    //    public void scoreUpdate()
   // {
      //  if (gameOver==false) {
      //      score += 1;
      //  }
        
   // }

	public void  UpdateCoins()
	{
		if((score+1) % 5 == 0) 
		{
			coins +=1;
		}
	}
    public void gameOverActivated()
    {

		if (healthNumber <= 0) {
			score = 0; 
			healthNumber = 0; 
			gameOver = true;
		
			foreach (Button button in buttons) {
				button.gameObject.SetActive (true);
			}
		}
    }


    public void Play()
    {
        Application.LoadLevel("Level1");
    }
   public void Pause(){
        if (Time.timeScale == 1){
            Time.timeScale = 0;
        }
        else if(Time.timeScale==0)
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
