using System.Collections;
using UnityEngine;

public class GM_PauseToggle : MonoBehaviour
{
    private GameManager_Master gm_master;
    private bool isPaused;
    void OnEnable()
    {
        SetInitialState();
        gm_master.MenuToggleEvent += TogglePause;
    }

    void OnDisable() 
    {
        gm_master.MenuToggleEvent -= TogglePause;
    }

    void SetInitialState()
    {
        gm_master = GetComponent<GameManager_Master>();
    }

    void TogglePause()
    {
        if(isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}
