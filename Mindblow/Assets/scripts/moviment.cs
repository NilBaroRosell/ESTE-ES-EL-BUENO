using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moviment : MonoBehaviour
{
    public bool tocandoElSuelo = true, tocandoEscalera = false;
    public bool llave;
    public GameObject jugador;
    public Transform transformJugador;
    public GameObject Llave;
    public GameObject camara;
    public Transform transformCamara;

    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        transformJugador = jugador.transform;
        Llave = GameObject.FindGameObjectWithTag("Llave");
        camara = GameObject.FindGameObjectWithTag("MainCamera");
        transformCamara = camara.transform;
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
            tocandoElSuelo = false;
            tocandoEscalera = false;
        }

        if (tocandoElSuelo) transformCamara.localPosition = new Vector3(transformJugador.localPosition.x, transformJugador.localPosition.y + (float)3.67, transformCamara.localPosition.z);
        else
        {
            if (transformJugador.localPosition.y < transformCamara.localPosition.y + 3.5) transformCamara.localPosition = new Vector3(transformJugador.localPosition.x, transformCamara.localPosition.y, transformCamara.localPosition.z);
            else transformCamara.localPosition = new Vector3(transformJugador.localPosition.x, transformJugador.localPosition.y + (float)3.67, transformCamara.localPosition.z);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SUELO") tocandoElSuelo = true;
        if (collision.gameObject.tag == "escalera") tocandoEscalera = true;
    }
}