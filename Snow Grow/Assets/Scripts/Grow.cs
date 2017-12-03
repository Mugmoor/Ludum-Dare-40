using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{

    public Transform player;                // Reference to player's transform data.

    private bool isGrounded = false;
    public Vector3 currentScale;            // The player's current scale.
    public float scaleRate = 0.02f;          // The rate at which to increase size.


    void LateUpdate()
    {
        if (isGrounded == true)
        {
            player.localScale += new Vector3(scaleRate, scaleRate, scaleRate);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        print("grounded.");
    }

    void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
        print("weeeee");
    }
}
