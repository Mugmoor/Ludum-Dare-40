using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOver : MonoBehaviour
{
    public Canvas myCanvas;

    void OnTriggerEnter(Collider collider)
    {
        myCanvas.enabled = true;
    }
}