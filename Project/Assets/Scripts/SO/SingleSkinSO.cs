using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleSkinSO : ScriptableObject
{
    [SerializeField] string name;
    [SerializeField] GameObject visual;
    [SerializeField] float price;

    public string Name => name;
    public GameObject Visual => visual;
    public float Price => price;
}
