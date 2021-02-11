using UnityEngine;
using Cinemachine;

public class LevelManager : MonoBehaviour
{
    public static bool flashBool = false, flash, faster;
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
            ShakeCamera(1.5f, 1.5f);
            image.alpha -= Time.deltaTime;
            if (image.alpha <= 0)
            {
                image.alpha = 0;

                if (!faster)
                    Background.index += 1;

                flashBool = false;
                faster = false;
            }
        }
        else
            ShakeCamera(0f, 0f);

        if (flash)
        {
            flashBool = true;
            image.alpha = x;
            flash = false;
        }

        distance = (player.position.x / finish.position.x);
        Debug.Log((distance * 100).ToString("0") + "%");
        Debug.Log(flashBool);
    }

    void ShakeCamera(float amplitude, float frequency)
    {
        noise.m_AmplitudeGain = amplitude;
        noise.m_FrequencyGain = frequency;
    }
}
