using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 60f;
    public GameObject Panel;

    [SerializeField] Text countdownText;


    void Start()
    {
        currentTime = startingTime;
    }


    void Update()
    {
        if (PauseButtonScript.timer == true)
        {
            if (PauseButtonScript.GameOver)
            {
                countdownText.text = currentTime.ToString("00");
                return;
            }

            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("00");

            if (Convert.ToInt32(currentTime) == 0 || Score.scoreValue < 0 || squirrelMove.dead)
            {
                
                GameOver();
                
                return;
            }
        }
    }


    void GameOver()
    {
        Time.timeScale = 0f;
        Panel.SetActive(true);
        currentTime = startingTime;
    }

}