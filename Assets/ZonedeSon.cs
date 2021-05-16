using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonedeSon : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            AudioManager.instance.musique.Stop(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            AudioManager.instance.musique.Post(gameObject);
        }
    }
}
