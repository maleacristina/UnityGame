using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel5 : MonoBehaviour
{


    public UIManager4 uiManager;

    void Update()
    {
        if (uiManager.score >= 100)
        {
            SceneManager.LoadScene("Level5");
        }
    }
}
