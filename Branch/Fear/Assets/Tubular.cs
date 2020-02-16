using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubular : MonoBehaviour
{
  public float spin = 5f;
  // Update is called once per frame
  void Update()
  {

      if (Input.GetKey(KeyCode.RightArrow))
      {
         transform.Rotate(new Vector3(0,0,-spin));
      }

      if (Input.GetKey(KeyCode.LeftArrow))
      {
         transform.Rotate(new Vector3(0,0,spin));
      }

  }
}
