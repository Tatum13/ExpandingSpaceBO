using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EngineBarScript : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;

    public void SetMaxHeat(float heat)
    {
        slider.maxValue = heat;
        slider.value = heat;
    }

    public void SetHeat(float heat)
    {
        slider.value = heat;
    }
}
