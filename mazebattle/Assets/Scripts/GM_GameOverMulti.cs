using UnityEngine;
using UnityEngine.SceneManagement;

public class GM_GameOverMulti : MonoBehaviour
{
    private void Start() 
    {
        GameManager_Master.current.GO_MultiEvent += FinishGame;
    }
    
    void FinishGame()
    {
      SceneManager.LoadScene("GO_MultiScene");  
    }

}
