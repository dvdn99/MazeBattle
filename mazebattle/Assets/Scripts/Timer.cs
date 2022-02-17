using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 90;
    public Text timeText;

    // Update is called once per frame
    void Update()
    {
        if(timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }else 
        {
            GameManager_Master.current.CallEventGameOver();
        }
        
        ShowTime(timeValue);
    }

    void ShowTime(float timeToShow)
    {
        if(timeToShow < 0)
        {
            timeToShow = 0;
        }

        float minutes = Mathf.FloorToInt(timeToShow / 60);
        float seconds = Mathf.FloorToInt(timeToShow % 60);

        timeText.text = "Time Remain:  " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
