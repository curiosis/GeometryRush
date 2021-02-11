using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider progressBar;

    void Update()
    {
        progressBar.value = LevelManager.distance;
    }
}
