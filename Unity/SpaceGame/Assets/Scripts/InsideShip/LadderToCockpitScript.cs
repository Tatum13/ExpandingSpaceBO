using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LadderToCockpitScript : MonoBehaviour
{
    private bool change = false;
    public GameObject keyUp;

    private void Start()
    {
        keyUp = transform.Find("Up").gameObject;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            change = true;
            keyUp.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            change = false;
            keyUp.SetActive(false);
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && change)
        {
            SceneManager.LoadScene(5);
        }
    }
}
