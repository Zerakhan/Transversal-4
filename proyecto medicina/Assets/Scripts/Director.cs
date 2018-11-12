using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour {
    Pregunta pregunta;
    public int Preguntado = 0;
    public GameObject Prego;
    public GameObject Brego;
    public GameObject Frego;
    public GameObject Trego;
    public GameObject Lego;
    public Camera Cam;
    public GameObject Prota;

    void Start()
    { 
        Trego.SetActive(false);
        Prego.SetActive(false);
        Brego.SetActive(false);
        Frego.SetActive(false);
        Lego.SetActive(false);
    }

    void Update()
    {
        if (Preguntado == 0)
        {
            Frego.SetActive(true);
        }
        else if (Preguntado == 1)
        {
         Cam.GetComponent<moverCamara>().enabled = false;
         Cam.transform.LookAt(Prota.transform.position);
         Frego.SetActive(false);
         Brego.SetActive(true);
        }
        else if (Preguntado == 2)
        {
            Cam.GetComponent<moverCamara>().enabled = true;
            Brego.SetActive(false);
            Prego.SetActive(true);
        }
        else if (Preguntado == 3)
        {
            Prego.SetActive(false);
            Trego.SetActive(true);
            Lego.SetActive(true);
        }
    }
    public void Clicked()
    {
        Preguntado = Preguntado + 1;
    }
    public void FinOrdenes()
    {
        this.Preguntado = 1;
    }
}