using UnityEngine;


public class PlayerCollision2 : MonoBehaviour
{
    public PlayerMovement2 movement;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {

            movement.enabled = false;
            FindObjectOfType<Manager>().EndGame();
        }
    }

}