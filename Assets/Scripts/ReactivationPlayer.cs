using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactivationPlayer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //if (//Le blabla avec le fermier est = 0 alors)
            PlayerController.pcInstance.RestaurePlayerController();
        }
    }
}
