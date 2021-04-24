using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogSystem : MonoBehaviour
{
    public GameObject dialog;
    public GameObject button;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            button.SetActive(true);
            dialog.SetActive(true);

        }
        else
        {
            button.SetActive(false);
            dialog.SetActive(false);
        }
    }
}
