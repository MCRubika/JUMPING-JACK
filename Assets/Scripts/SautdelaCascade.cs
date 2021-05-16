using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SautdelaCascade : MonoBehaviour
{
    bool isZone = false;
    public GameObject Cascade;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isZone = true;
            Debug.Log("Take me !");
        }
    }

    void Update()
    {
        if (isZone == true)
        {
            TakeOnMe();
        }
    }

    void TakeOnMe()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("je prends l'objet");
            LevelManager.instance.sautDansLeVide += 1;
            Debug.Log("J'ai pris l'objet");
            Destroy(Cascade);
            Destroy(this);
        }
    }
}
