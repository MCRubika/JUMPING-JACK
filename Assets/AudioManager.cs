using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AK.Wwise.Event musique;

    private void Start()
    {
        musique.Post(gameObject);
    }

}
