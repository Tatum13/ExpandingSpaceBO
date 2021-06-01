using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEngineScript : MonoBehaviour
{
    public float maxHeat = 50f;
    public float currentHeat;

    public EngineBarScript engineBar;

    void Start()
    {
        currentHeat = 0;
        engineBar.SetMaxHeat(maxHeat);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            HighHeat(20);
        }
    }

    void HighHeat(float heatDamage)
    {
        currentHeat += heatDamage;

        engineBar.SetHeat(currentHeat);
    }
}
