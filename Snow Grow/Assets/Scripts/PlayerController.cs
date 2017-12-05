using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float lateralThrust;
    public float forwardThrust = 10f;
    public Rigidbody rb;
    public float maxSpeed = 200f;

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            print("GOING RIGHT!");
            rb.AddRelativeForce(transform.right * lateralThrust);
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            print("GOING LEFT!");
            rb.AddRelativeForce((transform.right * -1) * lateralThrust);
        }

        rb.AddForce((transform.position.z * new Vector3(0f, 0f, forwardThrust)) * Time.deltaTime) ;

        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
}