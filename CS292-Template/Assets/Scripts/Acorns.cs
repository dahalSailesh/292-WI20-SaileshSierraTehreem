using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorns : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        squirrelMove controller = other.GetComponent<squirrelMove>();
        if (controller != null)
        {
            controller.ChangeAcornCount(1);
            Destroy(gameObject);
        }
    }
}
