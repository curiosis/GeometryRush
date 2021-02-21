using UnityEngine;

public class BackgroundMelody : MonoBehaviour
{
    private AudioSource audioSource;
    public static bool stopMelody, startMelody, pauseMelody, resumeMelody;
    public static float time;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        stopMelody = false;
    }
    
    void Update()
    {
        Debug.Log(time);

        if (stopMelody)
            audioSource.Stop();
        time = audioSource.time;
        if (startMelody)
        {
            audioSource.Play();
            startMelody = false;
        }

        if (pauseMelody)
            Pause();

        if (resumeMelody)
            Resume();
    }

    void Pause()
    {
        audioSource.Pause();
        pauseMelody = false;
    }

    void Resume()
    {
        audioSource.Play();
        resumeMelody = false;
    }
}
