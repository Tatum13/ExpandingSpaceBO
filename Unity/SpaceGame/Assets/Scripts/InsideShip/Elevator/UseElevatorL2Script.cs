using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseElevatorL2Script : MonoBehaviour
{

    public bool eliasInElevator = false;
    public bool kaylaInElevator = false;
    public bool aceInElevator = false;
    public GameObject up;
    public GameObject down;


    // Start is called before the first frame update
    void Start()
    {
        down = GameObject.Find("Elevator/Level 2/down");
        up = GameObject.Find("Elevator/Level 2/up");
        //something
    }

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Elias")
        {
            eliasInElevator = true;
            up.SetActive(true);
            down.SetActive(true);
        }
        if (other.gameObject.name == "Kayla")
        {
            kaylaInElevator = true;
            up.SetActive(true);
            down.SetActive(true);
        }
        if (other.gameObject.name == "Ace")
        {
            aceInElevator = true;
            up.SetActive(true);
            down.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Elias")
        {
            eliasInElevator = false;
            up.SetActive(false);
            down.SetActive(false);
        }
        if (other.gameObject.name == "Kayla")
        {
            kaylaInElevator = false;
            up.SetActive(false);
            down.SetActive(false);
        }
        if (other.gameObject.name == "Ace")
        {
            aceInElevator = false;
            up.SetActive(false);
            down.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Moving one level up when pressing UpArrow
        if (Input.GetKeyDown(KeyCode.UpArrow) && eliasInElevator)
        {
            GameObject.Find("Elias").transform.position = new Vector2(3.18f, 10.62f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && kaylaInElevator)
        {
            GameObject.Find("Kayla").transform.position = new Vector2(3.18f, 10.62f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && aceInElevator)
        {
            GameObject.Find("Ace").transform.position = new Vector2(3.18f, 10.62f);
        }

        // Moving down one leven when pressing DownArrow
        if (Input.GetKeyDown(KeyCode.DownArrow) && eliasInElevator)
        {
            GameObject.Find("Elias").transform.position = new Vector2(3.18f, -3.68f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && kaylaInElevator)
        {
            GameObject.Find("Kayla").transform.position = new Vector2(3.18f, -3.68f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && aceInElevator)
        {
            GameObject.Find("Ace").transform.position = new Vector2(3.18f, -3.68f);
        }
    }
}
