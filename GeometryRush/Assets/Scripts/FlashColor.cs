using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashColor : MonoBehaviour
{
    public Background background;
    Image image = null;

    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        image.color = background.color[Background.index];
    }
}
