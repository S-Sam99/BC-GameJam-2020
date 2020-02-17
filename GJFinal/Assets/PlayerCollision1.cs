using UnityEngine;


public class PlayerCollision1 : MonoBehaviour
{
    public PlayerMovement1 movement;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {

            movement.enabled = false;
            FindObjectOfType<Manager>().EndGame();
        }
    }

}