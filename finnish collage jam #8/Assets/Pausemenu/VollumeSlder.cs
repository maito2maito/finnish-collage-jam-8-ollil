using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    public AudioMixer masterMixer; // Master ‰‰nen s‰‰tˆ
    public AudioMixer musicMixer;  // Musiikin s‰‰tˆ
    public AudioMixer sfxMixer;    // SFX ‰‰nen s‰‰tˆ

    public void SetMasterVolume(float volume)
    {
        // Asetetaan master ‰‰nenvoimakkuus
        masterMixer.SetFloat("volume", volume );
    }

    public void SetMusicVolume(float volume)
    {
        // Asetetaan musiikin ‰‰nenvoimakkuus
        musicMixer.SetFloat("music",volume);
    }

    public void SetSFXVolume(float volume)
    {
        // Asetetaan SFX ‰‰nenvoimakkuus
        sfxMixer.SetFloat("sfx", volume);
    }
}
