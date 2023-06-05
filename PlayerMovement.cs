using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    public Rigidbody rb;

    public float ForwardForce = 1000f;
    public float SidewaysForce = 100f;


    // We marked this as "FixedUpdate" because we are using it to mesh with physics...
    void FixedUpdate() {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) {
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}