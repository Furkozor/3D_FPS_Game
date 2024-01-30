using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool paused = false;
    public GameObject pauseMenuCanvas;

    private void Start()
    {
        Time.timeScale = 1f;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(paused)
                Continue();
            else
                Pause();
        }
    }

    public void Pause()
    {
        pauseMenuCanvas.SetActive(true); // Pause ekranýmýzý aktif ediyoruz.
        Time.timeScale = 0f; // Oyunun zaman akýþýný kapatýyoruz.
        paused = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void Continue()
    {
        pauseMenuCanvas.SetActive(false); // Pause ekranýmýzý deaktif ediyoruz.
        Time.timeScale = 1f; // Oyunun zaman akýþýný açýyoruz.
        paused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
