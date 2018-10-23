using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour {

    public GameObject[] NPC;
    public int Preguntado = 0;
    public int purga = 1;
    public GameObject Prego;
    public GameObject Brego;
    public GameObject Trego;
    public GameObject Grego;
    public GameObject Frego;
    public GameObject Rrego;
    public bool Raro = false;
    public bool Rara = false;
    public bool Roro = false;
    public bool Rora = false;
    public int Zeras = 0;
    public static int zara = 1;
    public static int zare = 2;
    public static int zere = 3;
    public static int zera = 4;

    void Start()
    {
        NPC = GameObject.FindGameObjectsWithTag("Enemigo");
        Grego.SetActive(false);
        Prego.SetActive(false);
        Brego.SetActive(false);
        Trego.SetActive(false);
        Frego.SetActive(false);
    }

    void Update()
    {
        if (Preguntado == 0)
        {
            Frego.SetActive(true);
        }
        else if (Preguntado == 1)
        {
            Frego.SetActive(false);

            if (!Raro)
            {
            Prego.SetActive(true);
            }
            else
            {
            Prego.SetActive(false);
            }

            if (!Rora)
            {
            Brego.SetActive(true);
            }
            else
            {
            Brego.SetActive(false);
            }

            if (!Roro) {
            Grego.SetActive(true);
            }
            else
            {
            Grego.SetActive(false);
            }

            if (!Rara) {
            Trego.SetActive(true);
            }
            else
            {
            Trego.SetActive(false);
            }
        }
        else if (Preguntado == 2)
        {
            Prego.SetActive(false);
            Brego.SetActive(false);
            Grego.SetActive(false);
            Trego.SetActive(false);
            Rrego.SetActive(true);
        }
    }
    public void Clicked()
    {
        Preguntado += purga;
    }

    public void FinOrdenes(Pregunta pregunta, bool Vaya)
    {
        Raro = Vaya;
        Rara = false;
        Roro = false;
        Rora = false;
    }
    public void VayaToalla(Pregunta pregunta, bool Vaya)
    {
    Raro = Vaya;
    Rara = Vaya;
    Roro = Vaya;
    Rora = Vaya;
}

}