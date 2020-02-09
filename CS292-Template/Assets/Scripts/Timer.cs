using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 5f;
    public GameObject Panel;

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        if (PauseButtonScript.GameOver)
        {
            currentTime = 0;
            countdownText.text = currentTime.ToString("0");
            Application.LoadLevel(0);
            return;
        }
        if (Convert.ToInt32(currentTime) == 0)
        {
            GameOver();
            Panel.SetActive(true);
        }
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
    }

    void GameOver()
    {
        Time.timeScale = 0f;
    }
}