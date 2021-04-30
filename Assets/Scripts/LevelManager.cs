using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void Awake()
    {
        instance = this;
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
        Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        Instantiate(Saut1, Saut1Point.position, Quaternion.identity);
        Instantiate(Saut2, Saut2Point.position, Quaternion.identity);
        destroyingZone.SetActive(false);
    }
}
