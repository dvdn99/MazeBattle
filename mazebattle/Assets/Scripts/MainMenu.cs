using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;
    public GameObject playPanel;

    private void Start() {
        mainMenuPanel.SetActive(true);
        playPanel.SetActive(false);
        optionsPanel.SetActive(false);
    }
    public void PlayGame()
    {
        mainMenuPanel.SetActive(false);
        playPanel.SetActive(true);
        optionsPanel.SetActive(false);
    }

    public void OptionsPanel()
    {
        //go to option panel menu
        if(optionsPanel != null && mainMenuPanel != null && playPanel != null)
        {
            optionsPanel.SetActive(true);
            mainMenuPanel.SetActive(false);
        }
    }

    public void BackMainMenu()
    {
        if(optionsPanel != null && mainMenuPanel != null && playPanel != null)
        {
            mainMenuPanel.SetActive(true);
            playPanel.SetActive(false);
            optionsPanel.SetActive(false);
        }
    }

    public void PlaySingle()
    {
        SceneManager.LoadScene("SinglePlayer");
    }

    public void PlayMulti()
    {
        SceneManager.LoadScene("MultiPlayer");
    }

    public void ExitGame()
    {
        //will exit game when app is finished
        Application.Quit();
    }
}
