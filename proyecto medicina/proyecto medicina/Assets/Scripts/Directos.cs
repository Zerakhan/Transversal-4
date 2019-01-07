using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Directos : MonoBehaviour {
    //Aqui van los temas de texto
    public InputField txtRef;
    public string typedText;
    //Aqui van los canvas
    public GameObject CanvasMotivos;
    public GameObject CanvasAlergias;
    public GameObject CanvasAlergias2;
    public GameObject CanvasAlergias3;
    public GameObject CanvasAlergias4;
    public GameObject CanvasAlergias5;
    public GameObject CanvasAlergias6;
    //aqui van las palabras clave
    public string motivos;
    public string alergias;
    public string alergias2;
    public string alergias3;
    public string alergias4;
    public string alergias5;
    public string alergias6;
    //aqui van los booleanos para que no pase 2 veces por el mismo sitio
    public bool X1 = true;
    public bool X2 = true;
    public bool X3 = true;
    public bool X4 = true;
    public bool X5 = true;
    public bool X6 = true;
    public bool X7 = true;

    public void Actual()
    {
        typedText = txtRef.text;
        //loop básico. Comprueba si es igual, si lo es, hace eso. Si no, al siguiente. Si ya ha pasado 1 vez, no deja pasar una segunda.
        if (typedText.Equals(motivos, StringComparison.InvariantCultureIgnoreCase) && X1 == true)
        {
            CanvasMotivos.SetActive(true);
            X1 = false;
            typedText = ("Motivos Hechos");
            
        }
        else if (typedText.Equals(alergias) && X2 == true)
        {
            CanvasAlergias.SetActive(true);
            X2 = false;
            typedText = ("Alergias Hechas");
        }
    }

    public void Cerrar()
    {
        //esto se asigna a un botón en el canvas para limpiar la info de la pantalla
        CanvasMotivos.SetActive(false);
    }
}
