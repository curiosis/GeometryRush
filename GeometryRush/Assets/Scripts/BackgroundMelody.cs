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
}
