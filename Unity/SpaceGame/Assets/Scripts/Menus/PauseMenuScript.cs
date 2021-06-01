using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pausemenuUI;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pausemenuUI.SetActive(true);
        gameIsPaused = false;
    }

    void Pause()
    {
        pausemenuUI.SetActive(true);
        gameIsPaused = true;
    }

    public void PauseToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseToQuit()
    {
        Debug.Log("quit from pausescreen");
        Application.Quit();
    }
}
