using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopMenu : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("Main Menu");    //Goes to Main Menu
    }
}
