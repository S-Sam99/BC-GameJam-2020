using UnityEngine;

public class PlayerMovement3 : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public float ForwardMovement = 6000f;

    void Update()
    {
        rb.AddForce(0, 0, ForwardMovement * Time.deltaTime);
    }




}