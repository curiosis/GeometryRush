using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static bool startLevel = false;
    public Transform player, finish;
    public static float distance;

    void Update()
    {

        distance = (player.position.x / finish.position.x);

        Debug.Log((distance*100).ToString("0")+"%");

        if (Input.GetKeyUp(KeyCode.Space) && !startLevel)
        {
            startLevel = true;
        }
    }
}
