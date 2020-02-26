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
            
            Score.scoreValue += 1;
            SoundManager.PlaySound ("Acorn");
            controller.ChangeAcornCount(1);
            Destroy(gameObject);
           
        }
    }
}
