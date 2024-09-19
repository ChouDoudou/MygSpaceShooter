using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfosPlayer : MonoBehaviour
{
    private int score = 0;
    private int life = 6;
    private const int maxLife = 6;
    private InterfaceController gui;
    private GameController gameScript;

    // Start is called before the first frame update
    void Start()
    {
        gui = GameObject.Find("Interface").GetComponent<InterfaceController>();

        gui.updateLife (life);

        gameScript = GameObject.Find("GameHolder").GetComponent<GameController> ();
    }

    // Appelée par le script de collisions des ennemis
    public void AddScore(int value)
    {
        score += value; // score = score + value
        Debug.Log("Score actuel du player : " + score);

        gui.updateScore(score);
    }

    public void updateLife(int value)
    {
        life += value;
        if(life > maxLife)
        {
            life = maxLife;
        }
        
        if(life < 0)
        {
            life = 0;
        }

        if(life <= 0)
        {
            Debug.Log("Game Over");        // Game Over
            gameScript.IsInGame = false;   // On arrête la génération d'ennemis
        }

        gui.updateLife(life);
    }
}