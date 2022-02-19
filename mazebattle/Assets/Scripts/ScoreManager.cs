using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager current; 

    void Awake()
    {
        if (current) 
        { 
            Destroy(gameObject);
        } 
        else 
        { 
            current = this;
        }
        
    }


    void Update()
    {
        
        //ShowTime(timeValue);
    }


    /*
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
    */

    public string getStringTime(float timeValue)
    {
        if(timeValue < 0)
        {
            timeValue = 0;
        }

        float minutes = Mathf.FloorToInt(timeValue / 60);
        float seconds = Mathf.FloorToInt(timeValue % 60);

        return "Time Remain:  " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }


    public int IncreasePoints(float timeValue)
    { 
        SinglePlayerMovement.points += getTimeScore(timeValue) + SinglePlayerMovement.levelNumber;
        SinglePlayerMovement.levelNumber++;

        return SinglePlayerMovement.points;
    }

    public int getPoints()
    {
        return SinglePlayerMovement.points;
    }

    public int getLevel()
    {
        return SinglePlayerMovement.levelNumber;
    }

    public int getTimeScore(float curentTime)
    {
        if(curentTime < 0)
        {
            curentTime = 0;
        }

        float minutes = Mathf.FloorToInt(curentTime / 60);
        float seconds = Mathf.FloorToInt(curentTime % 60);

        int intMinutes = (int)minutes;
        int intSeconds = (int)seconds;

        return intMinutes*3+((60*intMinutes)+intSeconds)*2;
    }

    public string UpdateRecord()
    {
        int maxPoints = PlayerPrefs.GetInt("Max", 0);
        int currentPoints = getPoints();
        
        if(currentPoints > maxPoints)
        {
            maxPoints = currentPoints;
            PlayerPrefs.SetInt("Max", maxPoints);
        }

        return maxPoints.ToString();
    }
}
