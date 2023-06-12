using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneManager: MonoBehaviour
{
    public Text lastScoreText;
    int lastScore;

    public Text highScoreText;
    int highScore;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<AudioSource>().Play();

        lastScore = PlayerPrefs.GetInt("Score");
        lastScoreText.text = lastScore.ToString();

        if (PlayerPrefs.HasKey("highScore") == true)
        {
            highScore = PlayerPrefs.GetInt("highScore");

            if (highScore < lastScore)
            {
                highScore = lastScore;
                PlayerPrefs.SetInt("highScore", highScore);
            }
        }
        else
        {
            highScore = lastScore;
            PlayerPrefs.SetInt("highScore", highScore);
        }

        highScoreText.text = highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
