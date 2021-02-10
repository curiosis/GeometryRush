using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private SpriteRenderer sprite;
    private TrailRenderer trailRenderer;

    public float speed;

    public float jumpForce;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float posX, posY;

    public GameObject deadEffect, player;

    private bool dead=false;

    void Start()
    {
        posX = -1;
        posY = -1;
        rb2D = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        trailRenderer = GetComponent<TrailRenderer>();
    }

    
    void FixedUpdate()
    {
            rb2D.velocity = new Vector2(speed, rb2D.velocity.y);

            if (posX == rb2D.position.x && posY == rb2D.position.y)
            {
                
                StartCoroutine(Dead());
            }
            posX = rb2D.position.x;
            posY = rb2D.position.y;
    }

    private void Update()
    {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
            if (isGrounded && Input.GetKeyDown(KeyCode.Space))
            {
                rb2D.velocity = Vector3.up * jumpForce;
            }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spikes"))
        {
            StartCoroutine(Dead());
        }

        if (collision.CompareTag("ExtraJump"))
        {
            rb2D.velocity = Vector3.up * (jumpForce * 1.5f);
        }
    }

    IEnumerator Dead()
    {
        if (!dead)
        {
            speed = 0f;
            sprite.color = new Color(0, 0, 0, 0);
            trailRenderer.enabled = false;
            Instantiate(deadEffect, transform.position, transform.rotation);
            dead = true;
            BackgroundMelody.stopMelody = true;
            yield return new WaitForSeconds(1);
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
