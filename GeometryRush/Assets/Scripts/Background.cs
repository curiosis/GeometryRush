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

    void Update()
    {
        if (LevelManager.flashBool && !LevelManager.faster)
            sprite.color = color[index+1];
    }
}
