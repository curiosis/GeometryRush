using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BassFlashEffect : MonoBehaviour
{
    AudioSource audioSource;
    readonly float[,] bassTime = new float[2,63];
    int index = 0;
    readonly float offset = 0.05f;

    public static bool debug;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        AddBassTimeValue();
    }

    
    void Update()
    {
        ChangeCameraSize();
        if (debug)
            Debug.Log(audioSource.time);
    }

    void ChangeCameraSize()
    {
        if (audioSource.time >= bassTime[0, index] && audioSource.time <= bassTime[0, index] + offset)
        {
            LevelManager.faster = true;
            LevelManager.flash = true;
            index++;
        }
    }

    void AddBassTimeValue()
    {
        bassTime[0, 0] = 25.505f;
        bassTime[0, 1] = 26.183f;
        bassTime[0, 2] = 26.878f;
        bassTime[0, 3] = 27.546f;
        bassTime[0, 4] = 28.220f;
        bassTime[0, 5] = 28.895f;
        bassTime[0, 6] = 29.566f;
        bassTime[0, 7] = 30.911f;
        bassTime[0, 8] = 31.585f;

        bassTime[0, 9] = 31.924f;
        bassTime[0, 10] = 32.921f;
        bassTime[0, 11] = 33.944f;
        bassTime[0, 12] = 34.947f;
        bassTime[0, 13] = 35.950f;
        bassTime[0, 14] = 36.953f;
        bassTime[0, 15] = 37.970f;
        bassTime[0, 16] = 38.963f;
        bassTime[0, 17] = 39.973f;
        bassTime[0, 18] = 40.990f;
        bassTime[0, 19] = 42f;
        bassTime[0, 20] = 43f;
        bassTime[0, 21] = 44f;
        bassTime[0, 22] = 45f;
        bassTime[0, 23] = 46f;
        bassTime[0, 24] = 47f;
        bassTime[0, 25] = 48.046f;
        bassTime[0, 26] = 49.056f;
        bassTime[0, 27] = 51.072f;

        bassTime[0, 28] = 51.750f;
        bassTime[0, 29] = 54.78f;
        bassTime[0, 30] = 55.430f;
        bassTime[0, 31] = 56.130f;
        bassTime[0, 32] = 56.444f;
        bassTime[0, 33] = 57.782f;
        bassTime[0, 34] = 58.789f;
        bassTime[0, 35] = 59.792f;
        bassTime[0, 36] = 60.809f;
        bassTime[0, 37] = 61.476f;
        bassTime[0, 38] = 61.819f;
        bassTime[0, 39] = 63.131f;
        bassTime[0, 40] = 63.461f;
        bassTime[0, 41] = 63.791f;
        bassTime[0, 42] = 64.121f;
        bassTime[0, 43] = 64.451f;
        bassTime[0, 44] = 64.781f;
        bassTime[0, 45] = 65.523f;
        bassTime[0, 46] = 66.187f;
        bassTime[0, 47] = 67.200f;
        bassTime[0, 48] = 67.532f;
        bassTime[0, 49] = 67.875f;
        bassTime[0, 50] = 69.908f;
        bassTime[0, 51] = 70.819f;
        bassTime[0, 52] = 71.921f;
        bassTime[0, 53] = 73.085f;
        bassTime[0, 54] = 73.931f;
        bassTime[0, 55] = 75.112f;
        bassTime[0, 56] = 76.420f;
        bassTime[0, 57] = 77.957f;
        bassTime[0, 58] = 79.114f;
        bassTime[0, 59] = 79.645f;
        bassTime[0, 60] = 79.984f;
    }
}
