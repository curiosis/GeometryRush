using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public string Level1, Level2;
    public Canvas selectLevel, mainMenu, modeInfo, playerSett;
    public Button backToMainMenu;
    public Image player;
    public CanvasGroup image;

    private void Start()
    {
        string r = PlayerPrefs.GetString("PlayerColor").Substring(5, 5);
        string g = PlayerPrefs.GetString("PlayerColor").Substring(12, 5);
        string b = PlayerPrefs.GetString("PlayerColor").Substring(19, 5);
        player.color = new Color(float.Parse(r, CultureInfo.InvariantCulture.NumberFormat), float.Parse(g, CultureInfo.InvariantCulture.NumberFormat), float.Parse(b, CultureInfo.InvariantCulture.NumberFormat));
    }

    private void Update()
    {
        if (LevelManager.flashBool)
        {
            image.alpha -= Time.deltaTime;
            if (image.alpha <= 0)
            {
                image.alpha = 0;
                LevelManager.flashBool = false;
            }
        }

        if (LevelManager.flash)
        {
            LevelManager.flashBool = true;
            image.alpha = 1f;
            LevelManager.flash = false;
        }
    }

    public void SelectLevel()
    {
        StartCoroutine(Enumerator());
    }

    public void ModeInfo()
    {
        mainMenu.gameObject.SetActive(false);
        modeInfo.gameObject.SetActive(true);
        backToMainMenu.gameObject.SetActive(true);
    }

    public void PlayerSett()
    {
        mainMenu.gameObject.SetActive(false);
        playerSett.gameObject.SetActive(true);
        backToMainMenu.gameObject.SetActive(true);
    }

    public void BackToMenu()
    {
        mainMenu.gameObject.SetActive(true);
        selectLevel.gameObject.SetActive(false);
        modeInfo.gameObject.SetActive(false);
        playerSett.gameObject.SetActive(false);
        backToMainMenu.gameObject.SetActive(false);
    }

    public void StartLevel1()
    {
        SceneManager.LoadScene(Level1);
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene(Level2);
    }

    IEnumerator Enumerator()
    {
        yield return new WaitForSeconds(1.0f);
        mainMenu.gameObject.SetActive(false);
        selectLevel.gameObject.SetActive(true);
        backToMainMenu.gameObject.SetActive(true);
    }

    public void ChangeColor(Color color)
    {
        player.color = color;
    }

    public void SaveColor()
    {
        PlayerPrefs.SetString("PlayerColor", player.color.ToString());
        PlayerPrefs.SetString("PlayerStyle", player.sprite.ToString());
        Debug.Log(player.sprite.rect.ToString());
    }

    public void YoutubeOpen()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCAXsFZgv9CRHqEBTEEte47A");
    }

    public void LinkedInOpen()
    {
        Application.OpenURL("https://www.linkedin.com/in/remigiusz-drobinski/");
    }

    public void GitHubOpen()
    {
        Application.OpenURL("https://github.com/curiosis");
    }


}
