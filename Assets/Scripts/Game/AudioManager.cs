using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioSettings audioSettings;
    public AudioMixer audioMixer;

    private void Start()    
    {
        LoadAudioSettings();
    }

    public void SetMasterVolume(float volume)
    {
        audioSettings.masterVolume = volume;
        audioMixer.SetFloat("Master", Mathf.Log10(volume) * 20);
    }

    private void LoadAudioSettings()
    {
        SetMasterVolume(audioSettings.masterVolume);
    }
    public void SinVolumen(float volume)
    {
        audioMixer.SetFloat("Master", Mathf.Log10(volume) * 0);
    }
    public void ConVolumen(float volume)
    {
        audioMixer.SetFloat("Master", Mathf.Log10(volume) * 20);
    }
}