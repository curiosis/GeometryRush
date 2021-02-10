using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    SpriteRenderer sprite;
    public Color color;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelManager.flashBool)
            sprite.color = color;

    }
}
