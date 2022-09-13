using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("Game Mode");
    }

    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void Achievement()
    {
        SceneManager.LoadScene("Achievement");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
