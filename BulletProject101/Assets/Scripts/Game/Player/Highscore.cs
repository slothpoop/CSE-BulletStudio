using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Highscore : MonoBehaviour
{
    // Start is called before the first frame update
    int highscore;
    private void Start()
    {
        SetLatestHighscore();
    }

    // Update is called once per frame
    private void SetLatestHighscore()
    {
        highscore = PlayerPrefs.GetInt("Highscore", 0);
    }
    private void SaveHighscore(int score)
    {
        PlayerPrefs.SetInt("Highscore", score);
    }
    public void SetHighscoreIfGreater(int score)
    {
        if (score > highscore)
        {
            highscore = score;
            SaveHighscore(score);
        }
    }
}
