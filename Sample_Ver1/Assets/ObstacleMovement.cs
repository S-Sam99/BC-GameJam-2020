/* Using Libraries */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *   Filename: ObstacleMovement.cs
 *   Contributor: Matt Fung
 *   Date: February 15, 2020
*/
public class ObstacleMovement : MonoBehaviour
{
    /* Define Instance Fields */
    private bool directionRight = true;
    public float obstacleSpeed = 2.0f;

    /**
     * Function: ObstacleMovement()
     * Purpose: Allows obstacles to have its own movement
     */
    void FixedUpdate()
    {
        // Set the speed based on the current direction
        if (directionRight)
            transform.Translate(Vector2.right * obstacleSpeed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * obstacleSpeed * Time.deltaTime);

        // Once the obstacle reaches the right side, change direction
        if (transform.position.x > 5.5f)
        {
            directionRight = false;
        }

        // Once the obstacle reaches the left side, change direction
        if (transform.position.x < -7.0f)
        {
            directionRight = true;
        }
    }
}
