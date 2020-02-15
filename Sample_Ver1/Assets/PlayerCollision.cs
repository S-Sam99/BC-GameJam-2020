/* Using Libraries */
using UnityEngine;

/**
 *   Filename: PlayerCollision.cs
 *   Contributor: Matt Fung
 *   Date: February 15, 2020
*/
public class PlayerCollision : MonoBehaviour
{
    /* Define Instance Fields */
    public PlayerMovement flagPlayerMovement;

    /**
     * Function: OnCollisionEnter()
     * Purpose: Prevents the player from continuing to move
                after a collision with an obstacle
     */
    void OnCollisionEnter(Collision collisionInfo)
    {
        // Trigger only when player collides with an obstacle
        if (collisionInfo.collider.tag == "Obstacle")
        {
            /* Debugging purposes only */
            Debug.Log(collisionInfo.collider.name);
            
            // Disable player movement upon collision
            flagPlayerMovement.enabled = false;
        }
    }
}
