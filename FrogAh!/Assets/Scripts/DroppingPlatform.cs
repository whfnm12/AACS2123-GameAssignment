using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingPlatform : MonoBehaviour
{
    Rigidbody2D rb;

    void Start(){
        rb=GetComponent<Rigidbody2D>();
    }
   
    void OnCollisionEnter2D (Collision2D col) {
 
        if (col.gameObject.tag.Equals("Player"))
        {
            Invoke("DropPlatform",2f);

            
        }
 }
void DropPlatform(){
            gameObject.SetActive(false);
        }

    
}
