using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Directos : MonoBehaviour {

    public InputField txtRef;
    public string typedText;

    public GameObject Director;
    public GameObject CanvasMotivos;
    public GameObject CanvasAlergias;
    public GameObject CanvasAlergias2;
    public GameObject CanvasAlergias3;
    public GameObject CanvasAlergias4;
    public GameObject CanvasAlergias5;
    public GameObject CanvasAlergias6;
    public string motivos;
    public string alergias;
    public string alergias2;
    public string alergias3;
    public string alergias4;
    public string alergias5;
    public string alergias6;
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

        if (typedText.Equals(motivos) && X1 == true)
        {
            Director.SetActive(false);
            CanvasMotivos.SetActive(true);
            X1 = false;
            typedText = ("Motivos Hechos");
        }
        else if (typedText.Equals(alergias) && X2 == true)
        {
            Director.SetActive(false);
            CanvasAlergias.SetActive(true);
            X2 = false;
            typedText = ("Alergias Hechas");
        }
    }
}
