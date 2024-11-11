using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
           SceneManager.LoadScene("MainMenu");
        }
    }
}

/*
IF I HAD MULTIPLE LEVELS!:

 //Find what scene we on get build index and increase by 1
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
*/