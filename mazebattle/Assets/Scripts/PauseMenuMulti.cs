
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PauseMenuMulti : MonoBehaviour
{
    public GameObject pauseMenuPanel;
    public GameObject optionsPanel;

    public GameObject nextLevelPanel;
    
    public GameObject infoPanel;
    public GameObject inventoryPanel;
    public GameObject separation;

    public Text round;

    public Text muteButton;

    bool isMuted = false;
    private bool isPaused;
    public static bool isGameOver;
    public static int numberOfLevel = 0;
    public static bool isNotFirstGame = false;
    public static int winner = 0;

    private void Start() {
        pauseMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        infoPanel.SetActive(false);
        inventoryPanel.SetActive(true);
        separation.SetActive(true);
        nextLevelPanel.SetActive(false);
        isPaused = false;
        isGameOver = false;
        Time.timeScale = 1;
        if(!isNotFirstGame)
        {
            winner = 0;
            numberOfLevel = 1;
        }else
        {
            numberOfLevel++;
        }
        
        round.text = "Round #: " + numberOfLevel.ToString();
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
        Mute();
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
        if(Input.GetKeyDown("escape") && !isPaused && !isGameOver){
            isPaused = !isPaused;
            ShowPauseMenu();
        }else if(Input.GetKeyDown("escape") && !isGameOver){
            isPaused = !isPaused;
            PlayGame();
        }
    }

    public void LoadNextLevel(int player)
    {
        isNotFirstGame = true;
        nextLevelPanel.SetActive(true);
        Time.timeScale = 0;
        
        if(player == 1)
        {
            if(PlayerOneMovement.victories == 2)
            {
                winner = 1;
                Debug.Log(PlayerOneMovement.victories);
                Debug.Log(winner);
                GameManager_Master.current.CallEventGOMulti();
            }
        }else if(player == 2)
        {
            if(PlayerTwoMovement.victories == 2)
            {
                winner = 2;
                GameManager_Master.current.CallEventGOMulti();
            }
        }

        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    public void Mute()
    {
        if(!isMuted){
            AudioManager.Instance.Mute();
            isMuted = !isMuted;
            muteButton.text = "PLAY";
        }else
        {
            AudioManager.Instance.ContinueMusic();
            isMuted = !isMuted;
            muteButton.text = "MUTE";
        }
        
    }
    public void ExitGame()
    {
        //will exit game when app is finished
        Application.Quit();
        Debug.Log("Quit");
    }
}