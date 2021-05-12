using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegBehavior : MonoBehaviour
{
    public Transform target;
    public bool canMove;
    public float distanceBetween;
    public float speed;

    public Transform piedsplie;
    public bool isplie;

    public void Update()
    {
        if(canMove == false)
        {
            if(Vector2.Distance(target.transform.position, transform.position) >= distanceBetween)
            {
                canMove = true;
                isplie = false;
            }
        }

        else //canMove est true ici
        {
            if (isplie == false)
            {
                transform.position = Vector2.MoveTowards(transform.position, piedsplie.transform.position, speed * Time.deltaTime);

                if (Vector2.Distance(piedsplie.transform.position, transform.position) < 0.5f)
                {
                    isplie = true;
                }
            }

            else
            {
                transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

                if (Vector2.Distance(target.transform.position, transform.position) < 0.5f)
                {
                    canMove = false;
                    isplie = false;
                }
            }
        }
    }
}
