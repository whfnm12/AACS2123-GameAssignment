using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

  

public class GameController : MonoBehaviour
{
    
    public TextMeshProUGUI text;
    public TextMeshProUGUI text1;
    public int coin = 0;
    public int score = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
         
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
       
    }

    

   
}