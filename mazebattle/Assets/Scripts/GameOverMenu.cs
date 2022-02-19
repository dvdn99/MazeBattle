using UnityEngine;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{

    public Text recordText;
    public Text myScoreText;

    private void Start() {
        recordText.text = "Record: " + getRecord();
        myScoreText.text = "Your Score: " + getMyScore();
        AudioManager.Instance.PlayGameOver();
    }
    public void GoMain()
    {
        GameManager_Master.current.CallEventGoToMenuScene();
    }

    public string getRecord()
    {
        return ScoreManager.current.UpdateRecord();
    }

    public string getMyScore()
    {
        int points = SinglePlayerMovement.points;
        SinglePlayerMovement.points = 0;
        return points.ToString();
    }

    public void ExitGame()
    {
        //will exit game when app is finished
        Application.Quit();
        Debug.Log("Quit");
    }
}
