using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DyingZone")
        {
            Destroy(gameObject);
            LevelManager.instance.Respawn();
        }
    }
}
