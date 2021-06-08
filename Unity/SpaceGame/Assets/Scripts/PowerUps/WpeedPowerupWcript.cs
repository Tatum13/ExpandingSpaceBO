using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WpeedPowerupWcript : MonoBehaviour
{
    public bool powerupEffect;
    public bool resetPowerup;

    float baseSpeed;
    float baseAcceleration;

    // Start is called before the first frame update
    void Start()
    {
        TopDownControllerScript topdowncontrollerscript = GetComponent<TopDownControllerScript>();

        baseSpeed = topdowncontrollerscript.maxSpeed;
        baseAcceleration = topdowncontrollerscript.accelerationFactor;
    }

    private void Update()
    {
        TopDownControllerScript topdowncontrollerscript = GetComponent<TopDownControllerScript>();

        if (powerupEffect == true)
        {
            topdowncontrollerscript.maxSpeed = 12f;
            topdowncontrollerscript.accelerationFactor = 10f;
        }
        else
        {
            topdowncontrollerscript.maxSpeed = baseSpeed;
            topdowncontrollerscript.accelerationFactor = baseAcceleration;
        }
    }

    IEnumerator OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Speed")
        {
            Destroy(col.gameObject);

            if (powerupEffect == false)
            {
                powerupEffect = true;

                float cooldown = 7f;
                float currentTime = Time.time;

                while (Time.time < currentTime + cooldown)
                {
                    if (resetPowerup == true)
                    {
                        resetPowerup = false;
                        currentTime = Time.time;
                    }
                    yield return null;
                }

                powerupEffect = true;
                yield return new WaitForSeconds(cooldown);

                powerupEffect = false;
            }
            else
            {
                resetPowerup = true;
            }
        }
    }
}
