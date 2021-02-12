using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStage : MonoBehaviour
{
    public Transform player;
    public float speed;

    Rigidbody2D rb2D;
    SpriteRenderer sprite;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        float color = sprite.color.r;
        float scale = rb2D.transform.localScale.x;
        float velX = rb2D.velocity.x;

        if (player.position.x >= transform.position.x)
        {
            rb2D.transform.localScale = new Vector3(scale + 0.1f, rb2D.transform.localScale.y);
            rb2D.velocity = new Vector2(velX-0.05f, rb2D.velocity.y);
            sprite.color = new Color(color - 0.1f, color - 0.1f, color - 0.1f);
        }
    }
}
