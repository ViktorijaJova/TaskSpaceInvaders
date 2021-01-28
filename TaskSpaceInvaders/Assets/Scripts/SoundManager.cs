using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip explosionsound;
    public AudioClip bulletsound;

   void PlayExplosionSound()
    {
        GetComponent<AudioSource>().PlayOneShot(explosionsound);
    }
    void PlayBulletSound()
    {
        GetComponent<AudioSource>().PlayOneShot(bulletsound);
    }
}
