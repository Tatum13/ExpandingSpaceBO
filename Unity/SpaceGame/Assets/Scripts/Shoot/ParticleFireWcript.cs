using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable 

public class ParticleFireWcript : MonoBehaviour
{
    private ParticleSystem psLeft;
    private ParticleSystem psRight;

    public PlayerEngineScript playerEngine;

    public GameObject cannonLeft;
    public GameObject cannonRight;

    // Start is called before the first frame update
    void Start()
    {
        playerEngine = GetComponent<PlayerEngineScript>();

        psLeft = cannonLeft.GetComponent<ParticleSystem>();
        psRight = cannonRight.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        fireCannons();
    }

    void fireCannons()
    {
        if (Input.GetMouseButton(0) && playerEngine.currentHeat >= 0)
        {
            psLeft.enableEmission = true;
            psRight.enableEmission = true;
        }
        else
        {
            psLeft.enableEmission = false;
            psRight.enableEmission = false;
        }
    }

}
