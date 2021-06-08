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
        currentHeat = maxHeat;
        engineBar.SetMaxHeat(maxHeat);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            HighHeat(20);
        }
        else if (currentHeat < maxHeat)
        {
            currentHeat += 6f * Time.deltaTime;
            engineBar.SetHeat(currentHeat);
        }

        else if (currentHeat <= 0)
        {
            currentHeat += 4f * Time.deltaTime;
            engineBar.SetHeat(currentHeat);
        }
    }

    void HighHeat(float heatDamage)
    {
        currentHeat -= heatDamage;

        engineBar.SetHeat(currentHeat);
    }
}
