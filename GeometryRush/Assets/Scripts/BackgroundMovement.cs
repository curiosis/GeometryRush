using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    public Transform Player;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.transform.position = new Vector3(18 + Player.transform.position.x - Player.transform.position.x/32, transform.position.y);
    }
}
