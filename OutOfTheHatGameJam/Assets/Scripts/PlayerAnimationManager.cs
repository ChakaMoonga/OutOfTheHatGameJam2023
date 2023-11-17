using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
    public  Rigidbody2D rb;
    public Transform squash;
    //handling animation
    //public SpriteRenderer sprite1;
    // public SpriteRenderer sprite2;
  //  public SpriteRenderer sprite3;
    private Animator anim;
    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //sprite1 = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

    }

    private void FixedUpdate()
    {
       // anim.SetFloat("speed", rb.velocity.magnitude);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            squash.transform.Rotate(0, 180f, 0);
           // sprite1.flipX = true;
            //sprite2.flipX = true;
            //sprite3.flipX = true;
            isMoving = true;
            anim.SetBool("isMoving", true);
        }
        else if( Input.GetKeyUp(KeyCode.A))
        {
            squash.transform.Rotate(0, 180f, 0);
            isMoving = false;
            anim.SetBool("isMoving",false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
           // squash.transform.Rotate(0, 180f, 0);
            //sprite1.flipX = false;
            //sprite2.flipX = false;
            //sprite3.flipX = false;
            anim.SetBool("isMoving", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            //squash.transform.Rotate(0, 180f, 0);
            isMoving = false;
            anim.SetBool("isMoving", false);
        }
    }
}