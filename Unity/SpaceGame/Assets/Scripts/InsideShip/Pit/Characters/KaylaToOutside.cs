using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KaylaToOutside : MonoBehaviour
{
    public bool change = false;
    public GameObject pressTab;

    private void Start()
    {
        pressTab = transform.Find("PressTab").gameObject; ;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Kayla")
        {
            change = true;
            pressTab.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Kayla")
        {
            change = false;
            pressTab.SetActive(false);
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && change)
        {
            SceneManager.LoadScene(1);
        }
    }
}
