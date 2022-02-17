using UnityEngine;
using UnityEngine.SceneManagement;

public class GM_GameOver : MonoBehaviour
{
    private void Start() 
    {
        GameManager_Master.current.GameOverEvent += EndGame;
    }
    void EndGame()
    {
      SceneManager.LoadScene("GameOverScene");   
    }
}
