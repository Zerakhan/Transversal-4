using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pregunta : MonoBehaviour {
    Director dir;
    public int Preguntado = 0;
    public int purga = 1;
    public GameObject Prego;
    public GameObject Brego;
    public bool Vaya = true;

    void Update () {
        if (Preguntado == 1)
        {
            VayaToalla();
            Prego.SetActive(false);
            Brego.SetActive(true);

        }
        else if (Preguntado == 2)
        { 
            Brego.SetActive(false);
            FinOrden();
        }

    }
    public void Clicked()
    {
        Preguntado += purga;
    }
    public void VayaToalla()
    {
        dir.VayaToalla(this, Vaya);
    }
    public void FinOrden()
    {
        dir.FinOrdenes(this, Vaya);
    }
    public void Infografía()
    {
        Preguntado++;
    }
}
