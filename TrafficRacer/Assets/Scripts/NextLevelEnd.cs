using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelEnd : MonoBehaviour
{


    public UIManager5 uiManager;

    void Update()
    {
        if (uiManager.score > 70)
        {
            SceneManager.LoadScene("EndGame");
        }
    }

}
