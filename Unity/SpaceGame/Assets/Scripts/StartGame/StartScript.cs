using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    //public PauseMenuScript pause;

    // Start is called before the first frame update
    void Start()
    {
       // pause = GetComponent<PauseMenuScript>();
       // pause.Resume();
        PlayerPrefs.SetFloat("X", -133.3f);
        PlayerPrefs.SetFloat("Y", -8.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
