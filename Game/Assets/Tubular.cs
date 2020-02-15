using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubular : MonoBehaviour
{
    public float MoveZ = 1f;
    public GameObject go;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= 250) { 
        go.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + MoveZ);
    }
    }
}
