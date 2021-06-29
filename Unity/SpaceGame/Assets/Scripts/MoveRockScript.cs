using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRockScript : MonoBehaviour
{

    public PauseMenuScript pauseGame;


    void Update()
    {
        if(pauseGame.gameIsPaused == false)
        {
            transform.position += Vector3.up * Mathf.Sin(Time.time) * 0.005f;
        }
    }
}
