using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public int scoreDestruction = 10;
    public int playerLifeLost = 1;
    private GameObject player;

    // Called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Called when a collision is detected
    void OnCollisionEnter2D(Collision2D other)
    {
        // Debug.Log("Ennemi entre en collision avec " + other.gameObject.name);

        if (other.gameObject.CompareTag("Tir"))
        {
            // Debug.Log("****** Ennemi entre en collision avec un tir");

            if (player != null)
            {
                player.GetComponent<InfosPlayer>().AddScore(scoreDestruction);
            }

            Destroy(this.gameObject); // On détruit l'ennemi
            Destroy(other.gameObject); // On détruit le tir
        }

        if (other.gameObject.CompareTag("Player"))
        {
            // Debug.Log("Ennemi entre en collision avec le joueur");
            
            if (player != null)
            {
                player.GetComponent<InfosPlayer>().updateLife(-1*playerLifeLost);
            }
        }
    }
}