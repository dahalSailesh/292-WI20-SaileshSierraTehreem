using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButtonScript : MonoBehaviour
{

    public GameObject Panel;
    public GameObject Panel2;

    public static bool GameIsPaused = false;
    public static bool timer;
    public static bool GameOver = false;


    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }


    public void Resume()
    {
        Panel.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        GameOver = false;
        squirrelMove.dead = false;
        timer = true;
    }


    public void Pause()
    {
        Panel.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }


    public void LoadMenu()
    {
        Panel.SetActive(false);
        Panel2.SetActive(true);
        GameOver = true;
        SceneManager.LoadScene("temp-w-gamescreen");
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}