using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public bool isGame = true;
    
    public void Dol_100()
    {
        if (!isGame) return;
        score += 100;
    }

    public void Dol_1000()
    {
        if (!isGame) return;
        score += 1000;
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 0)
        {
            scoreText.text = "0000";
        }
        else
        {
            scoreText.text = score.ToString();
        }

        PlayerPrefs.SetInt("Score", score);
    }
}
