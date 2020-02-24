using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gizFries : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        squirrelMove controller = other.GetComponent<squirrelMove>();
        if (controller != null)
        {
            
            Score.scoreValue += 10;
            controller.ChangeAcornCount(10);
        
            Destroy(gameObject);
            
        }
    }

}