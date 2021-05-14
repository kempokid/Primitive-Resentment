using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource _as;

    public AudioClip[] audioClipArray;

    private void Start()
    {
        _as = GetComponent<AudioSource>();
        
    }

    public void PlaySound()
    {
        _as.PlayOneShot(_as.clip);
        _as.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
    }

    
}
