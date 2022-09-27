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
            PlatformManager.Instance.StartCoroutine("SpawnPlatform",new Vector2(transform.position.x,transform.position.y));
            Invoke("DropPlatform",1f);
            Destroy(gameObject,2f);
            
        }
 }
void DropPlatform(){
            gameObject.SetActive(false);
        }

    
}
