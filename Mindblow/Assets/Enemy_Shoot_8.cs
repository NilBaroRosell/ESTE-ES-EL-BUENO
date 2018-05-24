using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shoot_8 : MonoBehaviour {

    public GameObject Enemy;

    private Transform lados;
    private Rigidbody2D Ball;
    public Transform transformDisparo;

    public float BallSpeed;
    public float BallLife;


    void Awake()
    {
        Ball = GetComponent<Rigidbody2D>();
        Enemy = GameObject.FindGameObjectWithTag("Justice Flash");
        lados = Enemy.transform;
        transformDisparo.rotation = Quaternion.Euler(0, 0, 90);
    }

    // Use this for initialization
    void Start()
    {
        if (lados.localScale.x > 0)
        {
            Ball.velocity = new Vector2(BallSpeed, 0);
            transform.localScale = new Vector3(0.3247087f, 0.1510788f, 1);
        }

        else
        {
            Ball.velocity = new Vector2(BallSpeed, 0);
            transform.localScale = new Vector3(0.3247087f, 0.1510788f, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, BallLife);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Player_Bullet" || col.gameObject.tag == "Player_Sword")
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
