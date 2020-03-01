using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

public static AudioClip AcornTwo, GizmoFries, GameOver, HitOne, HitTwo, GameWin, AcornThree, HitThree;
static AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {
        AcornTwo = Resources.Load<AudioClip>("AcornTwo");
        AcornThree = Resources.Load<AudioClip>("AcornThree");
        GizmoFries = Resources.Load<AudioClip>("GizmoFries");
        GameOver = Resources.Load<AudioClip>("GameOver");
        HitOne = Resources.Load<AudioClip>("HitOne");
        HitTwo = Resources.Load<AudioClip>("HitTwo");
        GameWin = Resources.Load<AudioClip>("GameWin");
        HitThree = Resources.Load<AudioClip>("HitThree");

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

        case "GizmoFries":
        audioSrc.PlayOneShot(GizmoFries);
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

        case "GameWin":
        audioSrc.PlayOneShot(GameWin);
        break;

        case "AcornThree":
        audioSrc.PlayOneShot(AcornThree);
        break;

        case "HitThree":
        audioSrc.PlayOneShot(HitThree);
        break;
        }
    }
}