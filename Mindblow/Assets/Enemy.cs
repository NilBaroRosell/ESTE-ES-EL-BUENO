using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour {

    float health;

	public Transform Enemigo;
	public GameObject NAVE;
	private Transform lados;
	public GameObject TeledirigidoPrefab;
	Rigidbody2D enemy;
    bool damage;

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

