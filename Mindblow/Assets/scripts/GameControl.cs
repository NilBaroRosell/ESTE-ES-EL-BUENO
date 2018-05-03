using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    public bool llave = false, habitacio1 = false;
    public GameObject jugador;
    public Transform transformJugador;
    public GameObject Llave;
    public GameObject Llave2;
    public GameObject puertaLlave;
    public GameObject puertaLlave2;
    public float lastPosX, lastPosY;
    public float xProva1, yProva1, xProva2, yProva2;
    public float xPos1, yPos1, xPos2, yPos2, xPos3, yPos3, xPos4, yPos4, xPos5, yPos5, xPos6, yPos6, xPos7, yPos7, xPos8, yPos8;
    public float x1PL1, y1PL1, x2PL1, y2PL1, x1PL2, y1PL2, x2PL2, y2PL2;

    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        transformJugador = jugador.transform;
        Llave = GameObject.FindGameObjectWithTag("Llave");
        Llave2 = GameObject.FindGameObjectWithTag("Llave2");
        puertaLlave = GameObject.FindGameObjectWithTag("Puerta Llave");
        puertaLlave2 = GameObject.FindGameObjectWithTag("Puerta Llave2");
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        checkDoor();
        checkKeyDoor();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Llave")
        {
            llave = true;
            Destroy(Llave);
        }
        else if (collision.gameObject.tag == "Llave2")
        {
            llave = true;
            Destroy(Llave2);
        }
    }

    void checkDoor()
    {
        if (Input.GetKeyDown(KeyCode.E) && (transformJugador.localPosition.x >= xPos1 && transformJugador.localPosition.x <= xPos2) && (transformJugador.localPosition.y >= yPos1 && transformJugador.localPosition.y <= yPos2))
        {
            moviment getVariables = GetComponent<moviment>();
            lastPosX = getVariables.transformJugador.localPosition.x;
            lastPosY = getVariables.transformJugador.localPosition.y;
            transformJugador.localPosition = new Vector2(xProva1, yProva1);// anar a habitacio
            habitacio1 = true;
        }

        if (Input.GetKeyDown(KeyCode.E) && (transformJugador.localPosition.x >= xPos3 && transformJugador.localPosition.x <= xPos4) && (transformJugador.localPosition.y >= yPos3 && transformJugador.localPosition.y <= yPos4))
        {
            moviment getVariables = GetComponent<moviment>();
            lastPosX = getVariables.transformJugador.localPosition.x;
            lastPosY = getVariables.transformJugador.localPosition.y;
            transformJugador.localPosition = new Vector2(xProva2, yProva2); // anar a habitacio 2
        }

        if (Input.GetKeyDown(KeyCode.E) && (transformJugador.localPosition.x >= xPos5 && transformJugador.localPosition.x <= xPos6) && (transformJugador.localPosition.y >= yPos5 && transformJugador.localPosition.y <= yPos6))
        {
            transformJugador.localPosition = new Vector2(lastPosX, lastPosY); // tornar al nivell 1
            habitacio1 = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && (transformJugador.localPosition.x >= xPos7 && transformJugador.localPosition.x <= xPos8) && (transformJugador.localPosition.y >= yPos7 && transformJugador.localPosition.y <= yPos8)) transformJugador.localPosition = new Vector2(lastPosX, lastPosY);

    }
    
    void checkKeyDoor()
    {
        if ((transformJugador.localPosition.x >= x1PL1 && transformJugador.localPosition.x <= x2PL1) && (transformJugador.localPosition.y >= y1PL1 && transformJugador.localPosition.y <= y2PL1))
        {
            if (llave && Input.GetKey(KeyCode.E))
            {
                Destroy(puertaLlave);
                llave = false;
            }
        }

        if ((transformJugador.localPosition.x >= x1PL2 && transformJugador.localPosition.x <= x2PL2) && (transformJugador.localPosition.y >= y1PL2 && transformJugador.localPosition.y <= y2PL2))
        {
            if (llave && Input.GetKey(KeyCode.E))
            {
                Destroy(puertaLlave2);
                llave = false;
            }
        }
    }
}

