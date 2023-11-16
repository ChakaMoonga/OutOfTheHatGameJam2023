using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShifter : MonoBehaviour
{
    public GameObject playerStand; // The first game object
    public GameObject playerBall; // The second game object
    public Rigidbody2D rb; // The Rigidbody2D to be modified
    private bool isBall = false; // A state change
    public float zRotation = 90f;
    public float ballPopHeight;

    public PlayerController playerController;
    void Update()
    {
        // Check if the L-shift key is pressed
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            // Toggle the game objects
            playerStand.SetActive(!playerStand.activeSelf);
            playerBall.SetActive(!playerBall.activeSelf);
            
            isBall = !isBall;
            // Toggle the freeze rotation of the Rigidbody2D
            if (isBall)
            {
                rb.constraints &= ~RigidbodyConstraints2D.FreezeRotation;
            }
            else
            {
                rb.constraints |= RigidbodyConstraints2D.FreezeRotation; 
                //rb.transform.Rotate(0, 0, zRotation);
                rb.transform.eulerAngles = new Vector3(rb.transform.eulerAngles.x, rb.transform.eulerAngles.y, zRotation);

                if (playerController.isGrounded)
                {
                    rb.AddForce(new Vector2(0f, ballPopHeight), ForceMode2D.Impulse);
                }
            }
        }
    }
}

