using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnfantApprentissageSaut : MonoBehaviour
{
    int i;

    private void Start()
    {
        i = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (i == 0)
        {
            if (collision.tag == "Player")
            {
                LevelManager.instance.augmentationSauts += 2;
                i++;
                Debug.Log(LevelManager.instance.augmentationSauts);
            }
        }
    }
}
