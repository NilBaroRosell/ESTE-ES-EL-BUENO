using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moviment : MonoBehaviour
{
    public bool tocandoElSuelo = true, tocandoEscalera = false;
    private bool espacio = false;
    private bool llave;
    public GameObject jugador;
    public Transform transformJugador;
    public GameObject Llave;

    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        transformJugador = jugador.transform;
        Llave = GameObject.FindGameObjectWithTag("Llave");
    }

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        GameControl getVariables = GetComponent<GameControl>();
        llave = getVariables.llave;

        if (!espacio)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                espacio = true;
            }
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) // ir a la izquierda
        {
            transformJugador.localScale = new Vector3(-1, 1, 1);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-60, 0));
        }

        if (Input.GetKey(KeyCode.D)) // ir a la derecha
        {
            transformJugador.localScale = new Vector3(1, 1, 1);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(60, 0));
        }

        if (Input.GetKeyDown(KeyCode.Space) && (tocandoElSuelo || tocandoEscalera)) // saltar
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1800));
            espacio = false;
            tocandoElSuelo = false;
            tocandoEscalera = false;            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SUELO") tocandoElSuelo = true;
        if (collision.gameObject.tag == "escalera") tocandoEscalera = true;
    }
}