using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FartAirScrip : MonoBehaviour
{
    public AudioSource AudioSource;

    public List<AudioClip> AudioClips;

    private void OnTriggerEnter(Collider other)
    {
        var randomClip = AudioClips[Random.Range (0, AudioClips.Count)];

        AudioSource.clip = randomClip;
        AudioSource.Play();
        
        Debug.Log("Player farted !!");
    }
}
