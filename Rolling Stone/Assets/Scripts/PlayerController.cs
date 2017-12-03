using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;
    public Transform start;
    public Transform player;
    Vector3 startScale;
    float startDistance;
    public float scaleSpeed = 0.5f;

    void Start()
    {
        startDistance = Vector3.Distance(start.transform.position, transform.position);
        startScale = transform.localScale;
    }

    private void Update()
    {
        float curDistance = Vector3.Distance(start.transform.position, transform.position) - startDistance;
         
    }

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
    } // Controls here.
}