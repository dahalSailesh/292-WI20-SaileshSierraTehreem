using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScore;

    void Start()
    {

        highScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    void Update()
    {

        if (Score.scoreValue > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Score.scoreValue);
            highScore.text = "High Score: " + Score.scoreValue.ToString();
        }
    }
}