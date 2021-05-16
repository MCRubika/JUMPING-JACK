using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnfantBallon : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && LevelManager.instance.jouet == 1)
        {
            LevelManager.instance.pieces += 1;
            Debug.Log(LevelManager.instance.pieces);
            LevelManager.instance.jouet -= 1;
        }
    }
}
