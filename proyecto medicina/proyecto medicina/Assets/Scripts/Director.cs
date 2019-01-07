using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour {

    public GameObject Escribir;
    public GameObject Fin;
    public GameObject InputField;
    public int XXX = 0;
    public GameObject Canvastexto;
    public GameObject Canvasbotones;
    public GameObject Botonblock;
    public Camera Cam;
    public GameObject Prota;
    public GameObject TX;

    void Start()
    { //Estado inicial con el que activa
        Escribir.SetActive(false);
        Fin.SetActive(false);
        InputField.SetActive(false);
        Canvasbotones.SetActive(false);
        Canvastexto.SetActive(false);
        Botonblock.SetActive(false);
    }

    public void ActualizarPreguntado(int nuevoValor)
    {
        XXX = nuevoValor;

        if (XXX == 0)
        {
        }
        else if (XXX == 1)
        {
            Canvastexto.SetActive(true);
            Cam.GetComponent<moverCamara>().enabled = false;
            Cam.transform.LookAt(Prota.transform.position);
            Canvasbotones.SetActive(true);
            Botonblock.SetActive(true);
        }
        else if (XXX == 2)
        {
            Canvastexto.SetActive(false);
            Cam.GetComponent<moverCamara>().enabled = true;
            Canvasbotones.SetActive(false);
            Escribir.SetActive(true);
        }
        else if (XXX == 3)
        {
            Escribir.SetActive(false);
            TX.GetComponent<Texto>().Guardar();
            Fin.SetActive(true);
        }
    }

    public void Actual()
    {
        ActualizarPreguntado(XXX + 1);
    }
}