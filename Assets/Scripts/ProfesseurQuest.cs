        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfesseurQuest : MonoBehaviour
{
    public int i;
    //public GameObject entrainementFini;
    public bool isDansLaZone = false;
    public bool petite;


    public void Start()
    {
        i = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isDansLaZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isDansLaZone = false;
            i = 0;
            Debug.Log("Je quitte la zone");
        }
    }


    private void Update()
    {
        if (isDansLaZone == true)
        {
            Debug.Log("Je suis dans la zone");
            IsDansLaZone();

        }
    }

    void IsDansLaZone()
    {
        if (PlayerController.pcInstance.isJumping == true && petite == false)
        {
            Debug.Log("Je saute");
            petite = true;

            if (i < 3)
            {
                i += 1;
                Debug.Log("ON S'ENTRAINE");
                Debug.Log(i);
            }

            if (i == 3)
            {
                // Set active la cinématique
                Debug.Log("EXPERIENCE FINI");
                LevelManager.instance.pieces += 1;
                Debug.Log(LevelManager.instance.pieces);

            }


        }

        else if (PlayerController.pcInstance.isJumping == false && petite == true)
        {
            petite = false;
        }
    }
}
