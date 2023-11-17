using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Outlets
    [Header("Outlets")]
    private Rigidbody2D rb;

    [SerializeField] Transform groundCheckCollider;
    [SerializeField] LayerMask groundLayer;
    
    //State Tracking
    [Header("State Tracking")]
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public float bounceForce = 15f;
    public float groundCheckRadius;
    public bool isGrounded = false;

    public KeyCode pauseGame;
    //public KeyCode playerJump;

    private void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
        //sprite = GetComponent<SpriteRenderer>();
        //anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        GroundCheck();

        //anim.SetFloat("speed", rb.velocity.magnitude);

        if (Input.GetKey(pauseGame))
        {
            PauseMenu.instance.Show();
        }
    }
    
    private void Update() 
    {
        if (PauseMenu.gameIsPaused == true)
        {
            return;
        } else
        {
            //Movement
            float moveInput = Input.GetAxis("Horizontal"); 
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
            //sprite.flipX = true;
        
            //Jump
            if (Input.GetButtonDown("Jump")) // Check if the jump button is pressed
            //if (Input.GetKey(playerJump))
            {
                if (isGrounded) //Check if the player is grounded
                {
                    rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse); // Apply the jump force
                }
            }
        }  
    }
    
    //Ground Check
    void GroundCheck()
    {
        //By default, isGrounded is false
        isGrounded = false;
            
        //Check if the GroundCheck collider is colliding with a Ground layer object; if true, you're grounded
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckCollider.position, groundCheckRadius, groundLayer);
        
        
        if (colliders.Length > 0)
        {
            isGrounded = true;
        }
    }
    
    //Bouncing
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BouncyMushroom"))
        {
            Debug.Log("Bounce!");
            rb.AddForce(new Vector2(0f, bounceForce), ForceMode2D.Impulse); //Add upwards force to player
        }
        //Check if we have collided with the ground (not necessarily with our feet)
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            
            //Check what's below the player's feet
            RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, Vector2.down, 2f);

            //For each hit...
            for (int i = 0; i < hits.Length; i++)
            {
                RaycastHit2D hit = hits[i];
                
                //Check if we're on the ground
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Ground"))
                {
                    //Check if it's an object that can be bounced off of
                    Debug.Log("Solid ground");
                }
            }
        } 
    }
    
    /* Draws the ground detector circle
    void OnDrawGizmos()
    {
        // Draw a circle at the position of the groundCheckCollider with a radius of 0.5f
        Gizmos.color = isGrounded ? Color.green : Color.red;
        Gizmos.DrawWireSphere(groundCheckCollider.position, groundCheckRadius);
    }
   */
}
   

