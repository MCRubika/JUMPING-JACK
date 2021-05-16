using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MusclesQuest : MonoBehaviour
{
    public int i;
    //public GameObject entrainementFini;
    public bool isDansLaZone = false;
    public bool petite;

    public GameObject panneauA;
    public GameObject panneauB;
    public GameObject panneauC;
    

    public void Start()
    {
        i = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isDansLaZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isDansLaZone = false;
        }
    }


    private void Update()
    {
        if(isDansLaZone == true)
        {
            Debug.Log("Je suis dans la zone");
            IsDansLaZone();
            
        }

        if (i == 1)
        {
            panneauA.SetActive(true);
            panneauB.SetActive(false);
            panneauC.SetActive(false);
        }

        if (i == 2)
        {
            panneauA.SetActive(false);
            panneauB.SetActive(true);
            panneauC.SetActive(false);
        }

        if (i == 3)
        {
            panneauA.SetActive(false);
            panneauB.SetActive(false);
            panneauC.SetActive(true);
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

            if (i ==3)
            {
               // Set Active la cinématique
                Debug.Log("ENTRAINEMENT FINI");
                LevelManager.instance.augmentationSauts += 1;
                
            }

            
        }

        else if (PlayerController.pcInstance.isJumping == false && petite == true)
        {
            petite = false;
        }
    }
}
