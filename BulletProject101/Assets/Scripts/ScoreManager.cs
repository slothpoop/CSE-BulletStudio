using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour 
{
    public int score;
    public TMP_Text scoreText;
    void start()
    {

    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score:" + score;
    }
}