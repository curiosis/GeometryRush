using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;

    public float speed;

    public float jumpForce;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float posX, posY, posYgroundCheck;

    public int type;


    void Start()
    {
        type = 0;
        posX = -1;
        posY = -1;
        rb2D = GetComponent<Rigidbody2D>();
        ChangeRbValues();
    }

    
    void FixedUpdate()
    {
            rb2D.velocity = new Vector2(speed, rb2D.velocity.y);

            if (posX == rb2D.position.x && posY == rb2D.position.y)
            {
                PlayerCollision.playerDead = true;
            }

            posX = rb2D.position.x;
            posY = rb2D.position.y;
    }

    private void Update()
    {
        if(type == 0 || type == 2)
        {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
            if (isGrounded && Input.GetKeyDown(KeyCode.Space))
            {
                if(type == 0)
                    rb2D.velocity = Vector3.up * jumpForce;
                if (type == 2)
                    rb2D.velocity = Vector3.down * jumpForce;
            }
        }

            
        if(type == 1)
        {
            if (Input.GetMouseButton(0))
            {
                rb2D.velocity = Vector3.up * jumpForce / 3;
            }
        }
    }

    void ChangeRbValues()
    {
        if (type == 0)
        {
            rb2D.mass = 5;
            rb2D.gravityScale = 5;
        }

        if (type == 1)
        {
            rb2D.mass = 3;
            rb2D.gravityScale = 3;
        }

        if (type == 2)
        {
            rb2D.mass = 5;
            rb2D.gravityScale = -5;
            transform.Rotate(0, 0, 180);
        }
    }
}