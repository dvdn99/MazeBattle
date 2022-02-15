using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuPanel;
    public GameObject optionsPanel;
 

    private void Start() {
        pauseMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
    }
    public void PlayGame()
    {
        pauseMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
    }

    public void OptionsPanel()
    {
        //go to option panel menu
        if(optionsPanel != null && pauseMenuPanel != null)
        {
            optionsPanel.SetActive(true);
            pauseMenuPanel.SetActive(false);
        }
    }

    public void BackPauseMenu()
    {
        if(optionsPanel != null && pauseMenuPanel != null)
        {
            pauseMenuPanel.SetActive(true);
            optionsPanel.SetActive(false);
        }
    }

    public void ExitGame()
    {
        //will exit game when app is finished
        Application.Quit();
    }
}
