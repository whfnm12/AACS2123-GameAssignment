using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bricks : MonoBehaviour
{
    Rigidbody2D rb;

    void Start(){
        rb=GetComponent<Rigidbody2D>();
    }
   
    IEnumerator OnCollisionEnter (Collision coll) {
 
     yield return new WaitForSeconds(2);//wait x amount of seconds
     Destroy(gameObject);
 
 }

    
}
