using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] public GameObject _pauseMenu;
    [SerializeField] public GameObject _pauseButton;
    [SerializeField] public GameObject _timeDisplay;
    [SerializeField] public GameObject _distanceDisplay;
    [SerializeField] public GameObject _pauseBanner;

    public int pauseMenuBarIndex = 0;
    public static Action<PauseMenu> OnPauseMenuClick;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _pauseMenu.SetActive(true);
            _pauseBanner.SetActive(false);
            Time.timeScale = 0.0f;
            _timeDisplay.SetActive(false);
            _distanceDisplay.SetActive(false);
        }
    }

    public void PauseGame()
    {
        _pauseMenu.SetActive(true);
        _pauseBanner.SetActive(false);
        Time.timeScale = 0.0f;
        _timeDisplay.SetActive(false);
        _distanceDisplay.SetActive(false);
    }

    public void ResumeGame()
    {
        _pauseMenu.SetActive(false);
        _pauseBanner.SetActive(true);
        Time.timeScale = 1.0f;
        _timeDisplay.SetActive(true);
        _distanceDisplay.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        _pauseMenu.SetActive(false);
        _pauseBanner.SetActive(true);
        Time.timeScale = 1.0f;
        _timeDisplay.SetActive(true);
        _distanceDisplay.SetActive(true);
    }

    public void MenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
