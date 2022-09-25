using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController1 : MonoBehaviour
{   
    public float movespeed;
    public float jumpVelocity;
    public Animator animator;

    private float horizontalInput;
    private float verticalInput;
    public bool isjumping;
    
    public LayerMask groundMask;
    
    private Rigidbody2D rb;
    private CircleCollider2D CircleCollider2D;

    public GameManager theGameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        rb=transform.GetComponent<Rigidbody2D>();
        CircleCollider2D=transform.GetComponent<CircleCollider2D>();
        isjumping=true;

    }

    // Update is called once per frame
     void Update()//loop
    {   
        horizontalInput = Input.GetAxisRaw("Horizontal");

        
        animator.SetFloat("Horizontal",horizontalInput);

        transform.Translate(new Vector3(horizontalInput, 0, 0) * movespeed * Time.deltaTime);

        Debug.Log("Horizontal : " + horizontalInput);
        
    
        isjumping=Physics2D.OverlapBox(new Vector2(gameObject.transform.position.x,gameObject.transform.position.y-0.5f),new Vector2(0.9f,0.4f),0f,groundMask);  
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("w") || Input.GetKey("up"))
        {
            if(isjumping==true)
            {
                rb.velocity = Vector2.up*jumpVelocity; 
            }
                           
    
        }
        
    }

    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.tag == "KillBox")
        {
            theGameManager.RestartGame();
        }
    }

   
    
   
    
   
}
