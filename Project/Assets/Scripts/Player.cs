using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody body;
    AudioSource audio;
    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        body.velocity = new Vector3(0,vertical, -horizontal) * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "trap")
        {
            audio.Play();
            UI.Instance.ShowMenu(true);
        }
    }
}
