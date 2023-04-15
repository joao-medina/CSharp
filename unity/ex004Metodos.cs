using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex004Metodos : MonoBehaviour
{
    public int vidaInimigo = 100;
    public int forca = 10;

    int Atacar()
    {
        vidaInimigo = vidaInimigo - forca;
        return vidaInimigo;
    }

    void Start()
    {
        Debug.Log("O inimigo tem " + vidaInimigo + " de vida.");

        Atacar();

        Debug.Log("Você desferiu um golpe de " + forca + " de dano.");
        Debug.Log("O inimigo ficou com " + vidaInimigo + " de vida.");
        
    }
}
