using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager2 : MonoBehaviour
{

    public static AudioClip FriesSound, HitOneSound, HitTwoSound;
    static AudioSource audioSrc;

    void Start2()
    {
        FriesSound = Resources.Load<AudioClip>("Fries");
        HitOneSound = Resources.Load<AudioClip>("HitOne");
        HitTwoSound = Resources.Load<AudioClip>("HitTwo");
       


    }






    public static void PlaySound2(string clip)
    {

        switch (clip)
        {
            case "Fries":
                audioSrc.PlayOneShot(FriesSound);
                break;

            case "HitOne":
                audioSrc.PlayOneShot(HitOneSound);
                break;

            case "HitTwo":
                audioSrc.PlayOneShot(HitTwoSound);
                break;

            
        }
    }
    }