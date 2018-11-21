using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour {
    Pregunta pregunta;
    public int Preguntado = 0;
    public GameObject Prego;
    public GameObject Brego;
    public GameObject Trego;
    public GameObject Lego;
    public Camera Cam;
    public GameObject Prota;
    public GameObject Boton;
    public GameObject InputField;
    public GameObject Crego;

    void Start()
    {
        Crego.SetActive(false);
        Trego.SetActive(false);
        Prego.SetActive(false);
        Brego.SetActive(false);
        Lego.SetActive(false);
        Boton.SetActive(false);
        InputField.SetActive(false);
           }

    void Update()
    {
        if (Preguntado == 0)
        {
        }
        else if (Preguntado == 1)
        {
         Crego.SetActive(true);
         Cam.GetComponent<moverCamara>().enabled = false;
         Cam.transform.LookAt(Prota.transform.position);
         Brego.SetActive(true);
         Boton.SetActive(true);
        } 
        
        else if (Preguntado == 2)
        {
         Crego.SetActive(false);
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