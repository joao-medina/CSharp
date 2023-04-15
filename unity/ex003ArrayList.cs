using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex003ArrayList : MonoBehaviour
{

    public string[] inimigos = new string[] { "Orc", "Aranhas", "Troll" };
    public List<string> herois = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        herois.Add("Elfo");
        herois.Add("Anão");

        foreach(string elemento in inimigos)
        {
            Debug.Log(elemento);
        }

        for(int i = 0; i < herois.Count; i++)
        {
            Debug.Log(herois[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
