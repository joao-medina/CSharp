using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex006Vectors : MonoBehaviour
{

    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(1f, 1f, 1f);

        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
