using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60;
    public GameObject gameover;
    public TextMeshProUGUI timerText;
    public float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = timeRemaining;
    }

    // Update is called once per frame
    void Update()
    {

        currentTime -= Time.deltaTime;
        if (currentTime<=0)
        {
            currentTime = 0;
            gameover.SetActive(true);
        }
        // else{
        //     timeRemaining = 0;
        //     //DisplayTime(timeRemaining);
        //     //gameover.SetActive(true);
            
        // }
        DisplayTime();
    }

    void DisplayTime()
    {
        // if (timeDisplay<0)
        // {
        //     timeDisplay = 0;
        // }
        int minutes = Mathf.FloorToInt(currentTime/60);
        int seconds = Mathf.FloorToInt(currentTime%60);
        string timerStr = string.Format("{0:00}:{1:00}", minutes, seconds);
        // float 
        timerText.text = timerStr;
    }
}
