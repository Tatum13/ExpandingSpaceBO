using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable 

public class ParticleFireWcript : MonoBehaviour
{
    private ParticleSystem psLeft;
    private ParticleSystem psRight;

    public GameObject cannonLeft;
    public GameObject cannonRight;

    public GameObject player;
    public TopDownControllerScript topdowncontrollerscript;

    // Start is called before the first frame update
    void Start()
    {
        cannonLeft = GameObject.Find("CannonLeft");
        cannonRight = GameObject.Find("CannonRight");

        psLeft = cannonLeft.GetComponent<ParticleSystem>();
        psRight = cannonRight.GetComponent<ParticleSystem>();

        topdowncontrollerscript = player.GetComponent<TopDownControllerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        fireCannons();
    }

    void fireCannons()
    {
        if (Input.GetMouseButton(0))
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
