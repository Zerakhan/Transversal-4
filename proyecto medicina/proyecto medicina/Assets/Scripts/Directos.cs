using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Directos : MonoBehaviour
{
    //Aqui van los temas de texto
    public InputField txtRef;
    public string typedText;
    //botones
    public GameObject Bot1;
    public GameObject Bot2;
    //Aqui van los canvas
    public GameObject CanvasMotivos;
    public GameObject CanvasAlergias;
    public GameObject CanvasSaludo;
    public GameObject CanvasNombre;
    public GameObject CanvasEdad;
    public GameObject CanvasAlimentos;
    public GameObject CanvasFamiliares;
    public GameObject CanvasCáncer;
    public GameObject CanvasMadre;
    public GameObject CanvasPadre;
    public GameObject CanvasInfartos;
    public GameObject CanvasHermanos;
    public GameObject CanvasDiabetes;
    public GameObject CanvasFumar;
    public GameObject CanvasBeber;
    public GameObject CanvasSustancias;
    public GameObject CanvasPrimeraRegla;
    public GameObject CanvasCiclos;
    public GameObject CanvasRegular;
    public GameObject CanvasDuración;
    public GameObject CanvasEmbarazos;
    public GameObject CanvasAborto;
    public GameObject CanvasCesárea;
    public GameObject CanvasPartos;
    public GameObject CanvasAnticonceptivos;
    public GameObject CanvasDieta;
    public GameObject CanvasEjercicio;
    public GameObject CanvasFamilia;
    public GameObject CanvasHijos;
    public GameObject CanvasTrabajar;
    public GameObject CanvasRelaciónFamiliar;
    public GameObject CanvasAmbienteTrabajo;
    public GameObject CanvasFechaÚltimaRegla;
    public GameObject CanvasProblemasEmbarazo;
    public GameObject CanvasEmpezó;
    public GameObject CanvasEmpeora;
    public GameObject CanvasEsfuerzo;
    public GameObject CanvasCansada;
    public GameObject CanvasTranscursoDia;
    public GameObject CanvasMejora;
    public GameObject CanvasPeso;
    public GameObject CanvasComeMenos;
    public GameObject CanvasCuántoPeso;
    public GameObject CanvasAtribuye;
    public GameObject CanvasViaje;
    public GameObject CanvasPreocupación;
    public GameObject CanvasOperaciones;
    public GameObject CanvasAzucar;
    public GameObject CanvasDiagnósticoDiabetes;
    public GameObject CanvasTratamientoEmbarazo;
    public GameObject CanvasHiperTensiónTratamiento;
    public GameObject CanvasHiperTensiónDiagnóstico;
    public GameObject CanvasColesterol;
    public GameObject CanvasColesterolDiagnóstico;
    public GameObject CanvasTerminarConsulta;
    public GameObject CanvasRecomendarReposo;
    public GameObject CanvasCalmar;
    public GameObject CanvasDespedida;











    //aqui van las palabras clave

    //Saludo
    public string Saludo1;
    public string Saludo2;
    public string Saludo3;
    public string Saludo4;
    public string Saludo5;
    public string Saludo6;

    //Nombre
    public string Nombre1;
    public string Nombre2;
    public string Nombre3;
    public string Nombre4;
    public string Nombre5;
    public string Nombre6;
    public string Nombre7;
    public string Nombre8;
    public string Nombre9;

    //Edad
    public string Edad1;
    public string Edad2;
    public string Edad3;
    public string Edad4;
    public string Edad5;
    public string Edad6;
    public string Edad7;
    public string Edad8;
    public string Edad9;

    //Motivo

    public string motivos1;
    public string motivos2;
    public string motivos3;
    public string motivos4;
    public string motivos5;
    public string motivos6;
    public string motivos7;

    //Alergias
    public string alergias1;
    public string alergias2;
    public string alergias3;
    public string alergias4;
    public string alergias5;
    public string alergias6;
    public string alergias7;
    public string alergias8;
    public string alergias9;
    public string alergias10;

    //Alimentos
    public string alimentos1;
    public string alimentos2;
    public string alimentos3;
    public string alimentos4;
    public string alimentos5;
    public string alimentos6;

    //Familiares
    public string familiares1;
    public string familiares2;
    public string familiares3;
    public string familiares4;
    public string familiares5;

    //Cáncer
    public string Cáncer1;
    public string Cáncer2;
    public string Cáncer3;
    public string Cáncer4;
    public string Cáncer5;
    public string Cáncer6;

    //Madre
    public string Madre1;
    public string Madre2;
    public string Madre3;
    public string Madre4;
    public string Madre5;
    public string Madre6;

    //Padre
    public string Padre1;
    public string Padre2;
    public string Padre3;
    public string Padre4;
    public string Padre5;
    public string Padre6;

    //Infartos
    public string infartos1;
    public string infartos2;
    public string infartos3;
    public string infartos4;
    public string infartos5;

    //Hermanos
    public string hermanos1;
    public string hermanos2;
    public string hermanos3;
    public string hermanos4;
    public string hermanos5;
    public string hermanos6;

    //Diabetes
    public string diabetes1;
    public string diabetes2;
    public string diabetes3;
    public string diabetes4;

    //fumar
    public string fumar1;
    public string fumar2;
    public string fumar3;
    public string fumar4;
    public string fumar5;

    //Beber
    public string beber1;
    public string beber2;

    //Sustancias
    public string sustancias1;
    public string sustancias2;

    //PrimeraRegla
    public string PrimeraRegla1;
    public string PrimeraRegla2;

    //Ciclos
    public string Ciclos1;
    public string Ciclos2;
    public string Ciclos3;

    //Regular
    public string Regular1;

    //Duración
    public string Duración1;

    //Embarazos

    public string Embarazos1;
    public string Embarazos2;

    //Aborto
    public string Aborto1;

    //Cesárea
    public string Cesárea1;

    //Partos
    public string Partos1;

    //Anticonceptivo
    public string Anticonceptivo1;

    //Dieta
    public string Dieta1;

    //Ejercicio
    public string Ejercicio1;

    //Familia
    public string Familia1;

    //Hijos
    public string Hijos1;

    //Trabajar
    public string Trabajar1;

    //Relación Familiar

    public string RelaciónFamiliar1;
    public string RelaciónFamiliar2;
    //AmbienteTrabajo 

    public string AmbienteTrabajo1;

    //FechaÚltimaRegla
    public string FechaÚltiaRegla1;

    //ProblemasEmbarazo
    public string ProblemasEmbarazo1;

    //Empezó
    public string Empezó1;

    //Empeora
    public string Empeora1;
    public string Empeora2;

    //Esfuerzo
    public string Esfuerzo1;

    //Cansada
    public string Cansada1;
    public string Cansada2;

    //TranscursoDía
    public string TranscursoDía1;

    //Mejora
    public string Mejora1;

    //Peso
    public string Peso1;

    //ComeMenos
    public string ComeMenos1;

    //CuantoPeso
    public string CuantoPeso1;

    //Atribuye
    public string Atribuye1;

    //Viaje
    public string Viaje1;

    //Preocupación

    public string Preocupación1;
    public string Preocupación2;

    //Operaciones

    public string Operaciones1;
    public string Operaciones2;

    //Azucar

    public string Azucar1;

    //DiagnósticoDiabetes

    public string DiagnósticoDiabetes1;
    public string DiagnósticoDiabetes2;
    public string DiagnósticoDiabetes3;

    //TratamientoEmbarazo

    public string TratamientoEmbarazo1;
    public string TratamientoEmbarazo2;

    //HipertensiónTratamiento

    public string HipertensiónTratamiento1;

    //HipertensiónDiagnóstico
    public string HipertensiónDiagnostico1;

    // Colesterol
    public string Colesterol1;

    //ColesterolDiagnóstico
    public string ColesterolDiagnóstico1;
    public string ColesterolDiagnóstico2;

    //TerminarConsulta
    public string TerminarConsulta1;

    //RecomendarReposo

    public string RecomendarReposo1;

    //Calmar
    public string Calmar1;

    //Despedida
    public string Despedida1;
    public string Despedida2;
    public string Despedida3;















    //aqui van los booleanos para que no pase 2 veces por el mismo sitio, uno por canvas
    public bool X1 = true;
    public bool X2 = true;
    public bool X3 = true;
    public bool X4 = true;
    public bool X5 = true;
    public bool X6 = true;
    public bool X7 = true;
    public bool X8 = true;
    public bool X9 = true;
    public bool X10 = true;
    public bool X11 = true;
    public bool X12 = true;
    public bool X13 = true;
    public bool X14 = true;
    public bool X15 = true;
    public bool X16 = true;
    public bool X17 = true;
    public bool X18 = true;
    public bool X19 = true;
    public bool X20 = true;
    public bool X21 = true;
    public bool X22 = true;
    public bool X23 = true;
    public bool X24 = true;
    public bool X25 = true;
    public bool X26 = true;
    public bool X27 = true;
    public bool X28 = true;
    public bool X29 = true;
    public bool X30 = true;
    public bool X31 = true;
    public bool X32 = true;
    public bool X33 = true;
    public bool X34 = true;
    public bool X35 = true;
    public bool X36 = true;
    public bool X37 = true;
    public bool X38 = true;
    public bool X39 = true;
    public bool X40 = true;
    public bool X41 = true;
    public bool X42 = true;
    public bool X43 = true;
    public bool X44 = true;
    public bool X45 = true;
    public bool X46 = true;
    public bool X47 = true;
    public bool X48 = true;
    public bool X49 = true;
    public bool X50 = true;
    public bool X51 = true;
    public bool X52 = true;
    public bool X53 = true;
    public bool X54 = true;
    public bool X55 = true;
    public bool X56 = true;
    public bool X57 = true;
    public bool X58 = true;
    public bool X59 = true;

    private void Start()
    {
        Bot1.SetActive(false);
        Bot2.SetActive(true);
    }

    public void Actual()
        //Motivos
    {
        typedText = txtRef.text;
        //loop básico. Comprueba si es igual, si lo es, hace eso. Si no, al siguiente. Si ya ha pasado 1 vez, no deja pasar una segunda.
        if (typedText.Equals(motivos1, StringComparison.InvariantCultureIgnoreCase) && X1 == true)
        {
            Bot2.SetActive(false);
            CanvasMotivos.SetActive(true);
            X1 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(motivos2, StringComparison.InvariantCultureIgnoreCase) && X1 == true)
        {
            Bot2.SetActive(false);
            CanvasMotivos.SetActive(true);
            X1 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(motivos3, StringComparison.InvariantCultureIgnoreCase) && X1 == true)
        {
            Bot2.SetActive(false);
            CanvasMotivos.SetActive(true);
            X1 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(motivos4, StringComparison.InvariantCultureIgnoreCase) && X1 == true)
        {
            Bot2.SetActive(false);
            CanvasMotivos.SetActive(true);
            X1 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(motivos5, StringComparison.InvariantCultureIgnoreCase) && X1 == true)
        {
            Bot2.SetActive(false);
            CanvasMotivos.SetActive(true);
            X1 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(motivos6, StringComparison.InvariantCultureIgnoreCase) && X1 == true)
        {
            Bot2.SetActive(false);
            CanvasMotivos.SetActive(true);
            X1 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(motivos7, StringComparison.InvariantCultureIgnoreCase) && X1 == true)
        {
            Bot2.SetActive(false);
            CanvasMotivos.SetActive(true);
            X1 = false;
            Bot1.SetActive(true);
        }


        //Saludo
        if (typedText.Equals(Saludo1, StringComparison.InvariantCultureIgnoreCase) && X3 == true)
        {
            Bot2.SetActive(false);
            CanvasSaludo.SetActive(true);
            X3 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Saludo2, StringComparison.InvariantCultureIgnoreCase) && X3 == true)
        {
            Bot2.SetActive(false);
            CanvasSaludo.SetActive(true);
            X3 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Saludo3, StringComparison.InvariantCultureIgnoreCase) && X3 == true)
        {
            Bot2.SetActive(false);
            CanvasSaludo.SetActive(true);
            X3 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Saludo4, StringComparison.InvariantCultureIgnoreCase) && X3 == true)
        {
            Bot2.SetActive(false);
            CanvasSaludo.SetActive(true);
            X3 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Saludo5, StringComparison.InvariantCultureIgnoreCase) && X3 == true)
        {
            Bot2.SetActive(false);
            CanvasSaludo.SetActive(true);
            X3 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Saludo6, StringComparison.InvariantCultureIgnoreCase) && X3 == true)
        {
            Bot2.SetActive(false);
            CanvasSaludo.SetActive(true);
            X3 = false;
            Bot1.SetActive(true);
        }
        //Nombre
        if (typedText.Equals(Nombre1, StringComparison.InvariantCultureIgnoreCase) && X4 == true)
        {
            Bot2.SetActive(false);
            CanvasNombre.SetActive(true);
            X4 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Nombre2, StringComparison.InvariantCultureIgnoreCase) && X4 == true)
        {
            Bot2.SetActive(false);
            CanvasNombre.SetActive(true);
            X4 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Nombre3, StringComparison.InvariantCultureIgnoreCase) && X4 == true)
        {
            Bot2.SetActive(false);
            CanvasNombre.SetActive(true);
            X4 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Nombre4, StringComparison.InvariantCultureIgnoreCase) && X4 == true)
        {
            Bot2.SetActive(false);
            CanvasNombre.SetActive(true);
            X4 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Nombre5, StringComparison.InvariantCultureIgnoreCase) && X4 == true)
        {
            Bot2.SetActive(false);
            CanvasNombre.SetActive(true);
            X4 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Nombre6, StringComparison.InvariantCultureIgnoreCase) && X4 == true)
        {
            Bot2.SetActive(false);
            CanvasNombre.SetActive(true);
            X4 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Nombre7, StringComparison.InvariantCultureIgnoreCase) && X4 == true)
        {
            Bot2.SetActive(false);
            CanvasNombre.SetActive(true);
            X4 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Nombre8, StringComparison.InvariantCultureIgnoreCase) && X4 == true)
        {
            Bot2.SetActive(false);
            CanvasNombre.SetActive(true);
            X4 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Nombre9, StringComparison.InvariantCultureIgnoreCase) && X4 == true)
        {
            Bot2.SetActive(false);
            CanvasNombre.SetActive(true);
            X4 = false;
            Bot1.SetActive(true);
        }

        //Edad
        if (typedText.Equals(Edad1, StringComparison.InvariantCultureIgnoreCase) && X5 == true)
        {
            Bot2.SetActive(false);
            CanvasEdad.SetActive(true);
            X5 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Edad2, StringComparison.InvariantCultureIgnoreCase) && X5 == true)
        {
            Bot2.SetActive(false);
            CanvasEdad.SetActive(true);
            X5 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Edad3, StringComparison.InvariantCultureIgnoreCase) && X5 == true)
        {
            Bot2.SetActive(false);
            CanvasEdad.SetActive(true);
            X5 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Edad4, StringComparison.InvariantCultureIgnoreCase) && X5 == true)
        {
            Bot2.SetActive(false);
            CanvasEdad.SetActive(true);
            X5 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Edad5, StringComparison.InvariantCultureIgnoreCase) && X5 == true)
        {
            Bot2.SetActive(false);
            CanvasEdad.SetActive(true);
            X5 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Edad6, StringComparison.InvariantCultureIgnoreCase) && X5 == true)
        {
            Bot2.SetActive(false);
            CanvasEdad.SetActive(true);
            X5 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Edad7, StringComparison.InvariantCultureIgnoreCase) && X5 == true)
        {
            Bot2.SetActive(false);
            CanvasEdad.SetActive(true);
            X5 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Edad8, StringComparison.InvariantCultureIgnoreCase) && X5 == true)
        {
            Bot2.SetActive(false);
            CanvasEdad.SetActive(true);
            X5 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Edad9, StringComparison.InvariantCultureIgnoreCase) && X5 == true)
        {
            Bot2.SetActive(false);
            CanvasEdad.SetActive(true);
            X5 = false;
            Bot1.SetActive(true);
        }

        //Alergias
        if (typedText.Equals(alergias1, StringComparison.InvariantCultureIgnoreCase) && X6 == true)
        {
            Bot2.SetActive(false);
            CanvasAlergias.SetActive(true);
            X6 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(alergias2, StringComparison.InvariantCultureIgnoreCase) && X6 == true)
        {
            Bot2.SetActive(false);
            CanvasAlergias.SetActive(true);
            X6 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(alergias3, StringComparison.InvariantCultureIgnoreCase) && X6 == true)
        {
            Bot2.SetActive(false);
            CanvasAlergias.SetActive(true);
            X6 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(alergias4, StringComparison.InvariantCultureIgnoreCase) && X6 == true)
        {
            Bot2.SetActive(false);
            CanvasAlergias.SetActive(true);
            X6 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(alergias5, StringComparison.InvariantCultureIgnoreCase) && X6 == true)
        {
            Bot2.SetActive(false);
            CanvasAlergias.SetActive(true);
            X6 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(alergias6, StringComparison.InvariantCultureIgnoreCase) && X6 == true)
        {
            Bot2.SetActive(false);
            CanvasAlergias.SetActive(true);
            X6 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(alergias7, StringComparison.InvariantCultureIgnoreCase) && X6 == true)
        {
            Bot2.SetActive(false);
            CanvasAlergias.SetActive(true);
            X6 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(alergias8, StringComparison.InvariantCultureIgnoreCase) && X6 == true)
        {
            Bot2.SetActive(false);
            CanvasAlergias.SetActive(true);
            X6 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(alergias9, StringComparison.InvariantCultureIgnoreCase) && X6 == true)
        {
            Bot2.SetActive(false);
            CanvasAlergias.SetActive(true);
            X6 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(alergias10, StringComparison.InvariantCultureIgnoreCase) && X6 == true)
        {
            Bot2.SetActive(false);
            CanvasAlergias.SetActive(true);
            X6 = false;
            Bot1.SetActive(true);
        }
        //Alimentos
        if (typedText.Equals(alimentos1, StringComparison.InvariantCultureIgnoreCase) && X7 == true)
        {
            Bot2.SetActive(false);
            CanvasAlimentos.SetActive(true);
            X7 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(alimentos2, StringComparison.InvariantCultureIgnoreCase) && X7 == true)
        {
            Bot2.SetActive(false);
            CanvasAlimentos.SetActive(true);
            X7 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(alimentos3, StringComparison.InvariantCultureIgnoreCase) && X7 == true)
        {
            Bot2.SetActive(false);
            CanvasAlimentos.SetActive(true);
            X7 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(alimentos4, StringComparison.InvariantCultureIgnoreCase) && X7 == true)
        {
            Bot2.SetActive(false);
            CanvasAlimentos.SetActive(true);
            X7 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(alimentos5, StringComparison.InvariantCultureIgnoreCase) && X7 == true)
        {
            Bot2.SetActive(false);
            CanvasAlimentos.SetActive(true);
            X7 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(alimentos6, StringComparison.InvariantCultureIgnoreCase) && X7 == true)
        {
            Bot2.SetActive(false);
            CanvasAlimentos.SetActive(true);
            X7 = false;
            Bot1.SetActive(true);
        }

        //Familiares
        if (typedText.Equals(familiares1, StringComparison.InvariantCultureIgnoreCase) && X8 == true)
        {
            Bot2.SetActive(false);
            CanvasFamiliares.SetActive(true);
            X8 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(familiares2, StringComparison.InvariantCultureIgnoreCase) && X8 == true)
        {
            Bot2.SetActive(false);
            CanvasFamiliares.SetActive(true);
            X8 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(familiares3, StringComparison.InvariantCultureIgnoreCase) && X8 == true)
        {
            Bot2.SetActive(false);
            CanvasFamiliares.SetActive(true);
            X8 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(familiares4, StringComparison.InvariantCultureIgnoreCase) && X8 == true)
        {
            Bot2.SetActive(false);
            CanvasFamiliares.SetActive(true);
            X8 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(familiares5, StringComparison.InvariantCultureIgnoreCase) && X8 == true)
        {
            Bot2.SetActive(false);
            CanvasFamiliares.SetActive(true);
            X8 = false;
            Bot1.SetActive(true);
        }
        //Cáncer
        if (typedText.Equals(Cáncer1, StringComparison.InvariantCultureIgnoreCase) && X9 == true)
        {
            Bot2.SetActive(false);
            CanvasCáncer.SetActive(true);
            X9 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Cáncer2, StringComparison.InvariantCultureIgnoreCase) && X9 == true)
        {
            Bot2.SetActive(false);
            CanvasCáncer.SetActive(true);
            X9 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Cáncer3, StringComparison.InvariantCultureIgnoreCase) && X9 == true)
        {
            Bot2.SetActive(false);
            CanvasCáncer.SetActive(true);
            X9 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Cáncer4, StringComparison.InvariantCultureIgnoreCase) && X9 == true)
        {
            Bot2.SetActive(false);
            CanvasCáncer.SetActive(true);
            X9 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Cáncer5, StringComparison.InvariantCultureIgnoreCase) && X9 == true)
        {
            Bot2.SetActive(false);
            CanvasCáncer.SetActive(true);
            X9 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Cáncer6, StringComparison.InvariantCultureIgnoreCase) && X9 == true)
        {
            Bot2.SetActive(false);
            CanvasCáncer.SetActive(true);
            X9 = false;
            Bot1.SetActive(true);
        }

        //Madre
        if (typedText.Equals(Madre1, StringComparison.InvariantCultureIgnoreCase) && X10 == true)
        {
            Bot2.SetActive(false);
            CanvasMadre.SetActive(true);
            X10 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Madre2, StringComparison.InvariantCultureIgnoreCase) && X10 == true)
        {
            Bot2.SetActive(false);
            CanvasMadre.SetActive(true);
            X10 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Madre3, StringComparison.InvariantCultureIgnoreCase) && X10 == true)
        {
            Bot2.SetActive(false);
            CanvasMadre.SetActive(true);
            X10 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Madre4, StringComparison.InvariantCultureIgnoreCase) && X10 == true)
        {
            Bot2.SetActive(false);
            CanvasMadre.SetActive(true);
            X10 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Madre5, StringComparison.InvariantCultureIgnoreCase) && X10 == true)
        {
            Bot2.SetActive(false);
            CanvasMadre.SetActive(true);
            X10 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Madre6, StringComparison.InvariantCultureIgnoreCase) && X10 == true)
        {
            Bot2.SetActive(false);
            CanvasMadre.SetActive(true);
            X10 = false;
            Bot1.SetActive(true);
        }
        //Padre
        if (typedText.Equals(Padre1, StringComparison.InvariantCultureIgnoreCase) && X11 == true)
        {
            Bot2.SetActive(false);
            CanvasPadre.SetActive(true);
            X11 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Padre2, StringComparison.InvariantCultureIgnoreCase) && X11 == true)
        {
            Bot2.SetActive(false);
            CanvasPadre.SetActive(true);
            X11 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Padre3, StringComparison.InvariantCultureIgnoreCase) && X11 == true)
        {
            Bot2.SetActive(false);
            CanvasPadre.SetActive(true);
            X11 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Padre4, StringComparison.InvariantCultureIgnoreCase) && X11 == true)
        {
            Bot2.SetActive(false);
            CanvasPadre.SetActive(true);
            X11 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Padre5, StringComparison.InvariantCultureIgnoreCase) && X11 == true)
        {
            Bot2.SetActive(false);
            CanvasPadre.SetActive(true);
            X11 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Padre6, StringComparison.InvariantCultureIgnoreCase) && X11 == true)
        {
            Bot2.SetActive(false);
            CanvasPadre.SetActive(true);
            X11 = false;
            Bot1.SetActive(true);
        }

        //Infartos
        if (typedText.Equals(infartos1, StringComparison.InvariantCultureIgnoreCase) && X12 == true)
        {
            Bot2.SetActive(false);
            CanvasInfartos.SetActive(true);
            X12 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(infartos2, StringComparison.InvariantCultureIgnoreCase) && X12 == true)
        {
            Bot2.SetActive(false);
            CanvasInfartos.SetActive(true);
            X12 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(infartos3, StringComparison.InvariantCultureIgnoreCase) && X12 == true)
        {
            Bot2.SetActive(false);
            CanvasInfartos.SetActive(true);
            X12 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(infartos4, StringComparison.InvariantCultureIgnoreCase) && X12 == true)
        {
            Bot2.SetActive(false);
            CanvasInfartos.SetActive(true);
            X12 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(infartos5, StringComparison.InvariantCultureIgnoreCase) && X12 == true)
        {
            Bot2.SetActive(false);
            CanvasInfartos.SetActive(true);
            X12 = false;
            Bot1.SetActive(true);
        }

        //Hermanos
        if (typedText.Equals(hermanos1, StringComparison.InvariantCultureIgnoreCase) && X13 == true)
        {
            Bot2.SetActive(false);
            CanvasHermanos.SetActive(true);
            X13 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(hermanos2, StringComparison.InvariantCultureIgnoreCase) && X13 == true)
        {
            Bot2.SetActive(false);
            CanvasHermanos.SetActive(true);
            X13 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(hermanos3, StringComparison.InvariantCultureIgnoreCase) && X13 == true)
        {
            Bot2.SetActive(false);
            CanvasHermanos.SetActive(true);
            X13 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(hermanos4, StringComparison.InvariantCultureIgnoreCase) && X13 == true)
        {
            Bot2.SetActive(false);
            CanvasHermanos.SetActive(true);
            X13 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(hermanos5, StringComparison.InvariantCultureIgnoreCase) && X13 == true)
        {
            Bot2.SetActive(false);
            CanvasHermanos.SetActive(true);
            X13 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(hermanos6, StringComparison.InvariantCultureIgnoreCase) && X13 == true)
        {
            Bot2.SetActive(false);
            CanvasHermanos.SetActive(true);
            X13 = false;
            Bot1.SetActive(true);
        }

        //Diabetes

        if (typedText.Equals(diabetes1, StringComparison.InvariantCultureIgnoreCase) && X14 == true)
        {
            Bot2.SetActive(false);
            CanvasDiabetes.SetActive(true);
            X14 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(diabetes2, StringComparison.InvariantCultureIgnoreCase) && X14 == true)
        {
            Bot2.SetActive(false);
            CanvasDiabetes.SetActive(true);
            X14 = false;
            Bot1.SetActive(true);
        }

        if (typedText.Equals(diabetes3, StringComparison.InvariantCultureIgnoreCase) && X14 == true)
        {
            Bot2.SetActive(false);
            CanvasDiabetes.SetActive(true);
            X14 = false;
            Bot1.SetActive(true);
        }

        if (typedText.Equals(diabetes4, StringComparison.InvariantCultureIgnoreCase) && X14 == true)
        {
            Bot2.SetActive(false);
            CanvasDiabetes.SetActive(true);
            X14 = false;
            Bot1.SetActive(true);
        }

        //fumar

        if (typedText.Equals(fumar1, StringComparison.InvariantCultureIgnoreCase) && X15 == true)
        {
            Bot2.SetActive(false);
            CanvasFumar.SetActive(true);
            X15 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(fumar2, StringComparison.InvariantCultureIgnoreCase) && X15 == true)
        {
            Bot2.SetActive(false);
            CanvasFumar.SetActive(true);
            X15 = false;
            Bot1.SetActive(true);
        }

        if (typedText.Equals(fumar3, StringComparison.InvariantCultureIgnoreCase) && X15 == true)
        {
            Bot2.SetActive(false);
            CanvasFumar.SetActive(true);
            X15 = false;
            Bot1.SetActive(true);
        }

        if (typedText.Equals(fumar4, StringComparison.InvariantCultureIgnoreCase) && X15 == true)
        {
            Bot2.SetActive(false);
            CanvasFumar.SetActive(true);
            X15 = false;
            Bot1.SetActive(true);
        }

        if (typedText.Equals(fumar5, StringComparison.InvariantCultureIgnoreCase) && X15 == true)
        {
            Bot2.SetActive(false);
            CanvasFumar.SetActive(true);
            X15 = false;
            Bot1.SetActive(true);
        }

        //Beber

        if (typedText.Equals(beber1, StringComparison.InvariantCultureIgnoreCase) && X16 == true)
        {
            Bot2.SetActive(false);
            CanvasBeber.SetActive(true);
            X16 = false;
            Bot1.SetActive(true);
        }

        if (typedText.Equals(beber2, StringComparison.InvariantCultureIgnoreCase) && X16 == true)
        {
            Bot2.SetActive(false);
            CanvasBeber.SetActive(true);
            X16 = false;
            Bot1.SetActive(true);
        }

        //sustancias
        if (typedText.Equals(sustancias1, StringComparison.InvariantCultureIgnoreCase) && X17 == true)
        {
            Bot2.SetActive(false);
            CanvasSustancias.SetActive(true);
            X17 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(sustancias2, StringComparison.InvariantCultureIgnoreCase) && X17 == true)
        {
            Bot2.SetActive(false);
            CanvasSustancias.SetActive(true);
            X17 = false;
            Bot1.SetActive(true);
        }

        //Primera Regla

        if (typedText.Equals(PrimeraRegla1, StringComparison.InvariantCultureIgnoreCase) && X18 == true)
        {
            Bot2.SetActive(false);
            CanvasPrimeraRegla.SetActive(true);
            X18 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(PrimeraRegla2, StringComparison.InvariantCultureIgnoreCase) && X18 == true)
        {
            Bot2.SetActive(false);
            CanvasPrimeraRegla.SetActive(true);
            X18 = false;
            Bot1.SetActive(true);
        }

        //Ciclos
        if (typedText.Equals(Ciclos1, StringComparison.InvariantCultureIgnoreCase) && X19 == true)
        {
            Bot2.SetActive(false);
            CanvasCiclos.SetActive(true);
            X19 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Ciclos2, StringComparison.InvariantCultureIgnoreCase) && X19 == true)
        {
            Bot2.SetActive(false);
            CanvasCiclos.SetActive(true);
            X19 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Ciclos3, StringComparison.InvariantCultureIgnoreCase) && X19 == true)
        {
            Bot2.SetActive(false);
            CanvasCiclos.SetActive(true);
            X19 = false;
            Bot1.SetActive(true);
        }
        //Regular
        if (typedText.Equals(Regular1, StringComparison.InvariantCultureIgnoreCase) && X20 == true)
        {
            Bot2.SetActive(false);
            CanvasRegular.SetActive(true);
            X20 = false;
            Bot1.SetActive(true);
        }
        //Duración
        if (typedText.Equals(Duración1, StringComparison.InvariantCultureIgnoreCase) && X21 == true)
        {
            Bot2.SetActive(false);
            CanvasDuración.SetActive(true);
            X21 = false;
            Bot1.SetActive(true);
        }

        //Embarazos
        if (typedText.Equals(Embarazos1, StringComparison.InvariantCultureIgnoreCase) && X22 == true)
        {
            Bot2.SetActive(false);
            CanvasEmbarazos.SetActive(true);
            X22 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Embarazos2, StringComparison.InvariantCultureIgnoreCase) && X22 == true)
        {
            Bot2.SetActive(false);
            CanvasEmbarazos.SetActive(true);
            X22 = false;
            Bot1.SetActive(true);
        }

        //Aborto

        if (typedText.Equals(Aborto1, StringComparison.InvariantCultureIgnoreCase) && X23 == true)
        {
            Bot2.SetActive(false);
            CanvasAborto.SetActive(true);
            X23 = false;
            Bot1.SetActive(true);
        }

        //Cesárea
        if (typedText.Equals(Cesárea1, StringComparison.InvariantCultureIgnoreCase) && X24 == true)
        {
            Bot2.SetActive(false);
            CanvasCesárea.SetActive(true);
            X24 = false;
            Bot1.SetActive(true);
        }

        //Partos
        if (typedText.Equals(Partos1, StringComparison.InvariantCultureIgnoreCase) && X25 == true)
        {
            Bot2.SetActive(false);
            CanvasPartos.SetActive(true);
            X25 = false;
            Bot1.SetActive(true);
        }

        //Anticonceptivo
        if (typedText.Equals(Anticonceptivo1, StringComparison.InvariantCultureIgnoreCase) && X26 == true)
        {
            Bot2.SetActive(false);
            CanvasAnticonceptivos.SetActive(true);
            X26 = false;
            Bot1.SetActive(true);
        }

        //Dieta
        if (typedText.Equals(Dieta1, StringComparison.InvariantCultureIgnoreCase) && X27 == true)
        {
            Bot2.SetActive(false);
            CanvasDieta.SetActive(true);
            X27 = false;
            Bot1.SetActive(true);
        }

        //Ejercicio
        if (typedText.Equals(Ejercicio1, StringComparison.InvariantCultureIgnoreCase) && X28 == true)
        {
            Bot2.SetActive(false);
            CanvasEjercicio.SetActive(true);
            X28 = false;
            Bot1.SetActive(true);
        }

        //Familia
        if (typedText.Equals(Familia1, StringComparison.InvariantCultureIgnoreCase) && X29 == true)
        {
            Bot2.SetActive(false);
            CanvasFamilia.SetActive(true);
            X29 = false;
            Bot1.SetActive(true);
        }

        //Hijos
        if (typedText.Equals(Hijos1, StringComparison.InvariantCultureIgnoreCase) && X30 == true)
        {
            Bot2.SetActive(false);
            CanvasHijos.SetActive(true);
            X30 = false;
            Bot1.SetActive(true);
        }

        //Trabajar
        if (typedText.Equals(Trabajar1, StringComparison.InvariantCultureIgnoreCase) && X31 == true)
        {
            Bot2.SetActive(false);
            CanvasTrabajar.SetActive(true);
            X31 = false;
            Bot1.SetActive(true);
        }
        //RelaciónFamiliar
        if (typedText.Equals(RelaciónFamiliar1, StringComparison.InvariantCultureIgnoreCase) && X32 == true)
        {
            Bot2.SetActive(false);
            CanvasRelaciónFamiliar.SetActive(true);
            X32 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(RelaciónFamiliar2, StringComparison.InvariantCultureIgnoreCase) && X32 == true)
        {
            Bot2.SetActive(false);
            CanvasRelaciónFamiliar.SetActive(true);
            X32 = false;
            Bot1.SetActive(true);
        }

        //AmbienteTrabajo
        if (typedText.Equals(AmbienteTrabajo1, StringComparison.InvariantCultureIgnoreCase) && X33 == true)
        {
            Bot2.SetActive(false);
            CanvasAmbienteTrabajo.SetActive(true);
            X33 = false;
            Bot1.SetActive(true);
        }

        //FechaÚltimaRegla
        if (typedText.Equals(FechaÚltiaRegla1, StringComparison.InvariantCultureIgnoreCase) && X34 == true)
        {
            Bot2.SetActive(false);
            CanvasFechaÚltimaRegla.SetActive(true);
            X34 = false;
            Bot1.SetActive(true);
        }

        //ProblemasEmbarazo
        if (typedText.Equals(ProblemasEmbarazo1, StringComparison.InvariantCultureIgnoreCase) && X35 == true)
        {
            Bot2.SetActive(false);
            CanvasProblemasEmbarazo.SetActive(true);
            X35 = false;
            Bot1.SetActive(true);
        }

        //Empezó
        if (typedText.Equals(Empezó1, StringComparison.InvariantCultureIgnoreCase) && X36 == true)
        {
            Bot2.SetActive(false);
            CanvasEmpezó.SetActive(true);
            X36 = false;
            Bot1.SetActive(true);
        }

        //Empeora
        if (typedText.Equals(Empeora1, StringComparison.InvariantCultureIgnoreCase) && X37 == true)
        {
            Bot2.SetActive(false);
            CanvasEmpeora.SetActive(true);
            X37 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Empeora2, StringComparison.InvariantCultureIgnoreCase) && X37 == true)
        {
            Bot2.SetActive(false);
            CanvasEmpeora.SetActive(true);
            X37 = false;
            Bot1.SetActive(true);
        }

        //Esfuerzo
        if (typedText.Equals(Esfuerzo1, StringComparison.InvariantCultureIgnoreCase) && X38 == true)
        {
            Bot2.SetActive(false);
            CanvasEsfuerzo.SetActive(true);
            X38 = false;
            Bot1.SetActive(true);
        }

        //Cansada
        if (typedText.Equals(Cansada1, StringComparison.InvariantCultureIgnoreCase) && X39 == true)
        {
            Bot2.SetActive(false);
            CanvasCansada.SetActive(true);
            X39 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Cansada2, StringComparison.InvariantCultureIgnoreCase) && X39 == true)
        {
            Bot2.SetActive(false);
            CanvasCansada.SetActive(true);
            X39 = false;
            Bot1.SetActive(true);
        }

        //TranscursoDia
        if (typedText.Equals(TranscursoDía1, StringComparison.InvariantCultureIgnoreCase) && X40 == true)
        {
            Bot2.SetActive(false);
            CanvasTranscursoDia.SetActive(true);
            X40 = false;
            Bot1.SetActive(true);
        }

        //Mejora
        if (typedText.Equals(Mejora1, StringComparison.InvariantCultureIgnoreCase) && X41 == true)
        {
            Bot2.SetActive(false);
            CanvasMejora.SetActive(true);
            X41 = false;
            Bot1.SetActive(true);
        }

        //Peso
        if (typedText.Equals(Peso1, StringComparison.InvariantCultureIgnoreCase) && X42 == true)
        {
            Bot2.SetActive(false);
            CanvasPeso.SetActive(true);
            X42 = false;
            Bot1.SetActive(true);
        }

        //ComeMenos
        if (typedText.Equals(ComeMenos1, StringComparison.InvariantCultureIgnoreCase) && X43 == true)
        {
            Bot2.SetActive(false);
            CanvasComeMenos.SetActive(true);
            X43 = false;
            Bot1.SetActive(true);
        }

        //CuantoPeso
        if (typedText.Equals(CuantoPeso1, StringComparison.InvariantCultureIgnoreCase) && X44 == true)
        {
            Bot2.SetActive(false);
            CanvasCuántoPeso.SetActive(true);
            X44 = false;
            Bot1.SetActive(true);
        }

        //Atribuye
        if (typedText.Equals(Atribuye1, StringComparison.InvariantCultureIgnoreCase) && X45 == true)
        {
            Bot2.SetActive(false);
            CanvasAtribuye.SetActive(true);
            X45 = false;
            Bot1.SetActive(true);
        }

        //Viaje
        if (typedText.Equals(Viaje1, StringComparison.InvariantCultureIgnoreCase) && X46 == true)
        {
            Bot2.SetActive(false);
            CanvasViaje.SetActive(true);
            X46 = false;
            Bot1.SetActive(true);
        }

        //Preocupación
        if (typedText.Equals(Preocupación1, StringComparison.InvariantCultureIgnoreCase) && X47 == true)
        {
            Bot2.SetActive(false);
            CanvasPreocupación.SetActive(true);
            X47 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Preocupación2, StringComparison.InvariantCultureIgnoreCase) && X47 == true)
        {
            Bot2.SetActive(false);
            CanvasPreocupación.SetActive(true);
            X47 = false;
            Bot1.SetActive(true);
        }

        //Operaciones
        if (typedText.Equals(Operaciones1, StringComparison.InvariantCultureIgnoreCase) && X48 == true)
        {
            Bot2.SetActive(false);
            CanvasOperaciones.SetActive(true);
            X48 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Operaciones2, StringComparison.InvariantCultureIgnoreCase) && X48 == true)
        {
            Bot2.SetActive(false);
            CanvasOperaciones.SetActive(true);
            X48 = false;
            Bot1.SetActive(true);
        }

        //Azucar
        if (typedText.Equals(Azucar1, StringComparison.InvariantCultureIgnoreCase) && X49 == true)
        {
            Bot2.SetActive(false);
            CanvasAzucar.SetActive(true);
            X49 = false;
            Bot1.SetActive(true);
        }

        //DiagnósticoDiabetes
        if (typedText.Equals(DiagnósticoDiabetes1, StringComparison.InvariantCultureIgnoreCase) && X50 == true)
        {
            Bot2.SetActive(false);
            CanvasDiagnósticoDiabetes.SetActive(true);
            X50 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(DiagnósticoDiabetes2, StringComparison.InvariantCultureIgnoreCase) && X50 == true)
        {
            Bot2.SetActive(false);
            CanvasDiagnósticoDiabetes.SetActive(true);
            X50 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(DiagnósticoDiabetes3, StringComparison.InvariantCultureIgnoreCase) && X50 == true)
        {
            Bot2.SetActive(false);
            CanvasDiagnósticoDiabetes.SetActive(true);
            X50 = false;
            Bot1.SetActive(true);
        }

        //TratamientoEmbarazo
        if (typedText.Equals(TratamientoEmbarazo1, StringComparison.InvariantCultureIgnoreCase) && X51 == true)
        {
            Bot2.SetActive(false);
            CanvasTratamientoEmbarazo.SetActive(true);
            X51 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(TratamientoEmbarazo2, StringComparison.InvariantCultureIgnoreCase) && X51 == true)
        {
            Bot2.SetActive(false);
            CanvasTratamientoEmbarazo.SetActive(true);
            X51 = false;
            Bot1.SetActive(true);
        }

        //HipertensiónTratamiento
        if (typedText.Equals(HipertensiónTratamiento1, StringComparison.InvariantCultureIgnoreCase) && X52 == true)
        {
            Bot2.SetActive(false);
            CanvasHiperTensiónTratamiento.SetActive(true);
            X52 = false;
            Bot1.SetActive(true);
        }

        //HipertensiónDiagnóstico
        if (typedText.Equals(HipertensiónDiagnostico1, StringComparison.InvariantCultureIgnoreCase) && X53 == true)
        {
            Bot2.SetActive(false);
            CanvasHiperTensiónDiagnóstico.SetActive(true);
            X53 = false;
            Bot1.SetActive(true);
        }

        //Colesterol
        if (typedText.Equals(Colesterol1, StringComparison.InvariantCultureIgnoreCase) && X54 == true)
        {
            Bot2.SetActive(false);
            CanvasHiperTensiónDiagnóstico.SetActive(true);
            X54 = false;
            Bot1.SetActive(true);
        }

        //ColesterolDiagnóstico
        if (typedText.Equals(ColesterolDiagnóstico1, StringComparison.InvariantCultureIgnoreCase) && X55 == true)
        {
            Bot2.SetActive(false);
            CanvasColesterolDiagnóstico.SetActive(true);
            X55 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(ColesterolDiagnóstico2, StringComparison.InvariantCultureIgnoreCase) && X55 == true)
        {
            Bot2.SetActive(false);
            CanvasColesterolDiagnóstico.SetActive(true);
            X55 = false;
            Bot1.SetActive(true);
        }

        //TerminarConsulta
        if (typedText.Equals(TerminarConsulta1, StringComparison.InvariantCultureIgnoreCase) && X56 == true)
        {
            Bot2.SetActive(false);
            CanvasTerminarConsulta.SetActive(true);
            X56 = false;
            Bot1.SetActive(true);
        }

        //RecomendarReposo
        if (typedText.Equals(RecomendarReposo1, StringComparison.InvariantCultureIgnoreCase) && X57 == true)
        {
            Bot2.SetActive(false);
            CanvasRecomendarReposo.SetActive(true);
            X57 = false;
            Bot1.SetActive(true);
        }

        //Calmar
        if (typedText.Equals(Calmar1, StringComparison.InvariantCultureIgnoreCase) && X58 == true)
        {
            Bot2.SetActive(false);
            CanvasCalmar.SetActive(true);
            X58 = false;
            Bot1.SetActive(true);
        }

        //Despedida
        if (typedText.Equals(Despedida1, StringComparison.InvariantCultureIgnoreCase) && X59 == true)
        {
            Bot2.SetActive(false);
            CanvasDespedida.SetActive(true);
            X59 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Despedida2, StringComparison.InvariantCultureIgnoreCase) && X59 == true)
        {
            Bot2.SetActive(false);
            CanvasDespedida.SetActive(true);
            X59 = false;
            Bot1.SetActive(true);
        }
        if (typedText.Equals(Despedida3, StringComparison.InvariantCultureIgnoreCase) && X59 == true)
        {
            Bot2.SetActive(false);
            CanvasDespedida.SetActive(true);
            X59 = false;
            Bot1.SetActive(true);
        }




    }
    public void Cerrar()
    {
        //esto se asigna a un botón en el canvas para limpiar la info de la pantalla
        CanvasMotivos.SetActive(false);
        CanvasSaludo.SetActive(false);
        CanvasNombre.SetActive(false);
        CanvasEdad.SetActive(false);
        CanvasAlergias.SetActive(false);
        CanvasAlimentos.SetActive(false);
        CanvasFamiliares.SetActive(false);
        CanvasCáncer.SetActive(false);
        CanvasMadre.SetActive(false);
        CanvasPadre.SetActive(false);
        CanvasInfartos.SetActive(false);
        CanvasHermanos.SetActive(false);
        CanvasDiabetes.SetActive(false);
        CanvasFumar.SetActive(false);
        CanvasBeber.SetActive(false);
        CanvasSustancias.SetActive(false);
        CanvasPrimeraRegla.SetActive(false);
        CanvasCiclos.SetActive(false);
        CanvasRegular.SetActive(false);
        CanvasDuración.SetActive(false);
        CanvasEmbarazos.SetActive(false);
        CanvasAborto.SetActive(false);
        CanvasCesárea.SetActive(false);
        CanvasPartos.SetActive(false);
        CanvasAnticonceptivos.SetActive(false);
        CanvasDieta.SetActive(false);
        CanvasEjercicio.SetActive(false);
        CanvasFamilia.SetActive(false);
        CanvasHijos.SetActive(false);
        CanvasTrabajar.SetActive(false);
        CanvasRelaciónFamiliar.SetActive(false);
        CanvasAmbienteTrabajo.SetActive(false);
        CanvasFechaÚltimaRegla.SetActive(false);
        CanvasProblemasEmbarazo.SetActive(false);
        CanvasEmpezó.SetActive(false);
        CanvasEmpeora.SetActive(false);
        CanvasEsfuerzo.SetActive(false);
        CanvasCansada.SetActive(false);
        CanvasTranscursoDia.SetActive(false);
        CanvasMejora.SetActive(false);
        CanvasPeso.SetActive(false);
        CanvasCuántoPeso.SetActive(false);
        CanvasComeMenos.SetActive(false);
        CanvasAtribuye.SetActive(false);
        CanvasViaje.SetActive(false);
        CanvasPreocupación.SetActive(false);
        CanvasOperaciones.SetActive(false);
        CanvasAzucar.SetActive(false);
        CanvasDiagnósticoDiabetes.SetActive(false);
        CanvasTratamientoEmbarazo.SetActive(false);
        CanvasHiperTensiónTratamiento.SetActive(false);
        CanvasHiperTensiónDiagnóstico.SetActive(false);
        CanvasColesterol.SetActive(false);
        CanvasColesterolDiagnóstico.SetActive(false);
        CanvasTerminarConsulta.SetActive(false);
        CanvasRecomendarReposo.SetActive(false);
        CanvasCalmar.SetActive(false);
        CanvasDespedida.SetActive(false);




        Bot2.SetActive(true);
        Bot1.SetActive(false);
    }
}

