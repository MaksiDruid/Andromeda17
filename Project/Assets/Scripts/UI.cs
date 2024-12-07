using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public static UI Instance;
    [SerializeField] private Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        StopTime();
        startButton.onClick.AddListener(StartTime);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale < 0.5)
            {
                StartTime();
            }
            else
            {
                StopTime();
            }
        }
    }

    public void StopTime()
    {
        startButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void StartTime()
    {
        Time.timeScale = 1;
        startButton.gameObject.SetActive(false);
    }
}
