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
