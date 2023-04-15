using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex005GetComponent : MonoBehaviour
{
    private BoxCollider boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        Console.WriteLine(boxCollider);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
