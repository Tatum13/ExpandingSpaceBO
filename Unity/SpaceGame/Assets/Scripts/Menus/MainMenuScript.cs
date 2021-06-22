using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToCredits()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToComic()
    {
        SceneManager.LoadScene(6);
    }

    public void Quitgame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
