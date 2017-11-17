using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UIManagerMenu : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
     }



    public void Play()
    {
        Application.LoadLevel("Level1");
    }
    public void About()
    {
        Application.LoadLevel("AboutScene");
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
