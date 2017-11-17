using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager5 : MonoBehaviour
{

    public Button[] buttons;
    public Text scoreText;
    public Text healthText;
    bool gameOver;
    public int score;
    int maxHealth = 10;
    public int health;
    public Text cloudText;
    public int cloud;
    public int nr_vieti_ramase; 

    // Use this for initialization
    void Start()
    {
        gameOver = false;
        score = 0;
        cloud = 0;
        health = maxHealth;
        InvokeRepeating("scoreUpdate", 1.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        cloudText.text = "" + cloud;
        healthText.text = " " + health;
      nr_vieti_ramase = health; 
        if (score < 0)
        {
            score = 0;

        }
        gameOverActivated();
    }
    public void scoreUpdate()
    {
        // if (gameOver == false)
        // {
        //     score += 3;
        //  }

    }
    public void gameOverActivated()
    {
        if (health <= 0)
        {
            gameOver = true;
            score = 0;
            health = 0;
            foreach (Button button in buttons)
            {
                button.gameObject.SetActive(true);
            }
        }
    }
    public void GameOver()
    {

        gameOver = true;
        score = 0;
        health = 0;
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }

    }
    public void Play()
    {
        Application.LoadLevel("Level5");
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
