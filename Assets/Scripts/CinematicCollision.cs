using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CinematicCollision : MonoBehaviour
{
    public PlayableDirector timeline;
    public int i = 0;
    public GameObject Collider;

    private void Start()
    {
        timeline = GetComponent<PlayableDirector>();
        i = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if( i == 0)
            {
                timeline.Play();
                i++;
            }
            else 
            {
                Collider.SetActive(false);
            }
        }
    }
}
