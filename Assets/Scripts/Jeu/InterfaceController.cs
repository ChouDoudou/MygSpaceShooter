using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InterfaceController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText, lifeText;
    public GameObject panelGameOver;

    private int currentLife;

    // Start is called before the first frame update
    void Start()
    {
        panelGameOver.SetActive(false);
    }

    public void updateScore(int value)
    {
        scoreText.text = "Score : " + value;
    }

    public void updateLife(int value)
    {
        currentLife = value;
        lifeText.text = "Vie : " + value;

        if (currentLife <= 0)
        {
            GameOver();
        }
    }

    // Fonction pour gérer le Game Over
    private void GameOver()
    {
        panelGameOver.SetActive(true);
        Debug.Log("Game Over!");
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}