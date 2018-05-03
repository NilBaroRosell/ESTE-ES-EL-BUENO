using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Inmortal : MonoBehaviour {

    float health;

    public Transform Enemigo;
    public GameObject NAVE;
    private Transform lados;
    public GameObject TeledirigidoPrefab;
    Rigidbody2D enemy;

    void Awake()
    {
        enemy = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        NAVE = GameObject.FindGameObjectWithTag("Player");
        lados = NAVE.transform;
        health = 99;
    }

    void Update()
    {
        //lados = NAVE.transform;
        //counter = Time.deltaTime;

        //if(counter % 2 == 0 && lados.transform.localPosition.x < 10)//La distancia x respecto al enemigo en un area movil
        //{
        //	Instantiate (TeledirigidoPrefab, Enemigo.position, Enemigo.rotation);
        //}
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
                Destroy(gameObject);
            }
        }
    }
}
