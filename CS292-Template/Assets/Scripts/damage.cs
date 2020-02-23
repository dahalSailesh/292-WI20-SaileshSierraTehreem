using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    {
        squirrelMove controller = other.gameObject.GetComponent<squirrelMove>();
        if (controller != null)
        {
            
            Score.scoreValue -= 1;
            controller.ChangeAcornCount(-1);
            SoundManager.PlaySound("HitOne");
        }
    }

}