using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColor : MonoBehaviour
{
    Image image, playerImage;
    GameObject player;

    public void ChangeColor()
    {
        player = GameObject.FindGameObjectWithTag("PlayerPreview");
        image = GetComponent<Image>();
        playerImage = player.GetComponent<Image>();
        playerImage.color = image.color;
    }

    public void ChangeStyle()
    {
        player = GameObject.FindGameObjectWithTag("PlayerPreview");
        image = GetComponent<Image>();
        playerImage = player.GetComponent<Image>();
        playerImage.sprite = image.sprite;
    }
}