using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVIMIENTO : MonoBehaviour {

	public GameObject NAVE;

	private Transform lados;
	private Rigidbody2D SquareRB;

	public float SquareSpeed;
	public float SquareLife;

	void Awake()
	{
		SquareRB = GetComponent<Rigidbody2D> ();
		NAVE = GameObject.FindGameObjectWithTag ("Player");
		lados = NAVE.transform;
	}

	// Use this for initialization
	void Start () {
		if (lados.localScale.x > 0)
		{
			SquareRB.velocity = new Vector2 (SquareSpeed, SquareRB.velocity.y);
			transform.localScale = new Vector3(1, 1, 1);
		}

		else
		{
			SquareRB.velocity = new Vector2 (-SquareSpeed, SquareRB.velocity.y);
			transform.localScale = new Vector3(-1, 1, 1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, SquareLife);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Enemigo" || col.gameObject.tag == "Enemigo 2" || col.gameObject.tag == "Enemigo 3" || col.gameObject.tag == "Enemigo 4" || col.gameObject.tag == "Enemigo 5" || col.gameObject.tag == "Enemigo 6" || col.gameObject.tag == "Enemigo 7" || col.gameObject.tag == "SUELO" || col.gameObject.tag == "Enemy Ball" || col.gameObject.tag == "Enemy Ball 2" || col.gameObject.tag == "Enemy Ball 3")
		{
			GetComponent<SpriteRenderer>().enabled = false;
			GetComponent<BoxCollider2D>().enabled = false;
		}


	}
}
