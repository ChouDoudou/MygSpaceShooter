using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyShot : MonoBehaviour
{
    public GameObject tir;
    public Transform spawnPoint;

    /***Gestion du timer pour la fréquence du tir***/
    public float shotTime;
    private float startTime;
    private float elapsedTime;

    // Use this for Initialization
    void Start()
    {
        startTime = Time.time;
        Instantiate(tir, spawnPoint.transform.position, tir.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.Instance.IsInGame)
        {
            elapsedTime = Time.time - startTime;

        if (elapsedTime >= shotTime)
        {
            startTime = Time.time;
            Instantiate(tir,spawnPoint.transform.position, tir.transform.rotation);
        }
        }
    }
}