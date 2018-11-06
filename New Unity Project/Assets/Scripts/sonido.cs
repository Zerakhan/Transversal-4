using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido : MonoBehaviour {

    private AudioSource audioSrc;
    private float musicVolume = 1f;
    float m_MySliderValue;
    AudioSource m_MyAudioSource;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        m_MySliderValue = 0.5f;
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Play();
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