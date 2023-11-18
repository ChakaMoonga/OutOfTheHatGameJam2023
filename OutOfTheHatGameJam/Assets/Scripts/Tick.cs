using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tick : MonoBehaviour
{
    [SerializeField] Transform playerCheckCollider;
    public Rigidbody2D rb;
    public float tickRadius;
    [SerializeField] LayerMask playerLayer;
    public Collider2D[] colliders;
    public bool inZone;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        PlayerCheck();
    }

    public void TickFall()
    {
        rb.gravityScale = 1f;
    }

    void PlayerCheck()
    {
        inZone = false;
            
        //Check if the GroundCheck collider is colliding with a Ground layer object; if true, you're grounded
        colliders = Physics2D.OverlapCircleAll(transform.position, tickRadius, playerLayer);
        
        
        if (colliders.Length > 0)
        {
            inZone = true;
            Detonate();
        }
    }

    void Detonate()
    {
        Destroy(this.gameObject);
    }
    
    void OnDrawGizmos()
    {
        // Draw a circle at the position of the groundCheckCollider with a radius of 0.5f
        Gizmos.color = inZone ? Color.green : Color.red;
        Gizmos.DrawWireSphere(playerCheckCollider.position, tickRadius);
    }
}
