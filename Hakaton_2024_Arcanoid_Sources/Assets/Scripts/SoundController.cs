using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioSource _soundLevel;

    [SerializeField] private AudioSource _soundGameOver;

    [SerializeField] private AudioSource _soundWinLevel;

    private void StopAllSound()
    {
        _soundLevel.Stop();
        _soundGameOver.Stop();
        _soundWinLevel.Stop();
    }

    public void SoundGameOver()
    {
        
        StopAllSound();

        _soundGameOver.Play();              
    }

    public void SoundWinLevel() 
    {        
        StopAllSound();

        _soundWinLevel.Play();       
    }
}
