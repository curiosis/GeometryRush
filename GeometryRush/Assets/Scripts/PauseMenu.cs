using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false, rotatePlayer = true;

    public GameObject pauseMenuUI, progressBar, progressPercent, soundButton;
    public GameObject[] marks;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
                Resume();
            else
                Pause();
        }
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        BackgroundMelody.resumeMelody = true;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        BackgroundMelody.pauseMelody = true;
    }

    public void Rotate()
    {
        if (rotatePlayer)
        {
            marks[0].SetActive(false);
            rotatePlayer = false;
        }
        else
        {
            marks[0].SetActive(true);
            rotatePlayer = true;
        }
    }

    public void ProgressBar()
    {
        if (progressBar.activeSelf == true)
        {
            marks[1].SetActive(false);
            progressBar.SetActive(false);
        }
        else
        {
            marks[1].SetActive(true);
            progressBar.SetActive(true);
        }
    }

    public void ShakeCamera()
    {
        if (LevelManager.shakeCamera)
        {
            marks[3].SetActive(false);
            LevelManager.shakeCamera = false;
        }
        else
        {
            marks[3].SetActive(true);
            LevelManager.shakeCamera = true;
        }

    }

    public void ProgressPercent()
    {
        if (progressPercent.activeSelf == true)
        {
            marks[2].SetActive(false);
            progressPercent.SetActive(false);
        }
        else
        {
            marks[2].SetActive(true);
            progressPercent.SetActive(true);
        }
    }

    public void HomeButton()
    {
        Resume();
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartButton()
    {
        Resume();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
