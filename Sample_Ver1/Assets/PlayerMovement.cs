using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;

    public float ForwardMovement = 2000f;
    public float SideMovement = 200f;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, ForwardMovement * Time.deltaTime);

        if (Input.GetKey("d")){
           rb.AddForce(SideMovement, 0, 0);
        }

        if (Input.GetKey("a")){
            rb.AddForce(-SideMovement, 0, 0);
        }
    }
}
