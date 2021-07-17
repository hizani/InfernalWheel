using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetSliderValue : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;
    void Start()
    {
        float tempVol = slider.value;
        mixer.GetFloat("MusicVol", out tempVol);
        slider.value = Mathf.Pow(10, tempVol / 20);
    }
}