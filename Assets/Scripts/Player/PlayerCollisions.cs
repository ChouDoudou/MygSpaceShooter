using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    InfosPlayer infos;

    // Start is called before the first frame update
    void Start()
    {
        infos = GetComponent<InfosPlayer>();
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Player entre en collision avec " + other.gameObject.name);

        if (other.gameObject.CompareTag("TirEnn"))
        {
            Debug.Log("************** Joueur touché par un tir ennemi");

            other.gameObject.SetActive (false);  // On détruit le tir ennemi
            infos.updateLife(-1);                // Le joueur perd 1 point de vie
        }
    }
}