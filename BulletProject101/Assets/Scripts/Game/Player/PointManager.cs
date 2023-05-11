using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PointManager : MonoBehaviour
{
   
    // Start is called before the first frame update
    public int score;
    public TMP_Text scoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateScore(int points)
    {
        score += points; 
        scoreText.text = "Score: " + score;
    }
}
