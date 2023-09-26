using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartScript : MonoBehaviour
{
    public float timeRemaining = 120;
    public bool timerIsRunning = false;
    public Text timeText;
    public BoxCollider BowCollider;
    public void OnStart()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        BowCollider.enabled = true;
        Game(timerIsRunning);
    }
    private void Game(bool TimerRunning, int time)
    {
        if (TimerRunning)
        {
            if (time > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
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