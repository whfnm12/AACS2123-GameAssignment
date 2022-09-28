using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{   
    GameController gc;
    int coinValue=1;
    int scoreValue=1;

    
    public AudioClip buttonHitSounds;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc=GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {   if(other.gameObject.CompareTag("Player")){
            if (gameObject.tag.Equals("Coin"))
            {               AudioSource.PlayClipAtPoint(buttonHitSounds, transform.position);

                Destroy(this.gameObject);
                Debug.Log("Enter Collider Coin");
                gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
                gc.changeCoin(coinValue);
            }

            if (gameObject.tag.Equals("platformscorecounting"))
            {
                Destroy(this.gameObject);
                Debug.Log("Enter Collider Score");
                gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
                gc.changeScore(scoreValue);
            }
            
        } 
    }

     
    // Update is called once per frame
    void Update()
    {
        
    }
}