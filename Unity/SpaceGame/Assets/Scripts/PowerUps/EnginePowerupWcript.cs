using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnginePowerupWcript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        PlayerEngineScript playerenginescript = GetComponent<PlayerEngineScript>();

        if (col.gameObject.tag == "Engine")
        {
            Destroy(col.gameObject);
            playerenginescript.currentHeat = 99f;
        }
    }

}
