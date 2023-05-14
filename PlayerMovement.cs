using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    public Rigidbody rb;

    public float ForwardForce = 1000f;
    public float SidewaysForce = 2000f;


    // We marked this as "FixedUpdate" because we are using it to mesh with physics...
    void Update() {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}