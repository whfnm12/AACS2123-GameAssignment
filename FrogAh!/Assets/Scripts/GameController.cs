using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

  

public class GameController : MonoBehaviour
{
    
    public TextMeshProUGUI text;
    public int score = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
         
    }
    public void changeScore (int coinValue)
        {
        score += coinValue;
        text.text = score.ToString();
        }
    // Update is called once per frame
    void Update()
    {
       
    }

    

   
}