using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float spin = 30f;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;

        if (Input.GetKey("d"))
        {
           transform.Rotate(0, 0, -spin * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
           transform.Rotate(0, 0, spin * Time.deltaTime);

        }

    }

}
