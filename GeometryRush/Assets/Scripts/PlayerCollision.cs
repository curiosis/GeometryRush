using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public static bool playerDead = false;
    private SpriteRenderer sprite;
    private TrailRenderer trailRenderer;
    private bool dead;
    public GameObject deadEffect;
    private PlayerMovement player;
    private Rigidbody2D rb2D;

    public GameObject plane;

    void Start()
    {
        playerDead = false;
        player = GetComponent<PlayerMovement>();
        sprite = GetComponent<SpriteRenderer>();
        trailRenderer = GetComponent<TrailRenderer>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if(playerDead)
            StartCoroutine(Dead());
    }

    IEnumerator Dead()
    {
        if (!dead)
        {
            player.speed = 0f;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spikes"))
        {
            PlayerCollision.playerDead = true;
        }

        if (collision.CompareTag("ExtraJump"))
        {
            rb2D.velocity = Vector3.up * (player.jumpForce * 1.5f);
        }

        if (collision.CompareTag("ChangeType0"))
        {
            player.type = 0;
            plane.SetActive(false);
            LevelManager.flash = true;
        }
            

        if (collision.CompareTag("ChangeType1"))
        {
            player.type = 1;
            plane.SetActive(true);
            LevelManager.flash = true;
        }
            

        if (collision.CompareTag("ChangeType2"))
        {
            player.type = 2;
            plane.SetActive(false);
            LevelManager.flash = true;
        }
            
    }
}