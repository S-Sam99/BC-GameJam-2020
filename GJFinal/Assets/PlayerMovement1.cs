using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public float ForwardMovement = 3000f;
    public float maxSpeed;
    public float sidewaysForce = 500f;

    void Start()
    {
        maxSpeed = ForwardMovement * Time.deltaTime + 200;

    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude <= ForwardMovement * Time.deltaTime)
        {
            rb.AddForce(0, 0, ForwardMovement * Time.deltaTime);
        }

    }


}


