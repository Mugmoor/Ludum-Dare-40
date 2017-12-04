using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grow : MonoBehaviour
{
    public Text text;                       // Reference to "Score" Textbox.
    public Transform player;                // Reference to player's transform data.

    private bool isGrounded = false;
    public Vector3 currentScale;            // The player's current scale.
    public float scaleRate = 0.02f;         // The rate at which to increase size.

    int score;                              // Holds the player's score, and sends it to the "Score" Textbox. 


    void LateUpdate()
    {
        if (isGrounded == true)
        {
            player.localScale += new Vector3(scaleRate, scaleRate, scaleRate);
            score = (int)player.localScale.x * 10;
            text.text = score.ToString();
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
