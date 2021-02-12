using UnityEngine;

public class BassFlashEffect : MonoBehaviour
{
    AudioSource audioSource;
    readonly float[,] bassTime = new float[2,103];
    int index = 61;
    readonly float offset = 0.05f;

    public static bool debug;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        AddBassTimeValue();
    }

    
    void Update()
    {
        CheckFlashAvailable();
        if (debug)
        {
            Debug.Log(audioSource.time);
            debug = false;
        }
            
    }

    void CheckFlashAvailable()
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

        bassTime[0, 61] = 0.983f;
        bassTime[0, 62] = 1.486f;
        bassTime[0, 63] = 1.994f;
        bassTime[0, 64] = 2.662f;
        bassTime[0, 65] = 3.339f;
        bassTime[0, 66] = 4.015f;
        bassTime[0, 67] = 4.689f;
        bassTime[0, 68] = 5.351f;
        bassTime[0, 69] = 6.019f;
        bassTime[0, 70] = 6.695f;
        bassTime[0, 71] = 7.375f;
        bassTime[0, 72] = 8.043f;
        bassTime[0, 73] = 8.713f;
        bassTime[0, 74] = 9.546f;
        bassTime[0, 75] = 10.061f;
        bassTime[0, 76] = 11.149f;
        bassTime[0, 77] = 11.902f;
        bassTime[0, 78] = 12.743f;
        bassTime[0, 79] = 13.414f;
        bassTime[0, 80] = 14.091f;
        bassTime[0, 81] = 15.170f;
        bassTime[0, 82] = 15.850f;
        bassTime[0, 83] = 16.526f;
        bassTime[0, 84] = 17.444f;
        bassTime[0, 85] = 18.280f;
        bassTime[0, 86] = 18.956f;
        bassTime[0, 87] = 19.639f;
        bassTime[0, 88] = 20.298f;
        bassTime[0, 89] = 21.230f;
        bassTime[0, 90] = 21.645f;
        bassTime[0, 91] = 22.313f;
        bassTime[0, 92] = 22.995f;
        bassTime[0, 93] = 23.657f;
        bassTime[0, 94] = 24.334f;
        bassTime[0, 95] = 25.017f;
        bassTime[0, 96] = 25.675f;
        bassTime[0, 97] = 26.335f;
        bassTime[0, 98] = 27.017f;
        bassTime[0, 99] = 27.675f;
        bassTime[0, 100] = 28.373f;
        bassTime[0, 101] = 29.043f;
        bassTime[0, 102] = 29.882f;
    }
}
