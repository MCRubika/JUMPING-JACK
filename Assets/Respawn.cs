using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public static Respawn rInstance;
    public GameObject playerToRespawn;
    public GameObject playerToDestroy;
    public bool playerIsDead = false;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(playerToDestroy);
            Instantiate(playerToRespawn, transform.position, playerToRespawn.transform.rotation);
            playerIsDead = true;
        }
    }
}
