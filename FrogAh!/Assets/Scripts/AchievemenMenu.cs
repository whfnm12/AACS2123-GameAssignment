using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AchievemenMenu : MonoBehaviour
{  
    public void Back()
    {
        SceneManager.LoadScene("Main Menu");    //Goes to Main Menu
    }
}
