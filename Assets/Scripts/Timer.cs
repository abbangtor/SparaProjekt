using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    
    public float timeRemaining = 120;
    public bool isRunning = false;
    public Text timeText;   

    private void Start()
    {
        isRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("End game + save score + eventually update leaderboard + go to menu");
                timeRemaining = 0;  
                isRunning = false;
            }

        }
    }
    void DisplayTime(float timeToDisplay)
    {

    timeToDisplay += 1;
    float minutes = Mathf.FloorToInt(timeToDisplay / 60);
    float seconds = Mathf.FloorToInt(timeToDisplay % 60);
    timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    } 
}
    