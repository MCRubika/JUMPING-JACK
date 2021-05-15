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

    public GameObject Saut1;
    public Transform Saut1Point;

    public GameObject Saut2;
    public Transform Saut2Point;

    public CinemachineVirtualCamera mycam;

    public int pieces;
    public int jambes;
    public int poules;
    public int jouet;
    public int sautDansLeVide;

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
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            destroyingZone.SetActive(true);
        }
    }
    public void Respawn()
    {
        GameObject clone = Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        mycam.Follow = clone.transform;

        Instantiate(Saut1, Saut1Point.position, Quaternion.identity);
        Instantiate(Saut2, Saut2Point.position, Quaternion.identity);
        destroyingZone.SetActive(false);
    }
}
