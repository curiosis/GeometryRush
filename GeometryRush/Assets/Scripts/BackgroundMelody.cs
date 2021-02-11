using UnityEngine;

public class BackgroundMelody : MonoBehaviour
{
    private AudioSource audioSource;
    public static bool stopMelody;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        stopMelody = false;
    }
    
    void Update()
    {
        if (stopMelody)
            audioSource.Stop();
    }
}
