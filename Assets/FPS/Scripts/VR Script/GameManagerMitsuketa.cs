using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerMitsuketa : MonoBehaviour
{
    public float dueTime;
    public int score = 0;

    public bool isStationComplete = false;

    public Text timerText,
        scoreText,
        timesUpText;
    public AudioSource finishBeep;

    void FixedUpdate()
    {
        if (!isStationComplete)
        {
            dueTime -= Time.deltaTime;
            timerText.text = TimePassedString();
            scoreText.text = "Score : " + score;

            // if time runs dead
            if (dueTime <= 0)
                EndGame();
        }
    }

    public string TimePassedString()
    {
        int sec = (int)dueTime % 60,
            min = (int)dueTime / 60;

        return (min + ":" + sec);
    }

    public void EndGame()
    {
        isStationComplete = true;
        finishBeep.Play();

        timesUpText.gameObject.SetActive(true);
        timerText.gameObject.SetActive(false);
    }

    public void IncrementScore(int n)
    {
        score += n;
    }
}
