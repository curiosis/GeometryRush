using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider progressBar;
    public Text progressValue;
    bool anim;
    int d;

    void Update()
    {

        progressBar.value = LevelManager.distance;
        d = (int)(LevelManager.distance * 100);
        progressValue.text = d.ToString("0") + "%";

        if (d>1 && d % 10 == 0 && !anim)
        {
            anim = true;
            progressValue.fontSize = 60;
            StartCoroutine(Anim());
        }
        if ((d > 5 && d % 10 == 5)||d==1)
            anim = false;
    }

    IEnumerator Anim()
    {
        yield return new WaitForSeconds(0.1f);
        for (int i = 0; i < 30; i++)
        {
            progressValue.fontSize -= 1;
            yield return new WaitForSeconds(0.13333f);
        }
    }
}
