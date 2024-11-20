using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public List<GameObject> trapsHolder = new List<GameObject>();

    void Start()
    {
        
    }
    void Update()
    {
        rb.velocity = Vector3.right * speed;
        if (transform.position.x > 10)
        {
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
