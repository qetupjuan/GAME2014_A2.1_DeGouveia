using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene("GameLevel1");
    }

    public void OnInstructionsPressed()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void OnMenuPressed()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void OnQuitPressed()
    {
        SceneManager.LoadScene("End Screen");
    }

    public void OnActualQuitPressed()
    {
        Application.Quit();
    }
}


