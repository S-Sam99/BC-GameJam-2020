using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public float ForwardMovement = 10000f;
    public float sidewaysForce = 500f;


    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, ForwardMovement * Time.deltaTime);
      
    }
}
