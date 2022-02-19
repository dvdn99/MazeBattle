using UnityEngine;
using UnityEngine.UI;

public class PlayerOneMovement : MonoBehaviour
{

    public float movementSpeed = 3f;
    public Rigidbody2D rigidBody1;
    public Text textVictory;

    public GameObject pauseMenu;

    public static int victories;

    Vector2 movement;
    void Start()
    {
        //initial position
        //in the center of maze
        rigidBody1.MovePosition(new Vector2(0f, -0.5f));
        if(!PauseMenuMulti.isNotFirstGame)
        {
            PlayerOneMovement.victories = 0;
        }
        textVictory.text = "Player 1: " + PlayerOneMovement.victories.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        //Debug.Log(Input.GetAxisRaw("Horizontal2"));
        movement.y = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    {
        //Updating player position
        rigidBody1.MovePosition(rigidBody1.position + movement * movementSpeed * Time.deltaTime);
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        Debug.Log("Player 1");
        PlayerOneMovement.victories += 1;
        pauseMenu.GetComponent<PauseMenuMulti>().LoadNextLevel(1);
    }


}
