using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moviment : MonoBehaviour
{
    public bool tocandoElSuelo = true, tocandoEscalera = false;
    private bool espacio = false;
    private bool llave, tecla;
    public GameObject jugador;
    public Transform transformJugador;

    public AudioClip sonidoSalto;
    public AudioSource fuenteDeAudioSalto;

    private Animator myAnimator;

    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        transformJugador = jugador.transform;
        myAnimator = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start()
    {
        fuenteDeAudioSalto = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!espacio)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                espacio = true;
            }
        }
        myAnimator.SetBool("Suelo", tocandoElSuelo);
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) // ir a la izquierda
        {
            transformJugador.localScale = new Vector3(-0.5335937f, 0.5619395f, 1);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-60, 0));
            tecla = true;
        }

        if (Input.GetKey(KeyCode.D)) // ir a la derecha
        {
            transformJugador.localScale = new Vector3(0.5335937f, 0.5619395f, 1);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(60, 0));
            tecla = true;
        }

        if (!(Input.GetKey(KeyCode.A)) && !(Input.GetKey(KeyCode.D))) // ir a la derecha
        {
            tecla = false;
        }

        if (espacio && (tocandoElSuelo || tocandoEscalera)) // saltar
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1900));
            fuenteDeAudioSalto.clip = sonidoSalto;
            fuenteDeAudioSalto.Play();
            espacio = false;
            tocandoElSuelo = false;
            tocandoEscalera = false;            
        }
        myAnimator.SetBool("Suelo", tocandoElSuelo);
        myAnimator.SetBool("Tecla", tecla);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SUELO") tocandoElSuelo = true;
        if (collision.gameObject.tag == "escalera") tocandoEscalera = true;
    }
}