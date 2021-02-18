using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public string Level1;
    public Canvas selectLevel, mainMenu, modeInfo, playerSett;
    public Button backToMainMenu;
    public Image player;

    private void Start()
    {
        string r = PlayerPrefs.GetString("PlayerColor").Substring(5, 5);
        string g = PlayerPrefs.GetString("PlayerColor").Substring(12, 5);
        string b = PlayerPrefs.GetString("PlayerColor").Substring(19, 5);
        player.color = new Color(float.Parse(r, CultureInfo.InvariantCulture.NumberFormat), float.Parse(g, CultureInfo.InvariantCulture.NumberFormat), float.Parse(b, CultureInfo.InvariantCulture.NumberFormat));
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

    public void StartGame()
    {
        SceneManager.LoadScene(Level1);
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
    }
}
