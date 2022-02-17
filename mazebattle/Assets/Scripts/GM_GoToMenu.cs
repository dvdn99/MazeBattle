using UnityEngine;
using UnityEngine.SceneManagement;
   
public class GM_GoToMenu : MonoBehaviour
{
    private void Start() {
        GameManager_Master.current.GoToMenuSceneEvent += GoToMenuScene;
    }

    void GoToMenuScene()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
