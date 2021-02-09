using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static bool startLevel;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            startLevel = true;
        }
    }
}
