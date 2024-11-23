using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public bool firstRoom;
    Rigidbody body;
    int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector3(-speed, 0, 0);

        if (transform.position.x < -5)
        {
            transform.position = new Vector3(20, 0, 0);
            if (firstRoom == true)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
