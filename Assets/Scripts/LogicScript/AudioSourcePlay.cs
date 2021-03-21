using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourcePlay : MonoBehaviour
{
    public AudioSource audios;
    private float valueAux;
    private float value;

    void Awake()
    {
        valueAux = 100f;
        PlayAudioSource();
    }



    public void UpdateAudio()
    {
        value = PlayerPrefs.GetFloat("VolumeAudio", 0f);

        if(value != valueAux)
        {
            audios.volume = value;
            valueAux = value;
        }
    }

    private void PlayAudioSource()
    {
        UpdateAudio();
        audios.Play();
    }

    

}
