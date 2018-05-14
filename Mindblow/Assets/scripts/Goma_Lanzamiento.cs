using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goma_Lanzamiento : MonoBehaviour {

    public GameObject Enemy;

    private Transform lados;
    private Rigidbody2D Ball;

    public GameObject AreaExplo;
    public Transform transformBall;

    public float BallSpeed;
    public float BallLife;
    public string tagE;

    private bool explote = false;

    private Vector3 posicion;

    void Awake()
    {
        Ball = GetComponent<Rigidbody2D>();
        Enemy = GameObject.FindGameObjectWithTag(tagE);
        lados = Enemy.transform;
        transformBall.localRotation = Quaternion.Euler(0, 0, 0);
        posicion = new Vector3 (transformBall.localPosition.x, transformBall.localPosition.y, transformBall.localPosition.z);
    }

    // Use this for initialization
    void Start()
    {
        Ball.velocity = new Vector2(0, -BallSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (explote)
        {
            Instantiate(gameObject, posicion, transformBall.rotation);
            explote = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "SUELO")
        {
            GetComponent<ParticleSystem>().Play();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            Instantiate(AreaExplo, Ball.position, transformBall.rotation);
            Destroy(gameObject, BallLife);
            explote = true;
        }
    }

    /*public Transform Enemy;

    private Transform lados;
    private Rigidbody2D Ball;

    public GameObject AreaExplo;
    public Transform transformBall;

    public float BallSpeed;
    public float BallLife;


    void Awake()
    {
        Ball = GetComponent<Rigidbody2D>();
        lados = Enemy;
        transformBall.localRotation = Quaternion.Euler(0, 0, 0);
    }

    // Use this for initialization
    void Start()
    {
        Ball.velocity = new Vector2(0, -BallSpeed);
        transform.localScale = new Vector3(1, -1, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "SUELO")
        {
            GetComponent<ParticleSystem>().Play();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            Instantiate(AreaExplo, Ball.position, transformBall.rotation);
            Destroy(gameObject, BallLife);
        }
    }*/
}
