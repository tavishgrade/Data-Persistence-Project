using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


#if UNITY_EDITOR
using UnityEditor;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public Text BestScoreText;

    public void NewNameInputed(string playerName)
    {
        // add code here to handle when a name is inputed
        MainMenuManager.Instance.PlayerName = playerName;
    }

    private void Start()
    {
        DisplayHighScore();
    }

    private void DisplayHighScore()
    {
        if (!string.IsNullOrEmpty(MainMenuManager.Instance.BestPlayer))
        {
            BestScoreText.text = "Best Score: " + MainMenuManager.Instance.BestPlayer
                + ": " + MainMenuManager.Instance.HighScore;
        }
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        MainMenuManager.Instance.SaveHighScore();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}

