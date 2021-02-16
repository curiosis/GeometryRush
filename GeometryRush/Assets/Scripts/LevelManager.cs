using UnityEngine;
using Cinemachine;

public class LevelManager : MonoBehaviour
{
    public static bool flashBool = false, flash, faster, shakeCamera = true;
    public Transform player, finish;
    public static float distance;

    public CanvasGroup image;
    public Color color;

    float x = 1f;

    public CinemachineVirtualCamera cinemachineCamera;
    CinemachineBasicMultiChannelPerlin noise;

    private void Start()
    {
        noise = cinemachineCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }

    void Update()
    {
        if (faster)
            x = 0.5f;
        else
            x = 1;

        if (flashBool)
        {
            if(shakeCamera)
                ShakeCamera(1f, 1f);
            image.alpha -= Time.deltaTime;
            if (image.alpha <= 0)
            {
                image.alpha = 0;
                ShakeCamera(0f, 0f);
                flashBool = false;
                faster = false;
            }
        }

        if (flash)
        {
            flashBool = true;
            image.alpha = x;
            flash = false;
        }

        distance = (player.position.x / finish.position.x);
    }

    void ShakeCamera(float amplitude, float frequency)
    {
        noise.m_AmplitudeGain = amplitude;
        noise.m_FrequencyGain = frequency;
    }
}
