using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public string Level1;
    public Canvas selectLevel, mainMenu;
    public Button backToMainMenu;

    public void SelectLevel()
    {
        mainMenu.gameObject.SetActive(false);
        selectLevel.gameObject.SetActive(true);
        backToMainMenu.gameObject.SetActive(true);
    }

    public void BackToMenu()
    {
        mainMenu.gameObject.SetActive(true);
        selectLevel.gameObject.SetActive(false);
        backToMainMenu.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(Level1);
    }
}
