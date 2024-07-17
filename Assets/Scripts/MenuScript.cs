using System;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public int menuBarIndex = 0;
    public static Action<MenuScript> OnMenuClick;

    [SerializeField] GameObject _playImage;
    [SerializeField] GameObject _exitImage;
    [SerializeField] GameObject _playButton;
    [SerializeField] GameObject _exitButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.UpArrow)))
        {
            menuBarIndex = 0;
            Play();
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            menuBarIndex = 1;
            Exit();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            OnMenuClick?.Invoke(this);
        }
    }

    public void Play()
    {
        _playImage.SetActive(true);
        _exitImage.SetActive(false);
        _playButton.SetActive(true);
        _exitButton.SetActive(false);
    }

    public void Exit()
    {
        _playImage.SetActive(false);
        _exitImage.SetActive(true);
        _playButton.SetActive(false);
        _exitButton.SetActive(true);
    }
}
