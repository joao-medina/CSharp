using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex008TranslateRotation : MonoBehaviour
{

    public float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.left * Time.deltaTime * velocidade);
        transform.Rotate(0f, 0f, 0.5f, Space.Self);
    }
}
