using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_Boss : MonoBehaviour {
    public float health;
    public Transform Enemigo;
    public GameObject NAVE;
    public GameObject TeledirigidoPrefab;
    private Transform lados;
    Rigidbody2D enemy;
    bool damage;

    public GameObject Player;
    private inicialitzar getCambio;
    private bool change;

    public float newPos;

    void Awake()
    {
        enemy = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        NAVE = GameObject.FindGameObjectWithTag("Player");
        lados = NAVE.transform;
        health = 18;
        damage = false;
        newPos = 424;
    }

    void Update()
    {
        getCambio = Player.GetComponent<inicialitzar>();
        change = getCambio.cambio;

        if (change) health = 18;

        getCambio = Player.GetComponent<inicialitzar>();
        change = getCambio.cambio;

        newPos = Random.Range(422, 438);

    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player_Bullet" || col.gameObject.tag == "Player_Sword")
        {
            if (health > 1)
            {
                health--;
                if (health == 9)
                {
                    Enemigo.localPosition = new Vector2(432, -78);
                }
            }
            else
            {
                Destroy(gameObject);
            }
        }

        if (col.gameObject.tag == "Player")
        {
            damage = true;
            if (health > 12)
            {
                Enemigo.localPosition = new Vector2(newPos, -87.16f);
            }
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
