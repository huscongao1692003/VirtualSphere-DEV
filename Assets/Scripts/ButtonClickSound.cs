using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickSound : MonoBehaviour
{
    public AudioSource audioSource;
    public void PlaySound()
    {
        audioSource.Play();
    }
}
