using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGetScoreScript : MonoBehaviour
{
    public ScoreTextScript score;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Trash")
        {
            score.scoreAmount += 1;
            Destroy(collision.gameObject);
        }
    }
}
