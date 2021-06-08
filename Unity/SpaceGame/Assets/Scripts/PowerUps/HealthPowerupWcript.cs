using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerupWcript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        PlayerHealthScript playerhealthscript = GetComponent<PlayerHealthScript>();

        if (col.gameObject.tag == "Health")
        {
            Destroy(col.gameObject);
            playerhealthscript.currentHealth = 99f;
        }
    }
}
