using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanzamiento_enemigo : MonoBehaviour {

    public GameObject enemigo;
    public GameObject jugador;
    public GameObject FootPrefab;
    public Transform transformJugador;
    public Transform transformEnemigo;
    public Transform canon;
    public string tagEnemigo;
    public bool derecha, siguiendo;
    public float minX, maxX, distancia;
    public float cooldown;
    float desiredTime;

    public AudioClip sonidoGranada;
    public AudioSource fuenteDeAudioGranada;


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
        desiredTime += Time.deltaTime;
    }


    private void FixedUpdate()
    {
        if (((transformJugador.localPosition.x - transformEnemigo.localPosition.x <= distancia && transformJugador.localPosition.x - transformEnemigo.localPosition.x >= 0) && /*(Mathf.Abs(transformJugador.localPosition.y - transformEnemigo.localPosition.y) <= 30)) &&*/ (desiredTime >= cooldown)))
        {
            if (derecha)
            {
                // camina derecha
                if (enemigo.tag != "Mortero 1" && enemigo.tag != "Mortero 3")
                {
                    Instantiate(FootPrefab, canon.position, canon.rotation);//*****
                    fuenteDeAudioGranada.clip = sonidoGranada;
                    fuenteDeAudioGranada.Play();
                    desiredTime = 0;
                }
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
                if (enemigo.tag != "Justice Flash")
                {
                    Instantiate(FootPrefab, canon.position, canon.rotation);//*****
                    fuenteDeAudioGranada.clip = sonidoGranada;
                    fuenteDeAudioGranada.Play();
                    desiredTime = 0;
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

            case "Mortero 1":
            case "Mortero 3":
            case "Laser Pistol 1":
            case "Laser Pistol 2":
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

            case "Lanzador de Esferas":
                if (derecha)
                {
                    transformEnemigo.localScale = new Vector3(-2.604883f, 2.880935f, 1);
                    break;
                }
                else
                {
                    transformEnemigo.localScale = new Vector3(2.604883f, 2.880935f, 1);
                    break;
                }
        }
    }
}
