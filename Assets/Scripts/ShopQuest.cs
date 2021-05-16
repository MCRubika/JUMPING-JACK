using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopQuest : MonoBehaviour
{
    public GameObject LegsPlayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && LevelManager.instance.pieces >= 3)
        {
            LevelManager.instance.playerPrefab = LegsPlayer;
        }
    }
}
