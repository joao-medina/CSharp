using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex007InstantiateDestroy : MonoBehaviour
{
    public GameObject cubo;


    // Start is called before the first frame update
    void Start()
    {                                      //variável   //position   //rotation
        GameObject copiaCubo = Instantiate(cubo, transform.position, transform.rotation); ; //Gerar
        Destroy(copiaCubo.gameObject, 2f); //Destruir
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
