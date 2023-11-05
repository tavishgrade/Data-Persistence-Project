using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainScene : MonoBehaviour
{

    private void OnDestroy()
    {

    }

    private void Update()
    {
       
    }

    public void ExitToMainMenu()
    {
        MainMenuManager.Instance.SaveHighScore();

        SceneManager.LoadScene(0);
    }
}
