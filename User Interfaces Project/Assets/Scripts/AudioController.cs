using System.Collections;
using UnityEngine.Audio;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    static public void PlayMusic(GameObject gameObject, AudioClip audioClip)
    {
        gameObject.GetComponent<AudioSource>().Stop();
        gameObject.GetComponent<AudioSource>().PlayOneShot(audioClip);
    }
}
