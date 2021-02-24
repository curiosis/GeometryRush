using UnityEngine;

public class BassFlashEffect : MonoBehaviour
{
    AudioSource audioSource;
    readonly float[,] bassTime = new float[3,104];
    int index = 0;
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
        if (audioSource.time >= bassTime[1, index] && audioSource.time <= bassTime[1, index] + offset)
        {
            LevelManager.faster = true;
            LevelManager.flash = true;
            index++;
        }
    }

    void AddBassTimeValue()
    {
        bassTime[0, 0] = 0.5f;
        bassTime[0, 1] = 25.505f;
        bassTime[0, 2] = 26.183f;
        bassTime[0, 3] = 26.878f;
        bassTime[0, 4] = 27.546f;
        bassTime[0, 5] = 28.220f;
        bassTime[0, 6] = 28.895f;
        bassTime[0, 7] = 29.566f;
        bassTime[0, 8] = 30.911f;
        bassTime[0, 9] = 31.585f;

        bassTime[0, 10] = 31.924f;
        bassTime[0, 11] = 32.921f;
        bassTime[0, 12] = 33.944f;
        bassTime[0, 13] = 34.947f;
        bassTime[0, 14] = 35.950f;
        bassTime[0, 15] = 36.953f;
        bassTime[0, 16] = 37.970f;
        bassTime[0, 17] = 38.963f;
        bassTime[0, 18] = 39.973f;
        bassTime[0, 19] = 40.990f;
        bassTime[0, 20] = 42f;
        bassTime[0, 21] = 43f;
        bassTime[0, 22] = 44f;
        bassTime[0, 23] = 45f;
        bassTime[0, 24] = 46f;
        bassTime[0, 25] = 47f;
        bassTime[0, 26] = 48.046f;
        bassTime[0, 27] = 49.056f;
        bassTime[0, 28] = 51.072f;

        bassTime[0, 29] = 51.750f;
        bassTime[0, 30] = 54.78f;
        bassTime[0, 31] = 55.430f;
        bassTime[0, 32] = 56.130f;
        bassTime[0, 33] = 56.444f;
        bassTime[0, 34] = 57.782f;
        bassTime[0, 35] = 58.789f;
        bassTime[0, 36] = 59.792f;
        bassTime[0, 37] = 60.809f;
        bassTime[0, 38] = 61.476f;
        bassTime[0, 39] = 61.819f;
        bassTime[0, 40] = 63.131f;
        bassTime[0, 41] = 63.461f;
        bassTime[0, 42] = 63.791f;
        bassTime[0, 43] = 64.121f;
        bassTime[0, 44] = 64.451f;
        bassTime[0, 45] = 64.781f;
        bassTime[0, 46] = 65.523f;
        bassTime[0, 47] = 66.187f;
        bassTime[0, 48] = 67.200f;
        bassTime[0, 49] = 67.532f;
        bassTime[0, 50] = 67.875f;
        bassTime[0, 51] = 69.908f;
        bassTime[0, 52] = 70.819f;
        bassTime[0, 53] = 71.921f;
        bassTime[0, 54] = 73.085f;
        bassTime[0, 55] = 73.931f;
        bassTime[0, 56] = 75.112f;
        bassTime[0, 57] = 76.420f;
        bassTime[0, 58] = 77.957f;
        bassTime[0, 59] = 79.114f;
        bassTime[0, 60] = 79.645f;
        bassTime[0, 61] = 79.984f;

        bassTime[0, 62] = 0.983f;
        bassTime[0, 63] = 1.486f;
        bassTime[0, 64] = 1.994f;
        bassTime[0, 65] = 2.662f;
        bassTime[0, 66] = 3.339f;
        bassTime[0, 67] = 4.015f;
        bassTime[0, 68] = 4.689f;
        bassTime[0, 69] = 5.351f;
        bassTime[0, 70] = 6.019f;
        bassTime[0, 71] = 6.695f;
        bassTime[0, 72] = 7.375f;
        bassTime[0, 73] = 8.043f;
        bassTime[0, 74] = 8.713f;
        bassTime[0, 75] = 9.546f;
        bassTime[0, 76] = 10.061f;
        bassTime[0, 77] = 11.149f;
        bassTime[0, 78] = 11.902f;
        bassTime[0, 79] = 12.743f;
        bassTime[0, 80] = 13.414f;
        bassTime[0, 81] = 14.091f;
        bassTime[0, 82] = 15.170f;
        bassTime[0, 83] = 15.850f;
        bassTime[0, 84] = 16.526f;
        bassTime[0, 85] = 17.444f;
        bassTime[0, 86] = 18.280f;
        bassTime[0, 87] = 18.956f;
        bassTime[0, 88] = 19.639f;
        bassTime[0, 89] = 20.298f;
        bassTime[0, 90] = 21.230f;
        bassTime[0, 91] = 21.645f;
        bassTime[0, 92] = 22.313f;
        bassTime[0, 93] = 22.995f;
        bassTime[0, 94] = 23.657f;
        bassTime[0, 95] = 24.334f;
        bassTime[0, 96] = 25.017f;
        bassTime[0, 97] = 25.675f;
        bassTime[0, 98] = 26.335f;
        bassTime[0, 99] = 27.017f;
        bassTime[0, 100] = 27.675f;
        bassTime[0, 101] = 28.373f;
        bassTime[0, 102] = 29.043f;
        bassTime[0, 103] = 29.882f;

        bassTime[1, 0] = 11.893f;
        bassTime[1, 1] = 12.623f;
        bassTime[1, 2] = 13.566f;
        bassTime[1, 3] = 14.140f;
        bassTime[1, 4] = 14.850f;
        bassTime[1, 5] = 15.608f;
        bassTime[1, 6] = 16.552f;
        bassTime[1, 7] = 17.096f;
        bassTime[1, 8] = 17.816f;
        bassTime[1, 9] = 18.564f;

        bassTime[1, 10] = 19.478f;
        bassTime[1, 11] = 20.042f;
        bassTime[1, 12] = 20.812f;
        bassTime[1, 13] = 21.540f;
        bassTime[1, 14] = 22.454f;
        bassTime[1, 15] = 23.012f;
        bassTime[1, 16] = 35.612f;
        bassTime[1, 17] = 36.351f;
        bassTime[1, 18] = 37.275f;
        bassTime[1, 19] = 37.809f;

        bassTime[1, 20] = 38.555f;
        bassTime[1, 21] = 39.297f;
        bassTime[1, 22] = 40.231f;
        bassTime[1, 23] = 40.795f;
        bassTime[1, 24] = 41.605f;
        bassTime[1, 25] = 42.283f;
        bassTime[1, 26] = 43.187f;
        bassTime[1, 27] = 43.771f;
        bassTime[1, 28] = 44.490f;
        bassTime[1, 29] = 45.249f;

        bassTime[1, 30] = 46.153f;
        bassTime[1, 31] = 46.717f;

        bassTime[2, 0] = 1.535f;
        bassTime[2, 1] = 2.011f;
        bassTime[2, 2] = 2.482f;
        bassTime[2, 3] = 2.949f;
        bassTime[2, 4] = 3.420f;
        bassTime[2, 5] = 3.987f;
        bassTime[2, 6] = 4.444f;
        bassTime[2, 7] = 4.821f;
        bassTime[2, 8] = 5.292f;
        bassTime[2, 9] = 6.231f;
    }
}
