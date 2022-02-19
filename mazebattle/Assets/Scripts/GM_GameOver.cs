using UnityEngine;
using UnityEngine.SceneManagement;

public class GM_GameOver : MonoBehaviour
{
    private void Start() 
    {
        GameManager_Master.current.GameOverEvent += EndGame;
        GameManager_Master.current.GO_MultiEvent += FinishGame;
    }
    void EndGame()
    {
      SceneManager.LoadScene("GameOverScene");  
    }

    void FinishGame()
    {
      SceneManager.LoadScene("GO_MultiScene");  
    }
}
