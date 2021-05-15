using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBehavior : MonoBehaviour
{
    public Transform head;
    public LegBehavior feet;
    public Transform parent;

    public LineRenderer lineRenderer;

    public void Update()
    {
        lineRenderer.SetPosition(0, new Vector3( head.transform.position.x-parent.transform.position.x,head.transform.position.y));
        lineRenderer.SetPosition(2, new Vector3(feet.transform.position.x - parent.transform.position.x, feet.transform.position.y ));

        if(feet.isplie == false && feet.canMove)
        {
            lineRenderer.SetPosition(1, new Vector3(feet.piedsplie.transform.position.x - parent.transform.position.x, feet.piedsplie.transform.position.y ));
        }

        else
        {
            lineRenderer.SetPosition(1, new Vector3(feet.transform.position.x - parent.transform.position.x, feet.transform.position.y ));
        }
    }
}
