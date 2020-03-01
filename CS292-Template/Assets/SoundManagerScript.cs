using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

public static AudioClip AcornTwo, Fries, GameOver, HitOne, HitTwo;
static AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {
        AcornTwo = Resources.Load<AudioClip>("AcornTwo");
        Fries = Resources.Load<AudioClip>("Fries");
        GameOver = Resources.Load<AudioClip>("GameOver");
        HitOne = Resources.Load<AudioClip>("HitOne");
        HitTwo = Resources.Load<AudioClip>("HitTwo");

        audioSrc = GetComponent<AudioSource> ();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound (string clip)
    {

        switch(clip){
        case "AcornTwo":
        audioSrc.PlayOneShot(AcornTwo);
        break;

        case "Fries":
        audioSrc.PlayOneShot(Fries);
        break;

        case "GameOver":
        audioSrc.PlayOneShot(GameOver);
        break;

        case "HitOne":
        audioSrc.PlayOneShot(HitOne);
        break;

        case "HitTwo":
        audioSrc.PlayOneShot(HitTwo);
        break;
        }
    }
}