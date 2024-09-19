using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    public GameObject tir;
    public Transform spawnPoint;
    public KeyCode fireKey = KeyCode.Mouse0; // Par défaut, clic gauche de la souris

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(fireKey))
        {
            Fire();
        }
    }

    void Fire()
    {
        if (tir != null && spawnPoint != null)
        {
            Instantiate(tir, spawnPoint.position, spawnPoint.rotation);
            Debug.Log("Projectile tiré !");
        }
        else
        {
            Debug.LogError("Tir ou SpawnPoint non assigné !");
        }
    }
}