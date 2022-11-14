using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] AudioSource scr;

    [SerializeField] private AudioClip flap, hit, point;


    public void PlayFlap()
    {
        scr.clip = flap;
        scr.Play();
    }
    public void PlayHit()
    {
        scr.clip = hit;
        scr.Play();
    }
    public void PlayPoint()
    {
        scr.clip = point;
        scr.Play();
    }
}
