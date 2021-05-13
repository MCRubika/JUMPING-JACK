using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBehavior : MonoBehaviour
{
    public Transform head;
    public LegBehavior feet;

    public LineRenderer lineRenderer;

    public void Update()
    {
        lineRenderer.SetPosition(0, head.transform.position);
        lineRenderer.SetPosition(2, feet.transform.position);

        if(feet.isplie == false && feet.canMove)
        {
            lineRenderer.SetPosition(1, feet.piedsplie.transform.position);
        }

        else
        {
            lineRenderer.SetPosition(1, feet.transform.position);
        }
    }
}
