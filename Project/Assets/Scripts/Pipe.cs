using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public bool firstRoom;
    float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;

        if (transform.position.x < -5)
        {
            transform.position = new Vector3(15, 0, 0);
            if (firstRoom == true)
            {
                gameObject.SetActive(false);
            }
        }
    }

    void StartGame()
    {
        Time.timeScale = 1;
    }
}
