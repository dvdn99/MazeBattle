using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;
    public GameObject playPanel;
    public GameObject infoPanel;
    public Text muteButton;

    public bool isMuted = false;

    private void Start() {
        mainMenuPanel.SetActive(true);
        playPanel.SetActive(false);
        optionsPanel.SetActive(false);
        infoPanel.SetActive(false);
    }
    public void PlayGame()
    {
        mainMenuPanel.SetActive(false);
        playPanel.SetActive(true);
        optionsPanel.SetActive(false);
    }

    public void ShowInfo()
    {
        if(optionsPanel != null && mainMenuPanel != null && playPanel != null)
        {
            optionsPanel.SetActive(false);
            mainMenuPanel.SetActive(false);
            playPanel.SetActive(false);
            infoPanel.SetActive(true);
        }
    }

    public void OptionsPanel()
    {
        //go to option panel menu
        if(optionsPanel != null && mainMenuPanel != null && playPanel != null)
        {
            optionsPanel.SetActive(true);
            mainMenuPanel.SetActive(false);
            playPanel.SetActive(false);
            infoPanel.SetActive(false);
        }
    }

    public void BackOptionPanel()
    {
        if(optionsPanel != null && mainMenuPanel != null && playPanel != null)
        {
            mainMenuPanel.SetActive(false);
            playPanel.SetActive(false);
            optionsPanel.SetActive(true);
            infoPanel.SetActive(false);
        }

    }

    public void BackMainMenu()
    {
        if(optionsPanel != null && mainMenuPanel != null && playPanel != null)
        {
            mainMenuPanel.SetActive(true);
            playPanel.SetActive(false);
            optionsPanel.SetActive(false);
            infoPanel.SetActive(false);
        }
    }

    public void Mute()
    {
        if(!isMuted){
            AudioManager.Instance.Mute();
            isMuted = !isMuted;
            muteButton.text = "PLAY";
        }else
        {
            AudioManager.Instance.ContinueIntro();
            isMuted = !isMuted;
            muteButton.text = "MUTE";
        }
        
    }

    public void PlaySingle()
    {
        SceneManager.LoadScene("SinglePlayer");
        SinglePlayerMovement.isNotFirstGame = false;
        AudioManager.Instance.PlayMusic();
    }

    public void PlayMulti()
    {
        SceneManager.LoadScene("MultiPlayer");
        PauseMenuMulti.isNotFirstGame = false;
        AudioManager.Instance.PlayMusic();
    }

    public void ExitGame()
    {
        //will exit game when app is finished
        Application.Quit();
        Debug.Log("Quit");
    }
}
