using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkCharacterBarScript : MonoBehaviour
{

    public GameObject talkBarActive;
    public GameObject mainBars;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "charactertext")
        {
            if (talkBarActive)
            {
                PauseForTheText();
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "charactertext")
        {
            if (talkBarActive)
            {
                StopPauseFromText();
            }
        }
    }

    public void PauseForTheText()
    {
        talkBarActive.SetActive(true);
        mainBars.SetActive(false);
        Time.timeScale = 0;
    }
    public void StopPauseFromText()
    {
        talkBarActive.SetActive(false);
        mainBars.SetActive(true);
        Time.timeScale = 1;
    }
}
