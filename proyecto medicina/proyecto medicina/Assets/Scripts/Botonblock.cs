using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botonblock : MonoBehaviour {
    Director dir;
    public GameObject Director;
    public GameObject Boton;
    public GameObject Boton2;
    public GameObject InputField;
    public int XXX = 0;
    public GameObject Canvastexto;
    public GameObject Canvasbotones;
    
    void Start () { //Estado inicial con el que activa
        Director.SetActive(true);
        Boton.SetActive(false);
        Boton2.SetActive(false);
        InputField.SetActive(false);
        Canvasbotones.SetActive(false);
        Canvastexto.SetActive(false);
    }
	
	// Update is called once per frame
	
        private void ActualizarPreguntado (int nuevoValor)
    {
        XXX = nuevoValor;

        if (XXX == 0) 

        {
            Director.SetActive(true);
            
            {
                Canvasbotones.SetActive(true);
                Canvastexto.SetActive(true); 
                
            }
           
            Boton.SetActive(true);  //Boton entrada block
            Boton2.SetActive(false); //Boton salida block
            InputField.SetActive(false);
        }
        else if (XXX == 1)
        {
            Director.SetActive(false);
            Boton.SetActive(false);
            Boton2.SetActive(true);
            InputField.SetActive(true);
            Canvasbotones.SetActive(false);
            Canvastexto.SetActive(false);
        }
    } 


 

    public void Info()
    {
       ActualizarPreguntado(XXX + 1);
    }

    public void Onfo()
    {
        ActualizarPreguntado(XXX - 1);
    }


}
