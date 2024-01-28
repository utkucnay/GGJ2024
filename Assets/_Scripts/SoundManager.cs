using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Composites;
using UnityEngine.UI;

public class SoundManager : Singleton<SoundManager>
{
    public AudioClip button;
    public AudioClip[] drawCards;

    public AudioSource sFXAuidoSource;

    public enum SFXSoundType
    {
        Button,
        DrawACard,
    }

    public void PlaySFXSound(SFXSoundType sfxSoundType) 
    {
        switch (sfxSoundType)
        {
            case SFXSoundType.Button:
                sFXAuidoSource.clip = button;
                sFXAuidoSource.pitch = 1 + Random.Range(-.10f, .10f);
                sFXAuidoSource.Play();
                break;
            case SFXSoundType.DrawACard:
                sFXAuidoSource.clip = drawCards[Random.Range(0, drawCards.Length)];
                sFXAuidoSource.pitch = 1 + Random.Range(-.20f, .20f);
                sFXAuidoSource.Play();
                break;
        }
    }
}
