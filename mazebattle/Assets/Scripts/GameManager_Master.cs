using System;
using UnityEngine;

    
public class GameManager_Master : MonoBehaviour
{
    public static GameManager_Master current; 
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
    
    public event Action PauseMenuEvent;
    public event Action GoToMenuSceneEvent;
    public event Action GameOverEvent;


    private bool isGameOver;
    private bool isGamePaused;

    public void CallEventPauseMenu()
    {
        if(PauseMenuEvent != null)
        {
            PauseMenuEvent();
        }
    }


    public void CallEventGoToMenuScene()
    {
        if(GoToMenuSceneEvent != null)
        {
            GoToMenuSceneEvent();
        }
    }

    public void CallEventGameOver()
    {
        if(GameOverEvent != null)
        {
            isGameOver = true;
            GameOverEvent();
        }
    }
}
