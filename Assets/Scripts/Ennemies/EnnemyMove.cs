using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMove : MonoBehaviour
{
    public float speed = 0.5f;           // Vitesse de déplacement
    public float lifeTime;
    private Transform myTransform; 

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        speed = Random.Range(speed-0.5f, speed+0.5f);
        Destroy (gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.Instance.IsInGame)
        {
            myTransform.Translate(Vector3.down * Time.deltaTime * speed); //O,1,O
        }
    }
}
