using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float spin = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
       // transform.Rotate(0, 0, -spin * Time.deltaTime);

    }

}
