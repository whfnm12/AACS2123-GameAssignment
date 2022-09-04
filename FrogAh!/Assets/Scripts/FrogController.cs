using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour
{   
    public float movespeed = 1;
    public Animator animator;

    private float horizontalInput;
    private float verticalInput;
    public bool isjumping;
    
    public LayerMask groundMask;
    public bool canJump=true;
    public float jumpValue=0.0f;

    [SerializeField] private LayerMask platformlayermask;
    private Rigidbody2D rb;
    private CircleCollider2D CircleCollider2D;
    
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
        horizontalInput = Input.GetAxis("Horizontal");
        
        animator.SetFloat("Horizontal",horizontalInput);

        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * movespeed * Time.deltaTime);

        Debug.Log("Horizontal : " + horizontalInput);
        
        if ((jumpValue==0.0f || jumpValue<15f) && isjumping)
        {
            rb.velocity=new Vector2(horizontalInput*movespeed,rb.velocity.y);
        }

        isjumping=Physics2D.OverlapBox(new Vector2(gameObject.transform.position.x,gameObject.transform.position.y-0.5f),new Vector2(0.9f,0.4f),0f,groundMask);
       
      
        if (Input.GetKey("space") && isjumping && canJump)
        {
            jumpValue+=0.1f;
        }

        if (Input.GetKeyDown("space") && isjumping && canJump)
        {
            rb.velocity=new Vector2(0.0f,rb.velocity.y);
        }

        if (jumpValue>=13f && isjumping)
        {
            float tempx=horizontalInput*movespeed;
            float tempy=jumpValue;
            rb.velocity=new Vector2(tempx,tempy);
            Invoke("ResetJump",0.2f);
            }

        if (Input.GetKeyUp("space"))
        {
            if (isjumping)
            {
                rb.velocity=new Vector2(horizontalInput*movespeed,jumpValue*2);
                jumpValue=0.0f;
            }
            canJump=true;
        }
        
    }

    void ResetJump(){
        canJump=false;
        jumpValue=0;
    }
    
   
    
   
}
