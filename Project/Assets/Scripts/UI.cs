using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject menu;
    public Button resumeButton;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ShowMenu(false);
        }
    }

    public void StartGame()
    {
        Time.timeScale = 1;
    }

    public void ShowMenu(bool isDead)
    {
        Time.timeScale = 0;
        menu.SetActive(true);
        resumeButton.interactable = !isDead;
    }

    public void Resume()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
}
