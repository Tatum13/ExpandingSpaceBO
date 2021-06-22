using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("X", -7.5f);
        PlayerPrefs.SetFloat("Y", -3.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
