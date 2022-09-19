using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveInput;
    private Rigidbody2D rb;
    public PolygonCollider2D coll;
    [SerializeField] float jumpTime;
    [SerializeField] private LayerMask jumpableGround;
    [SerializeField] int jumpForce;
    [SerializeField] float fallMultiplier;
    [SerializeField] float jumpMultiplier;

    Vector2 vecGravity;

    bool isJumping;
    float jumpCounter;

    void Start()
    {
        vecGravity = new Vector2(0, -Physics2D.gravity.y);
        rb = gameObject.GetComponent<Rigidbody2D>();
        coll = GetComponent<PolygonCollider2D>();
    }

    private void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isJumping = true;
            jumpCounter = 0;
        }

        if (rb.velocity.y > 0 && isJumping)
        {
            jumpCounter += Time.deltaTime;
            if (jumpCounter > jumpTime)
            {
                isJumping = false;
            }
            float t = jumpCounter / jumpTime;
            float currentJumpM = jumpMultiplier;

            if (t > 0.5f)
            {
                currentJumpM = jumpMultiplier * (1 - t);
            }
            rb.velocity += vecGravity * jumpMultiplier * Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
            jumpCounter = 0;

            if (rb.velocity.y > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.6f);
            }
        }

        if (rb.velocity.y < 0)
        {

            rb.velocity -= vecGravity * fallMultiplier * Time.deltaTime;

        }


    }

    bool isGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);

    }
}
