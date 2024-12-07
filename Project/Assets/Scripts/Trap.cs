using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public List<GameObject> singleTraps;
    // Start is called before the first frame update
    void OnEnable()
    {
        foreach (var trap in singleTraps)
        {
            trap.gameObject.SetActive(false);
        }

        int randomNum = Random.Range(0, singleTraps.Count);
        singleTraps[randomNum].gameObject.SetActive(true);
    }
}
