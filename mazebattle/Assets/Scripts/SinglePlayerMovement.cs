using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SinglePlayerMovement : MonoBehaviour
{

    public float movementSpeed = 3f;
    public Rigidbody2D rigidBody1;

    public Text timeText;
    public Text pointText;

    public GameObject nextLevelPanel;

    public float timeValue;
    public static int points = 0;
    public static int levelNumber = 1;

    public static bool isNotFirstGame = false;

    Vector2 movement;
    void Start()
    {
        //initial position
        //in the center of maze
        rigidBody1.MovePosition(new Vector2(0f, -0.5f));
        timeValue = 80;
        nextLevelPanel.SetActive(false);
        if(!isNotFirstGame)
        {
            points = 0;
            levelNumber = 1;
        }
        pointText.text = "Points: " +  ScoreManager.current.getPoints();
    }

    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }else 
        {
            GameManager_Master.current.CallEventGameOver();
        }
        

        timeText.text = ScoreManager.current.getStringTime(timeValue);
    }

    void FixedUpdate()
    {
        //Updating player position
        rigidBody1.MovePosition(rigidBody1.position + movement * movementSpeed * Time.deltaTime);
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        Debug.Log("You Win!");
        PauseMenu.isGameOver = true;
        Time.timeScale = 0;
        pointText.text = "Points: " +  ScoreManager.current.IncreasePoints(timeValue);
        LoadNextLevel();
    }

    private void LoadNextLevel()
    {
        float now = Time.deltaTime + 5;
        isNotFirstGame = true;
        nextLevelPanel.SetActive(true);

       

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
