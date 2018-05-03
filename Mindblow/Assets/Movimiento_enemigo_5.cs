using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_enemigo_5 : MonoBehaviour {

    public GameObject enemigo;
    public GameObject jugador;
    public GameObject FootPrefab;
    public Transform transformJugador;
    public Transform transformEnemigo;
    public Transform canon;
    public bool derecha, siguiendo;
    public float minX, maxX, distancia;
    public float cooldown;
    float desiredTime;


    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        transformJugador = jugador.transform;
        enemigo = GameObject.FindGameObjectWithTag("Enemigo 5");
        transformEnemigo = enemigo.transform;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        desiredTime += Time.deltaTime;
    }


    private void FixedUpdate()
    {
            if (((transformJugador.localPosition.x - transformEnemigo.localPosition.x <= distancia && (transformJugador.localPosition.x - transformEnemigo.localPosition.x >= 0)) && /*(Mathf.Abs(transformJugador.localPosition.y - transformEnemigo.localPosition.y) <= 30)) &&*/ (desiredTime >= cooldown)))
            {
                if (derecha)
                {
                    // camina derecha
                    Instantiate(FootPrefab, canon.position, canon.rotation);//*****
                    desiredTime = 0;
                }

                else
                {
                    // gira de izquierda a derecha
                    girarEnemigo(transformEnemigo);
                    derecha = true;

                    // camina derecha
                    //Instantiate(FootPrefab, canon.position, canon.rotation);//*****
                    //desiredTime = 0;
                }
            }

            else if ((transformEnemigo.localPosition.x - transformJugador.localPosition.x <= distancia && transformEnemigo.localPosition.x - transformJugador.localPosition.x >= 0) && (desiredTime >= cooldown))
            {
                if (derecha)
                {
                    // gira de derecha a izquierda
                    girarEnemigo(transformEnemigo);
                    derecha = false;

                    // camina izquierda
                    //Instantiate(FootPrefab, canon.position, canon.rotation);//*****
                    //desiredTime = 0;
                }

                else
                {
                    // camina izquierda
                    Instantiate(FootPrefab, canon.position, canon.rotation);//*****
                    desiredTime = 0;
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

    void ataqueEnemoigo()
    {

    }
}
