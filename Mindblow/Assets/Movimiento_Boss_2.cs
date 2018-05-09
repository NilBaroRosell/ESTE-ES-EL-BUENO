using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Boss_2 : MonoBehaviour {

    public GameObject enemigo;
    public GameObject jugador;
    public Transform transformJugador;
    public Transform transformEnemigo;
    public string tagEnemigo;
    public bool derecha, siguiendo;
    public float minX, maxX, distancia;

    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        transformJugador = jugador.transform;
        enemigo = GameObject.FindGameObjectWithTag(tagEnemigo);
        transformEnemigo = enemigo.transform;
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
        if (siguiendo)
        {
            if (transformJugador.localPosition.x - transformEnemigo.localPosition.x >= distancia || transformEnemigo.localPosition.x - transformJugador.localPosition.x >= distancia)
            {
                siguiendo = false;
            }

            else
            {
                if (derecha)
                {
                    // camina derecha
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(80, 0));
                }
                else
                {
                    // camina izquierda
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(-80, 0));
                }
            }
        }

        else
        {
            if ((transformJugador.localPosition.x - transformEnemigo.localPosition.x <= distancia && transformJugador.localPosition.x - transformEnemigo.localPosition.x >= 0) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo.localPosition.y) <= 10))
            {
                if (derecha)
                {
                    // camina derecha
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(80, 0));
                }

                else
                {
                    // gira de izquierda a derecha
                    girarEnemigo(transformEnemigo);
                    derecha = true;

                    // camina derecha
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(80, 0));
                }
            }

            else if (transformEnemigo.localPosition.x - transformJugador.localPosition.x <= distancia && transformEnemigo.localPosition.x - transformJugador.localPosition.x >= 0 && (Mathf.Abs(transformEnemigo.localPosition.y - transformJugador.localPosition.y)) <= 10)
            {
                if (derecha)
                {
                    // gira de derecha a izquierda
                    girarEnemigo(transformEnemigo);
                    derecha = false;

                    // camina izquierda
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(-80, 0));
                }

                else
                {
                    // camina izquierda
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(-80, 0));
                }
            }

            else
            {
                if (derecha)
                {
                    if ((transformEnemigo.localPosition.x >= maxX - 0.2 && transformEnemigo.localPosition.x <= maxX + 0.2) || transformEnemigo.localPosition.x > maxX)
                    {
                        // gira de derecha a izquierda
                        girarEnemigo(transformEnemigo);
                        derecha = false;
                        // camina izquierda
                        GetComponent<Rigidbody2D>().AddForce(new Vector2(-80, 0));
                    }

                    else
                    {
                        // camina derecha
                        GetComponent<Rigidbody2D>().AddForce(new Vector2(80, 0));
                    }
                }

                else
                {
                    if ((transformEnemigo.localPosition.x >= minX - 0.2 && transformEnemigo.localPosition.x <= minX + 0.2) || transformEnemigo.localPosition.x < minX)
                    {
                        // gira de izquierda a derecha
                        girarEnemigo(transformEnemigo);
                        derecha = true;
                        // camina derecha
                        GetComponent<Rigidbody2D>().AddForce(new Vector2(80, 0));
                    }

                    else
                    {
                        // camina izquierda
                        GetComponent<Rigidbody2D>().AddForce(new Vector2(-80, 0));
                    }
                }
            }
        }
    }

    void girarEnemigo(Transform transformEnemigo)
    {
        if (derecha)
            transformEnemigo.localScale = new Vector3(-1, 1, 1);
        else
            transformEnemigo.localScale = new Vector3(1, 1, 1);

    }
}
