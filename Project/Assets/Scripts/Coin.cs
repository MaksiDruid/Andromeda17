using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private const int dangerLayer = 10;

    [SerializeField] private float spawnDistance;
    [SerializeField] private GameObject model;
    private Transform player;
    private bool inTrap;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        SpawnCoin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CheckCollision()
    {
        model.SetActive(!inTrap);
    }

    public void SpawnCoin()
    {
        model.SetActive(false);
        inTrap = false;
        transform.position = player.position + new Vector3(0, 0, spawnDistance);
        CheckCollision();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == dangerLayer)
        {
            inTrap = true;
        }
    }
}
