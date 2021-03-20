using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveVolume : MonoBehaviour
{
    public Slider sldVolume;

    public void GetValueVolume()
    {
        sldVolume.value = PlayerPrefs.GetFloat("VolumeAudio", 0);
    }

    public void SaveVolumeAudio()
    {
        PlayerPrefs.SetFloat("VolumeAudio", sldVolume.value);
        PlayerPrefs.Save();
    }







}
