using UnityEngine;

public class BackgroundMelody : MonoBehaviour
{
    private AudioSource audioSource;
    public static bool stopMelody, startMelody;
    public static float time;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        stopMelody = false;
    }
    
    void Update()
    {
        if (stopMelody)
            audioSource.Stop();
        time = audioSource.time;
        if (startMelody)
        {
            audioSource.Play();
            startMelody = false;
        }
            
    }
}
