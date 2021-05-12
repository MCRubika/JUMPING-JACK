using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescenteRapide : MonoBehaviour
{
    public int i = 0;
    public GameObject descenteRapide;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (i == 0)
            {
                Debug.Log("On descends vite !");
                PlayerController.pcInstance.rb.gravityScale = 50;
                Debug.Log("ça fonctionne");
                i += 1;
            }

            if (i >= 1)
            {
                descenteRapide.SetActive(false);
            }
        }
    }
}
