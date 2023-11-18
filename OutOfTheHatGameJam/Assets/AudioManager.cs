using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;

    void Awake()
    {
        audioSource.Play();
    }
    
    public void PlaySong()
    {
        audioSource.Play();
    }
}
