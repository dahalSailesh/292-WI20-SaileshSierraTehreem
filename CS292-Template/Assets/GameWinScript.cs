﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWinScript : MonoBehaviour
{
    public GameObject Panel;

    void OnTriggerEnter2D(Collider2D other)
    {
        squirrelMove controller = other.GetComponent<squirrelMove>();
        if (controller != null)
        {
            Time.timeScale = 0f;
            if (Panel != null)
            {
                Panel.SetActive(true);
            }
        }
    }

}