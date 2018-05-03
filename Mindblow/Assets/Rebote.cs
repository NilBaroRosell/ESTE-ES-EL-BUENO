using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebote : MonoBehaviour {

    public GameObject bola;
    public float bolaSpeed;

    private Transform boi;
    private Rigidbody2D pepe;

    void Awake()
    {
        pepe = GetComponent<Rigidbody2D>();
        bola = GameObject.FindGameObjectWithTag("Player");
        boi = bola.transform;
    }

    void Start()
    {
        pepe.velocity = new Vector2(pepe.velocity.x, bolaSpeed);
    }

    void Update()
    {
        pepe.velocity = new Vector2(pepe.velocity.x, bolaSpeed);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "SUELO" || col.gameObject.tag == "Player")
        {
            bolaSpeed *= -1;
        }
    }
}
