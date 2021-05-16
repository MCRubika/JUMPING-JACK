using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poules : MonoBehaviour
{
    bool isZone = false;
    public GameObject Poule;

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
            LevelManager.instance.poules+= 1;
            Debug.Log("J'ai pris l'objet");
            Destroy(Poule);
            Destroy(this);
        }
    }
}
