using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LadderToUpgradesScript : MonoBehaviour
{
    private bool change = false;
    public GameObject keyDown;

    private void Start()
    {
        keyDown = transform.Find("Down").gameObject;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            change = true;
            keyDown.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            change = false;
            keyDown.SetActive(false);
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && change)
        {
            SceneManager.LoadScene(4);
        }
    }
}
