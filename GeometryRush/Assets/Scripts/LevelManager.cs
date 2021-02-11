using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static bool flashBool = false, flash, faster;
    public Transform player, finish;
    public static float distance;

    public CanvasGroup image;
    public Color color;

    float x = 1f;

    void Update()
    {
        if (faster)
            x = 0.5f;
        else
            x = 1;

        if (flashBool)
        {
            image.alpha -= Time.deltaTime;
            if(image.alpha <= 0)
            {
                image.alpha = 0;
                if(!faster)
                    Background.index += 1;
                flashBool = false;
                faster = false;
            }
        }

        if (flash)
        {
            flashBool = true;
            image.alpha = x;
            flash = false;
        }

        distance = (player.position.x / finish.position.x);
        //Debug.Log((distance*100).ToString("0")+"%");
        //Debug.Log(flashBool);
    }
}
