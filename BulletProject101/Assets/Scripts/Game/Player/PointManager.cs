using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateScore(int points)
    {
        score += points; 
    }
}
