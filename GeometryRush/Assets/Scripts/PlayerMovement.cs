using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float speed;

    public float jumpForce;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float posX;

    void Start()
    {
        posX = -1;
        rb2D = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        Movement();
        Debug.Log(posX);
        Debug.Log(rb2D.position.x);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        if (posX == rb2D.position.x)
            Debug.Log("END");

        
        posX = rb2D.position.x;
    }

    void Movement()
    {
        rb2D.velocity = new Vector2(speed, rb2D.velocity.y);
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.velocity = Vector2.up * jumpForce;
        }
    }
}
