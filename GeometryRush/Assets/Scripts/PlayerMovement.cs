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

    private float posX, posY;

    void Start()
    {
        posX = -1;
        posY = -1;
        rb2D = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        if (LevelManager.startLevel)
        {
            rb2D.velocity = new Vector2(speed, rb2D.velocity.y);

            if (posX == rb2D.position.x && posY == rb2D.position.y)
            {
                SceneManager.LoadScene(0);
            }

            posX = rb2D.position.x;
            posY = rb2D.position.y;
        }
    }

    private void Update()
    {
        if (LevelManager.startLevel)
        {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
            if (isGrounded && Input.GetKeyDown(KeyCode.Space))
            {
                rb2D.velocity = Vector3.up * jumpForce;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Spikes"))
            SceneManager.LoadScene(0);
    }
}
