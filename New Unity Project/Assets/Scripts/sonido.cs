using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido : MonoBehaviour {

<<<<<<< HEAD
    private AudioSource audioSrc;
    private float musicVolume = 1f;
    float m_MySliderValue;
    AudioSource m_MyAudioSource;
=======
    public AudioSource audioSrc;
    public float musicVolume = 0.5f;
>>>>>>> 0f044b768662aa142987bfcbd1dc3841ab41b3f3

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