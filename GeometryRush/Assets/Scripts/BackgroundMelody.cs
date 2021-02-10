using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMelody : MonoBehaviour
{
    private AudioSource audioSource;
    private bool startMelody;
    public static bool stopMelody;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        stopMelody = false;
    }

    
    void Update()
    {
        Stop();
    }

    void Stop()
    {
        if (stopMelody)
            audioSource.Stop();
    }
}
