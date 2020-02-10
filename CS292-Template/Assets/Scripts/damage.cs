using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        squirrelMove controller = other.gameObject.GetComponent<squirrelMove>();

        if (controller != null)
        {
            Score.scoreValue -= 1;
            controller.ChangeAcornCount(-1);
        }
    }
}