using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterButtonScaleScript : MonoBehaviour
{
    GameObject enterImage;
    void Update()
    {
        if (enterImage)
        {
            transform.localScale += Vector3.one * Mathf.Sin(Time.time * 2) * 1f;
        }
    }
}
