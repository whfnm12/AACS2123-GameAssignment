using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

  

public class GameController : MonoBehaviour
{
    
    public TextMeshProUGUI text;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI hiScore;
    public static int coin = 0;
    public int score = 0;
    public float hiScoreCount;
    
    
    // Start is called before the first frame update
    void Start()
    {
         if (PlayerPrefs.GetInt("HighScore") != null)
         {
            hiScoreCount=PlayerPrefs.GetFloat("HighScore");
         }
    }
    public void changeCoin (int coinValue)
        {
        coin += coinValue;
        text.text = coin.ToString();
        }

    public void changeScore (int scoreValue)
        {
        score += scoreValue;
        text1.text = score.ToString();
        }
    // Update is called once per frame
    void Update()
    {   
       if (hiScoreCount<score)
        {
            hiScoreCount=score;
            PlayerPrefs.SetFloat("HighScore",hiScoreCount);
        }
        hiScore.text = "Best: " + hiScoreCount;
    }

   

    

    

   
}