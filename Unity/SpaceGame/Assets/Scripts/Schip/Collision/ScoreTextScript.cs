using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreTextScript : MonoBehaviour
{
    public int scoreAmount;
    private TextMeshProUGUI scoreText;


    void Start()
    {
        scoreText = gameObject.GetComponent<TextMeshProUGUI>();
        scoreAmount = 0;
    }

    
    void Update()
    {
        scoreText.text = "Score: " + scoreAmount;
    }

   
}
