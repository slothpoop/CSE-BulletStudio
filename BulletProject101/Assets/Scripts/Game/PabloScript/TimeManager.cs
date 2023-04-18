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

    private PauseMenu thePauseMenu;

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
        if (thePauseMenu.Paused)
            return;


        countingTime -= Time.deltaTime;
        
        if (countingTime <= 0)
        {
            countingTime = 0;
            Time.timeScale = 0f;
            LevelComplete.SetActive(true);
        }

        theText.text = "" + Mathf.Round(countingTime);

    }
}
