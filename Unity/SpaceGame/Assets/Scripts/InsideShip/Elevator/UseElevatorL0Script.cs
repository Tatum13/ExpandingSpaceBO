using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseElevatorL0Script : MonoBehaviour
{
    public bool eliasInElevator = false;
    public bool kaylaInElevator = false;
    public bool aceInElevator = false;
    public GameObject up;


    // Start is called before the first frame update
    void Start()
    {
        up = GameObject.Find("Elevator/Level 0/up");
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Elias")
        {
            eliasInElevator = true;
            up.SetActive(true);
        }
        if (other.gameObject.name == "Kayla")
        {
            kaylaInElevator = true;
            up.SetActive(true);
        }
        if (other.gameObject.name == "Ace")
        {
            aceInElevator = true;
            up.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Elias")
        {
            eliasInElevator = false;
            up.SetActive(false);
        }
        if (other.gameObject.name == "Kayla")
        {
            kaylaInElevator = false;
            up.SetActive(false);
        }
        if (other.gameObject.name == "Ace")
        {
            aceInElevator = false;
            up.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Moving one level up when pressing UpArrow
        if (Input.GetKeyDown(KeyCode.UpArrow) && eliasInElevator)
        {
            GameObject.Find("Elias").transform.position = new Vector2(3.18f, -3.68f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && kaylaInElevator)
        {
            GameObject.Find("Kayla").transform.position = new Vector2(3.18f, -3.68f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && aceInElevator)
        {
            GameObject.Find("Ace").transform.position = new Vector2(3.18f, -3.68f);
        }
    }
}
