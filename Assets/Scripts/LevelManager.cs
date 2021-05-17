using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public GameObject destroyingZone;
    public Transform respawnPoint;
    public GameObject playerPrefab;

    public CinemachineVirtualCamera mycam;

    public int pieces;
    public int jambes;
    public int poules;
    public int jouet;
    public int sautDansLeVide;
    public int augmentationSauts;

    public GameObject saut1;
    public GameObject saut2;
    public GameObject saut3;
    public GameObject saut4;

    public GameObject saut1Manquant;
    public GameObject saut2Manquant;
    public GameObject saut3Manquant;
    public GameObject saut4Manquant;

    public GameObject piece1;
    public GameObject piece2;
    public GameObject piece3;

    public GameObject piece1Manquant;
    public GameObject piece2Manquant;
    public GameObject piece3Manquant;

    public GameObject ballonhere;

    public GameObject poule1;
    public GameObject poule2;
    public GameObject poule3;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        pieces = 0;
        jambes = 0;
        poules = 0;
        jouet = 0;
        sautDansLeVide = 0;

        piece1Manquant.SetActive(true);
        piece2Manquant.SetActive(true);
        piece3Manquant.SetActive(true);

        piece1.SetActive(false);
        piece2.SetActive(false);
        piece3.SetActive(false);

        saut1.SetActive(true);
        saut2.SetActive(false);
        saut3.SetActive(false);
        saut4.SetActive(false);

        saut1Manquant.SetActive(false);
        saut2Manquant.SetActive(false);
        saut3Manquant.SetActive(false);
        saut4Manquant.SetActive(false);

        ballonhere.SetActive(false);

        poule1.SetActive(false);
        poule2.SetActive(false);
        poule3.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            destroyingZone.SetActive(true);
        }

        #region Pieces
        if (pieces == 0)
        {
            piece1Manquant.SetActive(true);
            piece2Manquant.SetActive(true);
            piece3Manquant.SetActive(true);

            piece1.SetActive(false);
            piece2.SetActive(false);
            piece3.SetActive(false);
        }

        if(pieces == 1)
        {
            piece1Manquant.SetActive(false);
            piece2Manquant.SetActive(true);
            piece3Manquant.SetActive(true);

            piece1.SetActive(true);
            piece2.SetActive(false);
            piece3.SetActive(false);
        }

        if (pieces == 2)
        {
            piece1Manquant.SetActive(false);
            piece2Manquant.SetActive(false);
            piece3Manquant.SetActive(true);

            piece1.SetActive(true);
            piece2.SetActive(true);
            piece3.SetActive(false);

        }

        if (pieces == 3)
        {
            piece1Manquant.SetActive(false);
            piece2Manquant.SetActive(false);
            piece3Manquant.SetActive(false);

            piece1.SetActive(true);
            piece2.SetActive(true);
            piece3.SetActive(true);

        }
        #endregion

        #region saut
        if (PlayerController.pcInstance.initSaut == 1)
        {
            if(PlayerController.pcInstance.i ==0)
            {
                saut1.SetActive(true);
                saut1Manquant.SetActive(false);
            }

            else
            {
                saut1.SetActive(false);
                saut1Manquant.SetActive(true);
            }
        }

        if (PlayerController.pcInstance.initSaut == 2)
        {
            if (PlayerController.pcInstance.i == 0)
            {
                saut1.SetActive(true);
                saut2.SetActive(true);
                saut1Manquant.SetActive(false);
                saut2Manquant.SetActive(false);
            }

            else if (PlayerController.pcInstance.i == 1)
            {
                saut1.SetActive(true);
                saut2.SetActive(false);
                saut1Manquant.SetActive(false);
                saut2Manquant.SetActive(true);
            }

            else
            {
                saut1.SetActive(false);
                saut2.SetActive(false);
                saut1Manquant.SetActive(true);
                saut2Manquant.SetActive(true);
            }
        }

        if (PlayerController.pcInstance.initSaut == 3)
        {
            if (PlayerController.pcInstance.i == 0)
            {
                saut1.SetActive(true);
                saut2.SetActive(true);
                saut3.SetActive(true);
                saut1Manquant.SetActive(false);
                saut2Manquant.SetActive(false);
                saut3Manquant.SetActive(false);
            }

            else if (PlayerController.pcInstance.i == 1)
            {
                saut1.SetActive(true);
                saut2.SetActive(true);
                saut3.SetActive(false);
                saut1Manquant.SetActive(false);
                saut2Manquant.SetActive(false);
                saut3Manquant.SetActive(true);
            }

            else if (PlayerController.pcInstance.i == 2)
            {
                saut1.SetActive(true);
                saut2.SetActive(false);
                saut3.SetActive(false);
                saut1Manquant.SetActive(false);
                saut2Manquant.SetActive(true);
                saut3Manquant.SetActive(true);
            }

            else
            {
                saut1.SetActive(false);
                saut2.SetActive(false);
                saut3.SetActive(false);
                saut1Manquant.SetActive(true);
                saut2Manquant.SetActive(true);
                saut3Manquant.SetActive(true);
            }
        }

        if (PlayerController.pcInstance.initSaut == 4)
        {
            if (PlayerController.pcInstance.i == 0)
            {
                saut1.SetActive(true);
                saut2.SetActive(true);
                saut3.SetActive(true);
                saut4.SetActive(true);
                saut1Manquant.SetActive(false);
                saut2Manquant.SetActive(false);
                saut3Manquant.SetActive(false);
                saut4Manquant.SetActive(false);
            }

            else if (PlayerController.pcInstance.i == 1)
            {
                saut1.SetActive(true);
                saut2.SetActive(true);
                saut3.SetActive(true);
                saut4.SetActive(false);
                saut1Manquant.SetActive(false);
                saut2Manquant.SetActive(false);
                saut3Manquant.SetActive(false);
                saut4Manquant.SetActive(true);
            }

            else if (PlayerController.pcInstance.i == 2)
            {
                saut1.SetActive(true);
                saut2.SetActive(true);
                saut3.SetActive(false);
                saut4.SetActive(false);
                saut1Manquant.SetActive(false);
                saut2Manquant.SetActive(false);
                saut3Manquant.SetActive(true);
                saut4Manquant.SetActive(true);
            }

            else if (PlayerController.pcInstance.i == 3)
            {
                saut1.SetActive(true);
                saut2.SetActive(false);
                saut3.SetActive(false);
                saut4.SetActive(false);
                saut1Manquant.SetActive(false);
                saut2Manquant.SetActive(true);
                saut3Manquant.SetActive(true);
                saut4Manquant.SetActive(true);
            }

            else
            {
                saut1.SetActive(false);
                saut2.SetActive(false);
                saut3.SetActive(false);
                saut4.SetActive(false);
                saut1Manquant.SetActive(true);
                saut2Manquant.SetActive(true);
                saut3Manquant.SetActive(true);
                saut4Manquant.SetActive(true);
            }
        }
        #endregion

        #region ballon
        if(jouet == 1)
        {
            ballonhere.SetActive(true);
        }
        else
        {
            ballonhere.SetActive(false);
        }
        #endregion

        if (poules == 1)
        {
            poule1.SetActive(true);
            poule2.SetActive(false);
            poule3.SetActive(false);
        }

        if (poules == 1)
        {
            poule1.SetActive(true);
            poule2.SetActive(true);
            poule3.SetActive(false);
        }

        if (poules == 1)
        {
            poule1.SetActive(true);
            poule2.SetActive(true);
            poule3.SetActive(true);
        }
 
    }
    public void Respawn()
    {
        GameObject clone = Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        mycam.Follow = clone.transform;

        destroyingZone.SetActive(false);
    }
}
