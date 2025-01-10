using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip sound01;
    public AudioClip sound02;
    public AudioClip sound03;

    //プログラムの追加

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Blue")
        {
            audioSource.PlayOneShot(sound01);
        }
        else if (other.gameObject.tag == "Block")
        {
            audioSource.PlayOneShot(sound02);
        }
        else
        {
            audioSource.PlayOneShot(sound03);
        }
    }


}
