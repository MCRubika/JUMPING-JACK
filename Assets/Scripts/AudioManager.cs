using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("MUSIQUE")]
    public AK.Wwise.Event musique;
    public AK.Wwise.Event aerobicTheme;

    //Emettor Sound Object
    [Header("EMETTOR SOUND OBJECT")]
    public GameObject radio;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        musique.Post(gameObject);
        aerobicTheme.Post(radio);
    }

}
