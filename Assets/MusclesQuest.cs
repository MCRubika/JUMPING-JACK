using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MusclesQuest : MonoBehaviour
{
    public int i;
    //public GameObject entrainementFini;
    public bool isDansLaZone = false;

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
            IsDansLaZone();
        }
    }

    void IsDansLaZone()
    {
        if (PlayerController.pcInstance.isJumping == true)
        {
            if (i < 3)
            {
                i += 1;
                Debug.Log("ON S'ENTRAINE");
                Debug.Log(i);
            }
            else
            {
               // entrainementFini.SetActive(true);
                Debug.Log("ENTRAINEMENT FINI");
            }
        }
    }
}
