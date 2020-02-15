﻿/* Using Libraries */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *   Filename: CameraMovement.cs
 *   Contributor: Matt Fung
 *   Date: February 15, 2020
*/
public class CameraMovement : MonoBehaviour
{
    /* Define Instance Fields */
    public Transform player;
    public Vector3 offset;
    public float rotationSpeed = 5.0f;
    float direction;

    /**
     * Function: FixedUpdate()
     * Purpose: Camera Movement is updated during each fixed frame
     *          Camera follows the player to mimic a first person view
     *          May have noticeable differences on different machines
     */
    void FixedUpdate()
    {
        // Place camera slightly behind the player and follow the player
        transform.position = player.position + offset;

        // Rotates counter-clockwise
        if ((Input.GetKeyDown("j")))
            direction += -10;
        // Rotates clockwise
        if ((Input.GetKeyDown("l")))
            direction += 10;

        // if (direction >= 50 || direction <= -50)
        //     direction = 0;

        // Updates rotation
        transform.Rotate(0, 0, direction * Time.deltaTime, Space.Self);
    }
}