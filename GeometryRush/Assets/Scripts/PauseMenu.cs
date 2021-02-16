using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false, rotatePlayer = true;

    public GameObject pauseMenuUI, progressBar, progressPercent, soundButton;
    public GameObject rotateMark, progressBarMark, progressPercentMark;

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
            rotateMark.SetActive(false);
            rotatePlayer = false;
        }
        else
        {
            rotateMark.SetActive(true);
            rotatePlayer = true;
        }
    }

    public void ProgressBar()
    {
        if (progressBar.activeSelf == true)
        {
            progressBarMark.SetActive(false);
            progressBar.SetActive(false);
        }
        else
        {
            progressBarMark.SetActive(true);
            progressBar.SetActive(true);
        }
    }

    public void ProgressPercent()
    {
        if (progressPercent.activeSelf == true)
        {
            progressPercentMark.SetActive(false);
            progressPercent.SetActive(false);
        }
        else
        {
            progressPercentMark.SetActive(true);
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
