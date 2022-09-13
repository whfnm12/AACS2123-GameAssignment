using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemode : MonoBehaviour
{
   public void EndlessMode()
   {
       SceneManager.LoadScene("Endless Mode"); //Goes to Endless mode 
   }

   public void TimeMode()
   {
        SceneManager.LoadScene("Time Mode");    //Goes to Time mode
   }

   public void Back()
    {
        SceneManager.LoadScene("Main Menu");    //Goes to Main Menu
    }
}
