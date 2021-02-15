using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string Level1;

    public void StartGame()
    {
        SceneManager.LoadScene(Level1);
    }
}
