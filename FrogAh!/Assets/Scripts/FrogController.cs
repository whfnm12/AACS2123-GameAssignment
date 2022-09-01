using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour
{   
    public float movespeed = 1;
    public Animator animator;

    private float horizontalInput;
    private float verticalInput;
    bool isjumping;
  
    [SerializeField] private LayerMask platformlayermask;
    private Rigidbody2D Rigidbody2D;
    private BoxCollider2D boxCollider2D;
    
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D=transform.GetComponent<Rigidbody2D>();
        boxCollider2D=transform.GetComponent<BoxCollider2D>();
        isjumping=true;

    }

    // Update is called once per frame
     void Update()//loop
    {   
        horizontalInput = Input.GetAxis("Horizontal");
        
        animator.SetFloat("Horizontal",horizontalInput);

        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * movespeed * Time.deltaTime);

        Debug.Log("Horizontal : " + horizontalInput);
        

        if(Input.GetKeyDown(KeyCode.Space) && isjumping){
            float jumpVelocity=50f;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,jumpVelocity),ForceMode2D.Impulse);
            isjumping=false;
        }
    }
    
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag== "platform" && isjumping==false){
            isjumping = true;
        }
    }

    void Animation(){
        if(isjumping==false){
            animator.SetBool("animjump",true);
        }
        if(isjumping==true){
            animator.SetBool("animjump",false);
        }
        
    }

   
}
