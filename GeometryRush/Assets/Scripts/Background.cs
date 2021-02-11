using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    SpriteRenderer sprite;
    public Color[] color;
    public static int index;

    void Start()
    {
        index = 0;
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelManager.flashBool && !LevelManager.faster)
        {
            sprite.color = color[index+1];
        }
            

    }
}
