using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex002Looping : MonoBehaviour
{
    int contador = 1;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 3; i++)
        {
            Debug.Log(i);
        }

        while(contador <= 3)
        {
            Debug.Log(contador);
            contador++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
