using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool Paused = false;
    public GameObject PauseCanvas;
    public GameObject GameOverCanvas;


    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Paused)
            {
                Play();
            }
            else
            {
                Stop();
            }
        }
    }

    void Stop()
    {
        PauseCanvas.SetActive(true);
            Time.timeScale = 0f;
        Paused = true;
    }

    public void Play()
    {
        PauseCanvas.SetActive(false);
            Time.timeScale = 1f;
        Paused = false;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void NextLevelButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void gameOver()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }
}
