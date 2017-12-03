using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            print("GOING RIGHT!");
            rb.AddRelativeForce(transform.right * thrust);
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            print("GOING LEFT!");
            rb.AddRelativeForce((transform.right * -1) * thrust);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            print("FULL SPEED!");
            rb.AddRelativeForce(transform.forward * thrust);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            print("HOP BACKWARD!");
            rb.AddRelativeForce((transform.forward * -1) * thrust);
        }
    }
}