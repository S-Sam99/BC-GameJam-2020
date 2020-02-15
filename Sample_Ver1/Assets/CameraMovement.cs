/* Using Libraries */
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

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
