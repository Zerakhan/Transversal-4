using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Texto : MonoBehaviour
{
	public InputField txtRef;
	public string typedText;
    public string [] Final;
    public GameObject Dir;

    public bool Y1;
    public bool Y2;
    public bool Y3;
    public bool Y4;
    public bool Y5;
    public bool Y6;
    public bool Y7;

    public void Guardar() 
	{
        Dir.GetComponent<Directos>().X1 = Y1;
        Dir.GetComponent<Directos>().X2 = Y2;
        Dir.GetComponent<Directos>().X3 = Y3;
        Dir.GetComponent<Directos>().X4 = Y4;
        Dir.GetComponent<Directos>().X5 = Y5;
        Dir.GetComponent<Directos>().X6 = Y6;
        Dir.GetComponent<Directos>().X7 = Y7;
        typedText = txtRef.text;
        Final = typedText.Split(new char[] { '.' });
        StreamWriter SW = new StreamWriter(Application.persistentDataPath + "HistoriaClínica.txt");
        SW.WriteLine(Final);
        if (!Y1)
        {
            SW.WriteLine("Motivos de consulta preguntados");
        }
        else
        {
            SW.WriteLine("Motivos de consulta no preguntados");
        }

        //Separación para que se entienda todo mejor. Lo de arriba es escritura. Lo de abajo, lectura.
        StreamReader SR = new StreamReader(Application.persistentDataPath + "HistoriaClínica.txt");
        {
            string Finil;
            while ((Finil = SR.ReadLine()) != null)
            {
                Debug.Log(Finil);
            }
        }
    }
}