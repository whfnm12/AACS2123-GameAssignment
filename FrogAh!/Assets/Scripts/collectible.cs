using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{   
    GameController gc;
    int coinValue=1;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {   if(other.gameObject.CompareTag("Player")){
            Destroy(this.gameObject);
            Debug.Log("Enter Collider Coin");
            gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
            gc.changeScore(coinValue);
        } 
    }

     
    // Update is called once per frame
    void Update()
    {
        
    }
}