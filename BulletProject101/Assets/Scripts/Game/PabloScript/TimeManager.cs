using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    
    public float startTime;
    private float countingTime;

    private Text theText;

    //Calls PauseMenu functions
    private PauseMenu thePauseMenu;

    //Calls Level Complete Screen 
    public GameObject LevelComplete;

    void Start()
    {
        countingTime = startTime;

        theText = GetComponent<Text>();

        thePauseMenu = FindObjectOfType<PauseMenu>();

        LevelComplete.SetActive(false);

    }


    void Update()
    {
        //If Paused then timer stops until it resumes
        if (thePauseMenu.Paused)
            return;

        if (countingTime > 0)
        {
            countingTime -= Time.deltaTime;
            DisplayTime(countingTime);
        }
        //Ends level when counter reaches zero
        else
        {
            countingTime = 0;
            Time.timeScale = 0f;
            LevelComplete.SetActive(true);
        }

        //Rounds to whole numbers
        //theText.text = "" + Mathf.Round(countingTime);

    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        theText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
