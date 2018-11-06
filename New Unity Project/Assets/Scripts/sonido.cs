using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido : MonoBehaviour {

<<<<<<< HEAD
    private AudioSource audioSrc;
    private float musicVolume = 1f;
<<<<<<< HEAD
    float m_MySliderValue;
    AudioSource m_MyAudioSource;
=======
    public AudioSource audioSrc;
    public float musicVolume = 0.5f;
>>>>>>> 0f044b768662aa142987bfcbd1dc3841ab41b3f3
=======
>>>>>>> parent of 9324b58... aa

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