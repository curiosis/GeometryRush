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
    }

    
    void Update()
    {
        PlayMusic();
        StopMusic();
    }

    void PlayMusic()
    {
        if (LevelManager.startLevel)
            if (!startMelody)
            {
                audioSource.Play();
                startMelody = true;
            }
    }

    void StopMusic()
    {
        if(stopMelody)
            audioSource.Stop();
    }
}
