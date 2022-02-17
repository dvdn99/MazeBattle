using UnityEngine;

public class SinglePlayerMovement : MonoBehaviour
{

    public float movementSpeed = 3f;
    public Rigidbody2D rigidBody1;

    Vector2 movement;
    void Start()
    {
        //initial position
        //in the center of maze
        rigidBody1.MovePosition(new Vector2(0f, -0.5f));

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
        Debug.Log("You Win!");
    }

}
