using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController _instance;
    public static GameController Instance => _instance;

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public GameObject ennemyPrefab;
    public Vector3 spawnRange;
    public int nbrEnnemyParVague;
    public float waveTime;
    public float spawnTime;
    private bool isInGame = true;
    public bool IsInGame
    {
        get
        {
            return isInGame;
        }
        set
        {
            isInGame = value;
        }
    }
    // La méthode est appelée une seule fois
    void Start()
    {
        StartCoroutine(generateWave());
    }
    IEnumerator generateWave()
    {
        while(isInGame)
        {
            for(int i = 0; i < nbrEnnemyParVague; i++)
            {
                Vector3 spawnPos = new Vector3 (Random.Range(-spawnRange.x,spawnRange.x),Random.Range(spawnRange.y,spawnRange.y-1),0);
                Instantiate (ennemyPrefab,spawnPos,ennemyPrefab.transform.rotation);
                yield return new WaitForSeconds(spawnTime);
            }
            yield return new WaitForSeconds(waveTime);
        }
    }
}