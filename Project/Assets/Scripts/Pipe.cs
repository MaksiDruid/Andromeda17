using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed;
    public List<GameObject> trapsHolder = new List<GameObject>();

    void Start()
    {
        RandomizeTraps();
    }

    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        if (transform.position.x > 10)
        {
            RandomizeTraps();
            transform.position = new Vector3(-20, 0, 0);
        }
    }

    void RandomizeTraps()
    {
        int randomNum = Random.Range(0, 3);
        
        foreach (GameObject trap in trapsHolder)
        {
            trap.SetActive(false);
        }
        trapsHolder[randomNum].SetActive(true);
    }
}
