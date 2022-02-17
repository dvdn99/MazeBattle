using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{

    public float movementSpeed = 3f;
    public Rigidbody2D rigidBody2;

    Vector2 movement;
    void Start()
    {
        //initial position
        //in the center of maze
        rigidBody2.MovePosition(new Vector2(0f, 0f));

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
    }
}
