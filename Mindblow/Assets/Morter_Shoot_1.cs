﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morter_Shoot_1 : MonoBehaviour {

    public GameObject Enemy;

    private Transform lados;
    private Rigidbody2D Ball;

    public GameObject AreaExplo;
    public Transform transformBall;

    public float BallSpeed;
    public float BallLife;


    void Awake()
    {
        Ball = GetComponent<Rigidbody2D>();
        Enemy = GameObject.FindGameObjectWithTag("Mortero 1");
        lados = Enemy.transform;
        transformBall.localRotation = Quaternion.Euler(0, 0, 0);
    }

    // Use this for initialization
    void Start()
    {
        if (lados.localScale.x > 0)
        {
            Ball.velocity = new Vector2(BallSpeed, 0);
            transform.localScale = new Vector3(1, 1, 1);
        }

        else
        {
            Ball.velocity = new Vector2(-BallSpeed, 0);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Player_Bullet" || col.gameObject.tag == "Player_Sword" || col.gameObject.tag == "Enemigo 3.1" || col.gameObject.tag == "Enemigo 3.2" || col.gameObject.tag == "SUELO")
        {
            GetComponent<ParticleSystem>().Play();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            Instantiate(AreaExplo, Ball.position, transformBall.rotation);
            Destroy(gameObject, BallLife);
        }
    }
}