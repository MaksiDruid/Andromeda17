using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public GameObject menu;
    public GameObject loadingScreen;

    void Awake()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        menu.gameObject.SetActive(false);
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        loadingScreen.SetActive(true);
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
