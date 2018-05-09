using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    public bool llave = false, habitacio1 = false, luz = false;
    public GameObject jugador;
    public Transform transformJugador;
    public GameObject Llave;
    public GameObject Llave2;
    public GameObject Llave3;
    public GameObject Llave4;
    public GameObject Luz;
    public GameObject Trampilla;
    public GameObject puertaLlave;
    public GameObject puertaLlave2;
    public GameObject puertaLlave3;
    public GameObject puertaLlave4;
    public float lastPosX, lastPosY;
    public float xProva1, yProva1, xProva2, yProva2, nivel2X, nivel2Y, xProva3, yProva3, xProva4, yProva4, xProva5, yProva5;
    public float xPos1, yPos1, xPos2, yPos2, xPos3, yPos3, xPos4, yPos4, xPos5, yPos5, xPos6, yPos6, xPos7, yPos7, xPos8, yPos8, xPos9, yPos9, xPos10, yPos10, xPos11, yPos11, xPos12, yPos12, xPos13, yPos13, xPos14, yPos14, xPos15, yPos15, xPos16, yPos16, xPos17, yPos17, xPos18, yPos18, xPos19, yPos19, xPos20, yPos20, xPos21, yPos21, xPos22, yPos22;
    public float x1PL1, y1PL1, x2PL1, y2PL1, x1PL2, y1PL2, x2PL2, y2PL2, x1PL3, y1PL3, x2PL3, y2PL3, x1PL4, y1PL4, x2PL4, y2PL4;
    public float tx1, tx2, ty1, ty2;

    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        transformJugador = jugador.transform;
        Llave = GameObject.FindGameObjectWithTag("Llave");
        Llave2 = GameObject.FindGameObjectWithTag("Llave2");
        Llave3 = GameObject.FindGameObjectWithTag("Llave 3");
        Llave4 = GameObject.FindGameObjectWithTag("Llave 4");
        Luz = GameObject.FindGameObjectWithTag("Luz");
        puertaLlave = GameObject.FindGameObjectWithTag("Puerta Llave");
        puertaLlave2 = GameObject.FindGameObjectWithTag("Puerta Llave2");
        puertaLlave3 = GameObject.FindGameObjectWithTag("Puerta Llave 3");
        puertaLlave4 = GameObject.FindGameObjectWithTag("Puerta Llave 4");
        Trampilla = GameObject.FindGameObjectWithTag("Trampilla");
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
        if (luz)
        {

        }
        checkDoor();
        checkKeyDoor();
        checkTrampilla();
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
        else if (collision.gameObject.tag == "Llave 3")
        {
            llave = true;
            Destroy(Llave3);
        }
        else if (collision.gameObject.tag == "Llave 4")
        {
            llave = true;
            Destroy(Llave4);
        }
        else if (collision.gameObject.tag == "Luz")
        {
            luz = true;
            Destroy(Luz);
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

        if (Input.GetKeyDown(KeyCode.E) && (transformJugador.localPosition.x >= xPos11 && transformJugador.localPosition.x <= xPos12) && (transformJugador.localPosition.y >= yPos11 && transformJugador.localPosition.y <= yPos12))
        {
            moviment getVariables = GetComponent<moviment>();
            lastPosX = getVariables.transformJugador.localPosition.x;
            lastPosY = getVariables.transformJugador.localPosition.y;
            transformJugador.localPosition = new Vector2(xProva3, yProva3); // anar a habitacio 3
        }

        if (Input.GetKeyDown(KeyCode.E) && (transformJugador.localPosition.x >= xPos15 && transformJugador.localPosition.x <= xPos16) && (transformJugador.localPosition.y >= yPos15 && transformJugador.localPosition.y <= yPos16))
        {
            moviment getVariables = GetComponent<moviment>();
            lastPosX = getVariables.transformJugador.localPosition.x;
            lastPosY = getVariables.transformJugador.localPosition.y;
            transformJugador.localPosition = new Vector2(xProva4, yProva4); // anar a habitacio 4
        }

        if (Input.GetKeyDown(KeyCode.E) && (transformJugador.localPosition.x >= xPos19 && transformJugador.localPosition.x <= xPos20) && (transformJugador.localPosition.y >= yPos19 && transformJugador.localPosition.y <= yPos20))
        {
            moviment getVariables = GetComponent<moviment>();
            lastPosX = getVariables.transformJugador.localPosition.x;
            lastPosY = getVariables.transformJugador.localPosition.y;
            transformJugador.localPosition = new Vector2(xProva5, yProva5); // anar a habitacio 5
        }

        if (Input.GetKeyDown(KeyCode.E) && (transformJugador.localPosition.x >= xPos5 && transformJugador.localPosition.x <= xPos6) && (transformJugador.localPosition.y >= yPos5 && transformJugador.localPosition.y <= yPos6))
        {
            transformJugador.localPosition = new Vector2(lastPosX, lastPosY + 5); // tornar al nivell 1
            habitacio1 = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && (transformJugador.localPosition.x >= xPos7 && transformJugador.localPosition.x <= xPos8) && (transformJugador.localPosition.y >= yPos7 && transformJugador.localPosition.y <= yPos8)) transformJugador.localPosition = new Vector2(lastPosX, lastPosY + 5);

        if (Input.GetKeyDown(KeyCode.E) && (transformJugador.localPosition.x >= xPos9 && transformJugador.localPosition.x <= xPos10) && (transformJugador.localPosition.y >= yPos9 && transformJugador.localPosition.y <= yPos10)) transformJugador.localPosition = new Vector2(nivel2X, nivel2Y + 5);

        if (Input.GetKeyDown(KeyCode.E) && (transformJugador.localPosition.x >= xPos13 && transformJugador.localPosition.x <= xPos14) && (transformJugador.localPosition.y >= yPos13 && transformJugador.localPosition.y <= yPos14)) transformJugador.localPosition = new Vector2(lastPosX, lastPosY + 5);

        if (Input.GetKeyDown(KeyCode.E) && (transformJugador.localPosition.x >= xPos17 && transformJugador.localPosition.x <= xPos18) && (transformJugador.localPosition.y >= yPos17 && transformJugador.localPosition.y <= yPos18)) transformJugador.localPosition = new Vector2(lastPosX, lastPosY + 5);

        if (Input.GetKeyDown(KeyCode.E) && (transformJugador.localPosition.x >= xPos21 && transformJugador.localPosition.x <= xPos22) && (transformJugador.localPosition.y >= yPos21 && transformJugador.localPosition.y <= yPos22)) transformJugador.localPosition = new Vector2(lastPosX, lastPosY + 5);

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

        if ((transformJugador.localPosition.x >= x1PL3 && transformJugador.localPosition.x <= x2PL3) && (transformJugador.localPosition.y >= y1PL3 && transformJugador.localPosition.y <= y2PL3))
        {
            if (llave && Input.GetKey(KeyCode.E))
            {
                Destroy(puertaLlave3);
                llave = false;
            }
        }

        if ((transformJugador.localPosition.x >= x1PL4 && transformJugador.localPosition.x <= x2PL4) && (transformJugador.localPosition.y >= y1PL4 && transformJugador.localPosition.y <= y2PL4))
        {
            if (llave && Input.GetKey(KeyCode.E))
            {
                Destroy(puertaLlave4);
                llave = false;
            }
        }
    }

    void checkTrampilla()
    {
        if ((transformJugador.localPosition.x >= tx1 && transformJugador.localPosition.x <= tx2) && (transformJugador.localPosition.y >= ty1 && transformJugador.localPosition.y <= ty2)) transformJugador.localPosition = new Vector3(transformJugador.localPosition.x, transformJugador.localPosition.y + (float)22.3, transformJugador.localPosition.z);
    }
}

