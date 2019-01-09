using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour {

    public GameObject Pause;

    void Start() {
        Pause.SetActive(false);
    }
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cambio();
        }*/
    }

    void Cambio()
    {
        if (Time.timeScale == 1)
            Pausear();

        else if (Time.timeScale == 0)
            Continuar();
    }

    void Pausear()
    {
        Pause.SetActive(true);
        Time.timeScale = 0;
    }

    void Continuar()
    {
        Pause.SetActive(false);
        Time.timeScale = 1;
    }

    void Menu ()
    {
        SceneManager.LoadScene("menu");
    }
}