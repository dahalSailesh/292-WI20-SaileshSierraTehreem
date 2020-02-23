﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip FriesSound, HitOneSound, HitTwoSound, AcornSound, GameOverSound;
    static AudioSource audioSrc;

    void Start()
    {
        FriesSound = Resources.Load<AudioClip>("Fries");
        HitOneSound = Resources.Load<AudioClip>("HitOne");
        HitTwoSound = Resources.Load<AudioClip>("HitTwo");
        AcornSound = Resources.Load<AudioClip>("Acorn");
        GameOverSound = Resources.Load<AudioClip>("GameOver");

        audioSrc = GetComponent<AudioSource>();
        

    }


    public static void PlaySound(string clip)
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

            case "Acorn":
                audioSrc.PlayOneShot(AcornSound);
                break;

            case "GameOver":
                audioSrc.PlayOneShot(GameOverSound);
                break;

        }

    }
}