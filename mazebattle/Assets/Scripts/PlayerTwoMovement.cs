using UnityEngine;
using UnityEngine.UI;

public class PlayerTwoMovement : MonoBehaviour
{

    public float movementSpeed = 3f;
    public Text textVictory;
    public Rigidbody2D rigidBody2;
    public GameObject pauseMenu;

    public static int victories;

    Vector2 movement;
    void Start()
    {
        //initial position
        //in the center of maze
        rigidBody2.MovePosition(new Vector2(0f, 0f));
        if(!PauseMenuMulti.isNotFirstGame)
        {
            PlayerTwoMovement.victories = 0;
        }
        textVictory.text = "Player 2: " + PlayerTwoMovement.victories.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal2");
        //Debug.Log(Input.GetAxisRaw("Horizontal2"));
        movement.y = Input.GetAxisRaw("Vertical2");

    }

    void FixedUpdate()
    {
        //Updating player position
        rigidBody2.MovePosition(rigidBody2.position + movement * movementSpeed * Time.deltaTime);
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        Debug.Log("Player 2");
        PlayerTwoMovement.victories += 1;
        pauseMenu.GetComponent<PauseMenuMulti>().LoadNextLevel(2);
    }
}
