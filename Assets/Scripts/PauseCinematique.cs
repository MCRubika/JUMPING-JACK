using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Playables;

public class PauseCinematique : MonoBehaviour
{
    PlayableDirector Timeline;
    public GameObject[] Dialog;
    int Index; //on créer un Index
    int childIndex; // ici un 2nd Index

    bool canSkip;
    bool desactivate;
    bool isplaying = true;

    public int isNotActivable;
    bool alreadyDone;
    public GameObject[] objectsToDesactivate;
    public bool isJustDialog = false;

    void Start()
    {
        Timeline = GetComponent<PlayableDirector>();
    }

    void Update()
    {
        if (isJustDialog == false)
        {
            if (Input.GetButtonDown("Jump") && canSkip) // vérifie si le bool est true
                SkipDialog();
        }
    }

    void SkipDialog() // c'est une fonction
    {
        if (childIndex == 0)
        {
            Debug.Log(Dialog[Index].transform.GetChild(childIndex));
            Dialog[Index].transform.GetChild(childIndex).gameObject.SetActive(true); //on appelle un enfant

            childIndex += 1; // on incrémente
        }

        else if (childIndex != 0)
        {
            if (childIndex == (Dialog[Index].transform.childCount)) // si on arrive au maximum du nbr d'enfant (childCount)
            {
                Dialog[Index].transform.GetChild(childIndex - 1).gameObject.SetActive(false);


                childIndex = 0; // On réinitialise le childIndex pour qu'il puisse recommencer de compter
                Index += 1; // On passe au parent suivant (le gros truc qui regroupe tout les enfants dialog Box)
                Debug.Log("Je suis la");
                Timeline.Resume(); //Resume est une fonction donc y'a des ()
                canSkip = false;
                isplaying = false;
            }

            else //else a pas besoin de parenthese
            {
                Dialog[Index].transform.GetChild(childIndex - 1).gameObject.SetActive(false); // on chercher l'enfant -1
                Dialog[Index].transform.GetChild(childIndex).gameObject.SetActive(true); // enfant actuel (pas besoin de mettre + 1)

                childIndex += 1; //on incrémente encore.
            }
        }
    }

    public void StartDialog()
    {
        isplaying = true;
        Timeline.Pause();
        SkipDialog(); //on appelle la fonction 
        canSkip = true;
    }
}


