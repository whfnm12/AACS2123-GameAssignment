using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingPlatform : MonoBehaviour
{   
    public Transform pos1,pos2;
    public float speed;
    public Transform startingPos;
    public GameObject movingplatform;
    
    Vector3 nextPos;

    private int i;
    // Start is called before the first frame update
    void Start()
    { 
        nextPos=startingPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pos1.position)
        {
            nextPos=pos2.position;
        }   

        if (transform.position == pos2.position)
        {
            nextPos=pos1.position;
        }

        movingplatform=GameObject.FindWithTag("movingplatform");

        if (movingplatform!=null)
        {
            transform.position = Vector3.MoveTowards(transform.position,nextPos,speed*Time.deltaTime);

        }


        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        
        collision.collider.transform.SetParent(transform);
     
        
    }

    private void OnCollisionExit2D(Collision2D collision){
        collision.collider.transform.SetParent(null);

    }
}
