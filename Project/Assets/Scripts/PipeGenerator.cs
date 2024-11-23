using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public List<Transform> pipes = new List<Transform>();
    public List<Transform> positions = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        foreach (var pos in positions)
        {
            int randomNum = Random.Range(0, pipes.Count);
            while (pipes[randomNum].gameObject.activeSelf == true)
            {
                randomNum = Random.Range(0, pipes.Count);
            }
            pipes[randomNum].position = pos.position;
            pipes[randomNum].gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
