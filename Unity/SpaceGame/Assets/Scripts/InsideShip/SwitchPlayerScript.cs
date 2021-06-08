using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchPlayerScript : MonoBehaviour
{

    public GameObject Elias;
    public GameObject Kayla;
    public GameObject Ace;
    
    // Start is called before the first frame update
    void Start()
    {
        Elias = GameObject.Find("Elias");
        Kayla = GameObject.Find("Kayla");
        Ace = GameObject.Find("Ace");
        ActivateElias();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActivateElias();
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActivateKayla();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActivateAce();
        }
    }

    public void ActivateElias()
    {
        Elias.SetActive(true);
        Kayla.SetActive(false);
        Ace.SetActive(false);
    }

    public void ActivateKayla()
    {
        Elias.SetActive(false);
        Kayla.SetActive(true);
        Ace.SetActive(false);
    }

    public void ActivateAce()
    {
        Elias.SetActive(false);
        Kayla.SetActive(false);
        Ace.SetActive(true);
    }

}
