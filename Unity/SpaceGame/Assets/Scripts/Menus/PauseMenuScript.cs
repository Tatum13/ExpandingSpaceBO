using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public bool gameIsPaused = false;

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

       // if (Input.GetKeyDown(KeyCode.Escape))
       // {
       //     if()
       // }
    }

    public void Resume()
    {
        pausemenuUI.SetActive(false);
        gameIsPaused = false;
        Time.timeScale = 1;
    }

    public void Pause()
    {
        pausemenuUI.SetActive(true);
        gameIsPaused = true;
        Time.timeScale = 0;
    }

    public void PauseToMainMenu()
    {
        Resume();
        SceneManager.LoadScene(0);
    }

    public void PauseToQuit()
    {
        Application.Quit(); //WERKT!!
    }
}
