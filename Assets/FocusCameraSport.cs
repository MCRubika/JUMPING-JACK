using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FocusCameraSport : MonoBehaviour
{
    public GameObject normal;
    public GameObject sport;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            normal.SetActive(false);
            sport.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            normal.SetActive(true);
            sport.SetActive(false);
        }
    }
}
