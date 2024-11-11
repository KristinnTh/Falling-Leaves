using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Collectable.ResetTotal(); //Reset the total collectible count
        SceneManager.LoadSceneAsync("Level1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
