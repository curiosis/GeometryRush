using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static bool flashBool = false, flash;
    public Transform player, finish;
    public static float distance;

    public CanvasGroup image;
    public Color color;

    void Update()
    {
        if (flashBool)
        {
            image.alpha -= Time.deltaTime;
            if(image.alpha <= 0)
            {
                image.alpha = 0;
                Background.index += 1;
                flashBool = false;
            }
        }

        if (flash)
        {
            flashBool = true;
            image.alpha = 1;
            flash = false;
        }

        distance = (player.position.x / finish.position.x);
        //Debug.Log((distance*100).ToString("0")+"%");
        //Debug.Log(flashBool);
    }
}
