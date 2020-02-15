/* Using Libraries */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *   Filename: PlayerMovement.cs
 *   Contributor: Matt Fung
 *   Date: February 14, 2020
*/
public class PlayerMovement : MonoBehaviour
{
    /* Define Instance Fields */
    public Rigidbody PlayerRigidBody;
    public float forwardForce = 200f;
    public float sidewaysForce = 500f;

    /**
        Start is called before the first frame update
        void Start()
        {
            // Debug.Log("Testing");
            // PlayerRigidBody.useGravity = false;
            PlayerRigidBody.AddForce(0, 200, 500);          // 0 force in x-dir, 200 force in y-dir, 500 in z-dir
        }
    */

    /**
     * Function: FixedUpdate()
     * Purpose: Player Movement is updated during each fixed frame
     *          This allows smoother animation between frames
     *          May have noticeable differences on different machines
     */
    void FixedUpdate()
    {
        // Adding forward force
        PlayerRigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);       // Adjusts framerate of player movement

        // Keypress to move player to the right
        if (Input.GetKey("d"))
        {
            PlayerRigidBody.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        // Keypress to move player to the left
        if (Input.GetKey("a"))
        {
            PlayerRigidBody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
