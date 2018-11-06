using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido : MonoBehaviour {

    float m_MySliderValue;
    AudioSource m_MyAudioSource;

    public AudioSource audioSrc;
    public float musicVolume = 0.5f;


    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        audioSrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}