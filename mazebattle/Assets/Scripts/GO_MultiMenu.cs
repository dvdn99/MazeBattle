using UnityEngine;
using UnityEngine.UI;

public class GO_MultiMenu : MonoBehaviour
{

    public Text winnerPlayer;


    private void Start() {
        winnerPlayer.text = getWinner();
        AudioManager.Instance.PlayGameOver();
    }
    public void GoMain()
    {
        GameManager_Master.current.CallEventGoToMenuScene();
    }

    public string getWinner()
    {
        int winner = PauseMenuMulti.winner;
        PauseMenuMulti.winner = 0;
        PlayerOneMovement.victories = 0;
        PlayerTwoMovement.victories = 0;
        return winner.ToString();
    }

    public void ExitGame()
    {
        //will exit game when app is finished
        Application.Quit();
        Debug.Log("Quit");
    }
}
