using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuPanel;
    public GameObject optionsPanel;

    public GameObject inventoryPanel;
    public GameObject infoPanel;

   
    private bool isPaused;
 

    private void Start() {
        pauseMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        infoPanel.SetActive(false);
        inventoryPanel.SetActive(true);
        isPaused = false;
        Time.timeScale = 1;
    }

    public void GoMain(){
        GameManager_Master.current.CallEventGoToMenuScene();
    }

    public void ShowPauseMenu()
    {
        Time.timeScale = 0;
        pauseMenuPanel.SetActive(true);
        optionsPanel.SetActive(false);
        infoPanel.SetActive(false);
        inventoryPanel.SetActive(false);
    }
    public void PlayGame()
    {
        pauseMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        infoPanel.SetActive(false);
        inventoryPanel.SetActive(true);
        Time.timeScale = 1;
    }

    public void OptionsPanel()
    {
        //go to option panel menu
        if(optionsPanel != null && pauseMenuPanel != null)
        {
            optionsPanel.SetActive(true);
            pauseMenuPanel.SetActive(false);
            infoPanel.SetActive(false);
            inventoryPanel.SetActive(false);
        }
    }

    public void ShowInfo()
    {
        pauseMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        infoPanel.SetActive(true);
        inventoryPanel.SetActive(false);
    }

    public void BackOptions()
    {
        pauseMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);
        infoPanel.SetActive(false);
        inventoryPanel.SetActive(false);
    }

    public void BackPauseMenu()
    {
        if(optionsPanel != null && pauseMenuPanel != null)
        {
            pauseMenuPanel.SetActive(true);
            optionsPanel.SetActive(false);
            infoPanel.SetActive(false);
            inventoryPanel.SetActive(false);
        }
    }

    private void Update() {
        if(Input.GetKeyDown("escape") && !isPaused){
            isPaused = !isPaused;
            ShowPauseMenu();
        }else if(Input.GetKeyDown("escape")){
            isPaused = !isPaused;
            PlayGame();
        }
    }

    public void ExitGame()
    {
        //will exit game when app is finished
        Application.Quit();
        Debug.Log("Quit");
    }
}
