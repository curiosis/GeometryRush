using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BassFlashEffect : MonoBehaviour
{
    AudioSource audioSource;
    float[,] bassTime = new float[2,20];
    int index = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        AddBassTimeValue();
    }

    
    void Update()
    {
        ChangeCameraSize();
    }

    void ChangeCameraSize()
    {
        if (audioSource.time >= 5.5f && audioSource.time <= 5.55f)
        {
            LevelManager.faster = true;
            LevelManager.flash = true;
            
        }
    }

    void AddBassTimeValue()
    {
        bassTime[0, 0] = 24f;
    }
}
