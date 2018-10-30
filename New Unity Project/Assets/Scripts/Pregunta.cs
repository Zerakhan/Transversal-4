using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pregunta : MonoBehaviour {

    public int Preguntado = 1;
    public GameObject Prego;
    public GameObject Brego;
    public GameObject Trego;

    void Update () {
        if (Preguntado == 1)
        {
            Brego.SetActive(false);
        }
        else if (Preguntado == 2)
        {
            Prego.SetActive(false);
            Brego.SetActive(true);
            Trego.SetActive(true);
        }

    }
    public void Clicked()
    {
        Preguntado = Preguntado + 1;
    }

    public void Infografía()
    {
        this.Preguntado = 1;
    }
}
