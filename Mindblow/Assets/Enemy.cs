using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour {

    float health;
    public Transform Enemigo;
    public GameObject NAVE;
    public GameObject TeledirigidoPrefab;
    private Transform lados;
    Rigidbody2D enemy;
    bool damage;

    public GameObject Player;
    private inicialitzar getCambio;
    private bool change;
    bool paso1_2;
    bool paso2_3;

    public AudioClip sonidoEnemigoTocadp;
    public AudioSource fuenteDeAudioEnemigoTocado;

    public float xIni, yIni;

    public bool dead = false;

    void Awake()
	{
		enemy = GetComponent<Rigidbody2D>();
	}

	void Start()
	{
		NAVE = GameObject.FindGameObjectWithTag ("Player");
		lados = NAVE.transform;
        health = 3;
        damage = false;
    }

	void Update()
	{
        getCambio = Player.GetComponent<inicialitzar>();
        change = getCambio.cambio;

        if (change)
        {
            dead = true;
            Enemigo.transform.localPosition = new Vector2(xIni, yIni);
            health = 3;
        }
    }

	public void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player_Bullet" || col.gameObject.tag == "Player_Sword")
		{
            if (health > 1)
            {
                fuenteDeAudioEnemigoTocado.clip = sonidoEnemigoTocadp;
                fuenteDeAudioEnemigoTocado.Play();
                health--;
            }
            else
            {
                dead = true;
                Enemigo.transform.localPosition = new Vector2(-877, -5);
            }
		}

        if (col.gameObject.tag == "Jugador")
        {
            damage = true;
        }
	}

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jugador")
        {
            damage = false;
        }
    }
}

