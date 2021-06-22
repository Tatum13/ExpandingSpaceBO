using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeToInsideScript : MonoBehaviour
{
    public bool change = false;
    public GameObject pressTab;
    private GameObject environment;


    private void Start()
    {
        environment = GameObject.Find("/Environment");
        GameObject.Find("Player_Ship").transform.position = new Vector2(PlayerPrefs.GetFloat("X"), PlayerPrefs.GetFloat("Y"));

        pressTab = GameObject.Find("/Environment/SavePoints/PressTab").gameObject;


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player_Ship")
        {
            change = true;
            pressTab.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player_Ship")
        {
            change = false;
            pressTab.SetActive(false);
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && change)
        {
            SaveLocation();
            SceneManager.LoadScene(5);
        }
    }

    public void SaveLocation()
    {
        PlayerPrefs.SetFloat("X", GameObject.Find("Player_Ship").transform.position.x);
        PlayerPrefs.SetFloat("Y", GameObject.Find("Player_Ship").transform.position.y);
    }
}
