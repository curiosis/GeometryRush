using UnityEngine;
using UnityEngine.UI;

public class FlashColor : MonoBehaviour
{
    public Background background;
    Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        image.color = background.color[Background.index+1];
    }
}
