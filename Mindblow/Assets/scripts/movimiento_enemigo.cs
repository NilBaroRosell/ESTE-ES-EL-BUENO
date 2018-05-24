using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_enemigo : MonoBehaviour {

    public GameObject enemigo;
    public GameObject jugador;
    public Transform transformJugador;
    public Transform transformEnemigo;
    public string tagEnemigo;
    public bool derecha, siguiendo;
    public float minX, maxX, distancia;

    private GameControl getTouching;
    public bool change = false;


    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        transformJugador = jugador.transform;
        enemigo = GameObject.FindGameObjectWithTag(tagEnemigo);
        transformEnemigo = enemigo.transform;
    }

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
        getTouching = jugador.GetComponent<GameControl>();
        change = getTouching.activarSeguimiento;
    }


    private void FixedUpdate()
    {
        if (change && tagEnemigo == "Dibujante 1")
        {
            if ((Mathf.Abs(transformEnemigo.localPosition.x - transformJugador.localPosition.x)) >= distancia)
            {
                siguiendo = true;
                derecha = false;
            }
            
            else
            {
                change = false;
            }
        }

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
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(60, 0));
                }
                else
                {
                    // camina izquierda
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(-60, 0));
                }
            }
        }

        else
        {
            if ((transformJugador.localPosition.x - transformEnemigo.localPosition.x <= distancia && transformJugador.localPosition.x - transformEnemigo.localPosition.x >= 0) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo.localPosition.y) <= 4))
            {
                if (derecha)
                {
                    // camina derecha
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(60, 0));
                }

                else
                {
                    // gira de izquierda a derecha
                    girarEnemigo(transformEnemigo);
                    derecha = true;

                    // camina derecha
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(60, 0));
                }
            }

            else if (transformEnemigo.localPosition.x - transformJugador.localPosition.x <= distancia && transformEnemigo.localPosition.x - transformJugador.localPosition.x >= 0 && (Mathf.Abs(transformEnemigo.localPosition.y - transformJugador.localPosition.y)) <= 4)
            {
                if (derecha)
                {
                    // gira de derecha a izquierda
                    girarEnemigo(transformEnemigo);
                    derecha = false;

                    // camina izquierda
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(-60, 0));
                }

                else
                {
                    // camina izquierda
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(-60, 0));
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
                        GetComponent<Rigidbody2D>().AddForce(new Vector2(-60, 0));
                    }

                    else
                    {
                        // camina derecha
                        GetComponent<Rigidbody2D>().AddForce(new Vector2(60, 0));
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
                        GetComponent<Rigidbody2D>().AddForce(new Vector2(60, 0));
                    }

                    else
                    {
                        // camina izquierda
                        GetComponent<Rigidbody2D>().AddForce(new Vector2(-60, 0));
                    }
                }
            }
        }
    }

    void girarEnemigo(Transform transformEnemigo)
    {
        switch (tagEnemigo)
        {
            case "Enemigo 2":
                if (derecha)
                {
                    transformEnemigo.localScale = new Vector3(-0.2811019f, 0.4119202f, 1);
                    break;
                }
                else
                {
                    transformEnemigo.localScale = new Vector3(0.2811019f, 0.4119202f, 1);
                    break;
                }

            case "Enemigo 5":
            case "Enemigo 6":
            case "Enemigo 9":
            case "Enemigo 15":
                if (derecha)
                {
                    transformEnemigo.localScale = new Vector3(-0.09207151f, 0.07040372f, 1);
                    break;
                }
                else
                {
                    transformEnemigo.localScale = new Vector3(0.09207151f, 0.07040372f, 1);
                    break;
                }

            case "Enemigo":
            case "Enemigo 3":
            case "Enemigo 4":
            case "Enemigo 8":
            case "Enemigo 10":
            case "Enemigo 11":
            case "Enemigo 12":
            case "Enemigo 13":
            case "Enemigo 14":
            case "Enemigo 16":
            case "Enemigo 17":
            case "Enemigo 18":
            case "Enemigo 19":
            case "Dibujante 1":
            case "Dibujante 2":
            case "Dibujante 3":
            case "Dibujante 4":
            case "Dibujante 5":
                if (derecha)
                {
                    transformEnemigo.localScale = new Vector3(-1, 1, 1);
                    break;
                }
                else
                {
                    transformEnemigo.localScale = new Vector3(1, 1, 1);
                    break;
                }

            case "Enemigo 3.1":
            case "Enemigo 3.2":
            case "Enemigo 3.3":
            case "Enemigo 3.4":
                if (derecha)
                {
                    transformEnemigo.localScale = new Vector3(-2.701154f, 2.455967f, 1);
                    break;
                }
                else
                {
                    transformEnemigo.localScale = new Vector3(2.701154f, 2.455967f, 1);
                    break;
                }
        }
    }
}
