using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
    void Update()
    {
        Vector3 position = transform.position;
        position.x = Player.transform.position.x;
        position.y = Player.transform.position.y;
        transform.position = position;
    }

}