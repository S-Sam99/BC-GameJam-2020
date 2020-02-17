using UnityEngine;


public class PlayerCollision3 : MonoBehaviour
{
    public PlayerMovement3 movement;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {

            movement.enabled = false;
            FindObjectOfType<Manager>().EndGame();
        }
    }

}