using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1.5f;                   // Vitesse de déplacement
    public string horizontalAxis = "Horizontal"; // Axe horizontal modifiable dans l'éditeur
    public string verticalAxis = "Vertical";     // Axe vertical modifiable dans l'éditeur
    public float maxPosX;
    public float minPosX;
    public float maxPosY;
    public float minPosY;
    Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis(horizontalAxis);
        float moveVertical = Input.GetAxis(verticalAxis);

        myTransform.Translate(new Vector3(moveHorizontal, moveVertical, 0) * Time.deltaTime * speed);
        myTransform.position = new Vector3(Mathf.Clamp (myTransform.position.x,minPosX, maxPosX), Mathf.Clamp (myTransform.position.y,minPosY, maxPosY), myTransform.position.z);
    }
}