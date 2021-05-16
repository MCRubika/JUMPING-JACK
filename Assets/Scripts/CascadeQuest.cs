using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CascadeQuest : MonoBehaviour
{
    public int asauter;


    private void Start()
    {
        asauter = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (asauter == 0)
        {
            if (collision.tag == "Player")
            {
                asauter += 1;
            }
        }

        if (asauter == 1)
        {
            LevelManager.instance.pieces += 1;
            Debug.Log(LevelManager.instance.pieces);
        }
    }
}
