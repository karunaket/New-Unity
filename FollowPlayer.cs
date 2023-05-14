using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        /* 
         * offset --> vector3 = (0, 1, -5) and the camera position is vector3 = (0, 2.42, -6.17)
         * So
         * camera position = vector3 (0 + 0 = 0, 1 + 2.42 = 3.42, -5 + (-6.17) = -11.17)
         */
    }
}
