using System.Globalization;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2D;
    Animator animator;
    SpriteRenderer sprite;

    public float speed;

    public float jumpForce;

    bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    float posX, posY;
    public int type;

    private void Awake()
    {
        
    }

    void Start()
    {
        posX = -1;
        posY = -1;
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        GetPlayerColor();
        //GetPlayerStyle();
        ChangeRbValues();
    }

    void GetPlayerColor()
    {
        string r = PlayerPrefs.GetString("PlayerColor").Substring(5, 5);
        string g = PlayerPrefs.GetString("PlayerColor").Substring(12, 5);
        string b = PlayerPrefs.GetString("PlayerColor").Substring(19, 5);
        float rf = float.Parse(r, CultureInfo.InvariantCulture);
        float gf = float.Parse(g, CultureInfo.InvariantCulture);
        float bf = float.Parse(b, CultureInfo.InvariantCulture);
        sprite.color = new Color(rf, gf, bf);
    }

    void GetPlayerStyle()
    {
        Debug.Log(sprite.sprite.name.ToString());
        string s = PlayerPrefs.GetString("PlayerStyle");
        Debug.Log(s);
        Sprite sp = Resources.Load<Sprite>(s);
        sprite.sprite = sp;
        
    }

    
    void FixedUpdate()
    {
        rb2D.velocity = new Vector2(speed, rb2D.velocity.y) ;

        if (posX == rb2D.position.x && posY == rb2D.position.y)
            PlayerCollision.playerDead = true;

        posX = rb2D.position.x;
        posY = rb2D.position.y;
    }

    private void Update()
    {
        ChangeRbValues();

        if (type == 0 || type == 2)
        {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

            if (isGrounded)
            {
                rb2D.transform.rotation.Set(0.0f, 0.0f, 0.0f, 1.0f);

                if (PauseMenu.rotatePlayer)
                    animator.SetBool("isJumping", false);

                if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)) && PauseMenu.gameIsPaused == false )
                {
                    if (type == 0)
                        rb2D.velocity = Vector3.up * jumpForce;
                    if (type == 2)
                        rb2D.velocity = Vector3.down * jumpForce;
                }
            }
            if(!isGrounded && type!=1)
            {
                if(PauseMenu.rotatePlayer)
                    animator.SetBool("isJumping", true);
            }
            
        }

            
        if(type == 1)
        {
            if ((Input.GetMouseButton(0) || Input.GetButton("Jump")) && PauseMenu.gameIsPaused == false)
            {
                rb2D.gravityScale = -3;
            }
        }
    }

    void ChangeRbValues()
    {
        if (type == 0)
        {
            rb2D.mass = 5;
            rb2D.gravityScale = 5;
            rb2D.transform.localScale = new Vector3(1f, 1f);
        }

        if (type == 1)
        {
            rb2D.mass = 3;
            rb2D.gravityScale = 3;
            rb2D.transform.localScale = new Vector3(0.85f, 0.85f);
        }

        if (type == 2)
        {
            rb2D.mass = 5;
            rb2D.gravityScale = -5;
            rb2D.transform.localScale = new Vector3(1f, 1f);
        }
    }
}