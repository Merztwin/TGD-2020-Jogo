using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 4f;//sets movement speed
    public float jumpForce = 4f;//sets impulse intensivity
    public bool isGrounded = false;//True if the player is on the floor

    private float movementInput;

    public Animator animator;//Animator access
    private Rigidbody2D rb;//RgidiBody2D


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        animator.SetFloat("HorizontalMovement", Input.GetAxis("Horizontal"));

        movementInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(movementInput * movementSpeed, rb.velocity.y);

        Jump();
    }

    //jump method
   public void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            gameObject.GetComponent<AudioSource>().Play();
        }
    }

}