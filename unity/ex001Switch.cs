using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex001Switch : MonoBehaviour
{
    public int hp;


    // Start is called before the first frame update
    void Start()
    {
        switch (hp)
        {
            case 0:
                Debug.Log("Jogador morto");
                break;
            default:
                Debug.Log("jogador vivo");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
