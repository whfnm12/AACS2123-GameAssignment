using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    
    public static int lives=3;
    public GameObject live1;
    public GameObject live2;
    public GameObject live3;
    public FrogController thePlayer;
    
    public AudioClip jumpsound;
    static AudioSource audiosrc;
    
    // Start is called before the first frame update
    void Start()
    {
        rb=transform.GetComponent<Rigidbody2D>();
        CircleCollider2D=transform.GetComponent<CircleCollider2D>();
        audiosrc=GetComponent<AudioSource>();
        isjumping=true;
        live1= GameObject.Find("heart1");
        live2= GameObject.Find("heart2");
        live3= GameObject.Find("heart3");

    }

    // Update is called once per frame
     void Update()//loop
    {   
        horizontalInput = Input.GetAxisRaw("Horizontal");

        
        animator.SetFloat("Horizontal",horizontalInput);

        transform.Translate(new Vector3(horizontalInput, 0, 0) * movespeed * Time.deltaTime);

        Debug.Log("Horizontal : " + horizontalInput);
        
    
        isjumping=Physics2D.OverlapBox(new Vector2(gameObject.transform.position.x,gameObject.transform.position.y-0.5f),new Vector2(0.9f,0.4f),0f,groundMask);  
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(isjumping==true)
            {audiosrc.PlayOneShot(jumpsound);
                rb.velocity = Vector2.up*jumpVelocity; 
                
               
            }
        }

        if (lives<=2)
        {
            live1.gameObject.SetActive(false);
        }

        if (lives<=1)
        {
            live2.gameObject.SetActive(false);
        }

        
        
    }

    IEnumerator OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag.Equals("KillBox"))
        {   
            lives-=1; 
            yield return new WaitForSeconds(0.1f);
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene("TimeMode");
            thePlayer.gameObject.SetActive(false);
            yield return new WaitForSeconds(1f);
            thePlayer.gameObject.SetActive(true);
            
            
            
        }
  
        if (lives<=0)
        {
            live3.gameObject.SetActive(false);
            SceneManager.LoadScene("Game Over");
        }
        
    }

   
    
   
    
   
}
