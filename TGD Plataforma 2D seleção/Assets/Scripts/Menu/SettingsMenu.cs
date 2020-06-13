using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    //audio mixer
    public AudioMixer audioMixer;


    //controls sfx volume
    public void SetSfxVolume(float volume)
    {
        audioMixer.SetFloat("SfxVolume", volume);
    }

    public void SetBgmVolume(float volume)
    {
        audioMixer.SetFloat("BgmVolume", volume);
    }


}
