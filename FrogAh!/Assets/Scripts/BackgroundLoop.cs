using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class BackgroundLoop : MonoBehaviour
{   
    public GameController gc;
    public Transform target;

    public Transform bg1;
    public Transform bg2;
    public Transform bg3;
    public Transform bg4;
    public Transform bg5;
    public Transform bg6;
    public Transform bg7;
    public Transform bg8;
    private float size;
    private Rigidbody2D rb;

    void Start(){
        size=bg1.GetComponent<BoxCollider2D>().size.y;
        rb=gameObject.GetComponent<Rigidbody2D>();

        
    }

    void Update(){
        Vector3 targetPos = new Vector3(target.position.x,target.position.y,transform.position.z);
         
       
        transform.position=Vector3.Lerp(transform.position,targetPos,0.2f); 

        if(transform.position.y >= bg2.position.y){
            if (gc.score <20)
            {
                bg1.position = new Vector3(bg1.position.x, bg2.position.y + 23,bg1.position.z);
                SwitchBG();
            }
        }

        if(transform.position.y >= bg4.position.y){
            if (gc.score >= 20 && gc.score <40)
            {
                bg3.position = new Vector3(bg3.position.x, bg4.position.y + 16.5f,bg3.position.z);
                SwitchBG2();
            }
        }

        if(transform.position.y >= bg6.position.y){
            if (gc.score >=40 && gc.score <60)
            {
                bg5.position = new Vector3(bg5.position.x, bg6.position.y + 16.5f,bg5.position.z);
                SwitchBG3();
            }
        }

        if(transform.position.y >= bg8.position.y){
            if (gc.score >=75 && gc.score<=100)
            {   
                bg7.position = new Vector3(bg7.position.x, bg8.position.y + 16.5f  ,bg7.position.z);
                SwitchBG4();
            }
        }

        if (target.position.y>=185)
        {
            rb.gravityScale=2.5f;
        }
    }

    private void SwitchBG(){
        Transform temp=bg1;
        bg1 = bg2;
        bg2 = temp;
    }

    private void SwitchBG2(){
        Transform temp=bg3;
        bg3 = bg4;
        bg4 = temp;
    }

    private void SwitchBG3(){
        Transform temp=bg5;
        bg5 = bg6;
        bg6 = temp;
    }

    private void SwitchBG4(){
        Transform temp=bg7;
        bg7 = bg8;
        bg8 = temp;
    }
}
