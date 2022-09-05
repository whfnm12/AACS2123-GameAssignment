using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingPlatform : MonoBehaviour
{
    Rigidbody2D rb;

    void Start(){
        rb=GetComponent<Rigidbody2D>();
    }
   
    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.name.Equals("Frog")){}
        {
            Invoke("DropPlatform",2.0f);
            Destroy(gameObject,3f);
        }
    }

    void DropPlatform(){
        rb.isKinematic=false;
    }
}
