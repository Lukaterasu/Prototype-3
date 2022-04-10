using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip warningSound, fallingSound;
    static AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        warningSound = Resources.Load<AudioClip>("Warning SFX");
        fallingSound = Resources.Load<AudioClip>("Falling SFX");
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Warning SFX":
                audioSource.PlayOneShot(warningSound);
                break;
            case "Falling SFX":
                audioSource.PlayOneShot(fallingSound);
                break;
        }
    }
}
