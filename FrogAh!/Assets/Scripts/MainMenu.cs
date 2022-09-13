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

    }

    public void Achievement()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
