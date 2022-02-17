
using UnityEngine;

public class PauseMenuMulti : MonoBehaviour
{
    public GameObject pauseMenuPanel;
    public GameObject optionsPanel;

    
    public GameObject infoPanel;
    public GameObject inventoryPanel;
    public GameObject separation;

    private bool isPaused;

    private void Start() {
        pauseMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        infoPanel.SetActive(false);
        inventoryPanel.SetActive(true);
        separation.SetActive(true);
        isPaused = false;
        Time.timeScale = 1;
    }
    public void PlayGame()
    {
        pauseMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        infoPanel.SetActive(false);
        inventoryPanel.SetActive(true);
        separation.SetActive(true);
        Time.timeScale = 1;
    }

    public void GoMain(){
        GameManager_Master.current.CallEventGoToMenuScene();
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
            separation.SetActive(false);
        }
    }

    public void ShowInfo()
    {
        pauseMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        infoPanel.SetActive(true);
        inventoryPanel.SetActive(false);
        separation.SetActive(false);
    }

    public void BackOptions()
    {
        pauseMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);
        infoPanel.SetActive(false);
        inventoryPanel.SetActive(false);
        separation.SetActive(false);
    }

    public void BackPauseMenu()
    {
        if(optionsPanel != null && pauseMenuPanel != null)
        {
            pauseMenuPanel.SetActive(true);
            optionsPanel.SetActive(false);
            infoPanel.SetActive(false);
            inventoryPanel.SetActive(false);
            separation.SetActive(false);
        }
    }
    public void ShowPauseMenu()
    {
        Time.timeScale = 0;
        optionsPanel.SetActive(false);
        pauseMenuPanel.SetActive(true);
        infoPanel.SetActive(false);
        inventoryPanel.SetActive(false);
        separation.SetActive(false);
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