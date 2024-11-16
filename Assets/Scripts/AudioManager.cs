using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;


    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Blue")
        {
            audioSource.PlayOneShot(sound1);
        }
        else if (other.gameObject.tag == "Block")
        {
            audioSource.PlayOneShot(sound2);
        }
        else
        {
            audioSource.PlayOneShot(sound3);
        }
    }


}
