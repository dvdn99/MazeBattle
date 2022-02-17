using UnityEngine;
using UnityEngine.SceneManagement;

public class Immortalizer : MonoBehaviour
{
    private void Awake() 
    {
        DontDestroyOnLoad(this.gameObject);

    }

}
