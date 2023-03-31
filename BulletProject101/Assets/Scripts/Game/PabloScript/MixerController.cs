using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class MixerController : MonoBehaviour
{
    [SerializeField]
    private AudioMixer myAudioMixer;

    public void SetVolume(float sliderValue)
    {
        myAudioMixer.SetFloat("SFXVolume", Mathf.Log10(sliderValue) * 20);
    }
    
}
