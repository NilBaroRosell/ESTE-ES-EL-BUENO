using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Boss_2 : MonoBehaviour {

    float health;

    public Transform Enemigo;
    public GameObject NAVE;
    private Transform lados;
    public GameObject TeledirigidoPrefab;
    Rigidbody2D enemy;

    public GameObject Player;
    private inicialitzar getCambio;
    private bool change;
    public float xIni, yIni;

    void Awake()
    {
        enemy = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        NAVE = GameObject.FindGameObjectWithTag("Player");
        lados = NAVE.transform;
        health = 10;
    }

    void Update()
    {
        getCambio = Player.GetComponent<inicialitzar>();
        change = getCambio.cambio;

        if (change)
        {
            Enemigo.transform.localPosition = new Vector2(xIni, yIni);
            health = 10;
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player_Bullet" || col.gameObject.tag == "Player_Sword")
        {
            if (health > 1)
            {
                health--;
            }
            else
            {
                Enemigo.transform.localPosition = new Vector2(-877, -5);
            }
        }
    }
}
