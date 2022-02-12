using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM_GoToMenu : MonoBehaviour
{
    private GameManager_Master gm_master;

    void OnEnable()
    {
        SetInitial();
        gm_master.GoToMenuSceneEvent += GoToMenuScene;
    }

    void OnDisable()
    {
        gm_master.GoToMenuSceneEvent -= GoToMenuScene;
    }

    void SetInitial()
    {
        gm_master = GetComponent<GameManager_Master>();
    }

    void GoToMenuScene()
    {
        SceneManager.LoadScene(0);
    }
}
