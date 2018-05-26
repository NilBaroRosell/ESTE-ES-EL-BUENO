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
        if (col.gameObject.tag == "Enemigo" ||
            col.gameObject.tag == "Enemigo 2" ||
            col.gameObject.tag == "Enemigo 3" ||
            col.gameObject.tag == "Enemigo 4" ||
            col.gameObject.tag == "Enemigo 5" ||
            col.gameObject.tag == "Enemigo 6" ||
            col.gameObject.tag == "Enemigo 7" ||
            col.gameObject.tag == "SUELO" ||
            col.gameObject.tag == "Enemy Ball" ||
            col.gameObject.tag == "Enemy Ball 2" ||
            col.gameObject.tag == "Enemy Ball 3" ||
            col.gameObject.tag == "Enemy Ball 4" ||
            col.gameObject.tag == "Enemy Ball 5" ||
            col.gameObject.tag == "Enemy Ball 6" ||
            col.gameObject.tag == "Enemy Ball 7" ||
            col.gameObject.tag == "Enemy Ball 8" ||
            col.gameObject.tag == "Enemy Ball 9" ||
            col.gameObject.tag == "Elemento Nocivo" ||
            col.gameObject.tag == "Elemento Nocivo 2" ||
            col.gameObject.tag == "Rebotante 1" ||
            col.gameObject.tag == "Rebotante 2" ||
            col.gameObject.tag == "Rebotante 3" ||
            col.gameObject.tag == "Rebotante 4" ||
            col.gameObject.tag == "Rebotante 5" ||
            col.gameObject.tag == "Rebotante 6" ||
            col.gameObject.tag == "Rebotante 7" ||
            col.gameObject.tag == "Rebotante 8" ||
            col.gameObject.tag == "Rebotante 9" ||
            col.gameObject.tag == "Rebotante 10" ||
            col.gameObject.tag == "Rebotante 11" ||
            col.gameObject.tag == "Rebotante 12" ||
            col.gameObject.tag == "Rebotante 13" ||
            col.gameObject.tag == "Rebotante 14" ||

            col.gameObject.tag == "Enemigo 8" ||
            col.gameObject.tag == "Enemigo 9" ||
            col.gameObject.tag == "Enemigo 10" ||
            col.gameObject.tag == "Enemigo 11" ||
            col.gameObject.tag == "Enemigo 12" ||
            col.gameObject.tag == "Enemigo 13" ||
            col.gameObject.tag == "Enemigo 14" ||
            col.gameObject.tag == "Enemigo 15" ||

            col.gameObject.tag == "Compas" ||
            col.gameObject.tag == "Dibujante 1" ||
            col.gameObject.tag == "Dibujante 2" ||
            col.gameObject.tag == "Dibujante 3" ||
            col.gameObject.tag == "Dibujante 4" ||
            col.gameObject.tag == "Dibujante 5" ||
            col.gameObject.tag == "Lanzador de Esferas" ||
            col.gameObject.tag == "Justice Flash" ||
            col.gameObject.tag == "Boss 2" ||

            col.gameObject.tag == "Enemigo 16" ||
            col.gameObject.tag == "Enemigo 17" ||
            col.gameObject.tag == "Enemigo 18" ||
            col.gameObject.tag == "Enemigo 19" ||

            col.gameObject.tag == "Enemigo 3.1" ||
            col.gameObject.tag == "Enemigo 3.2" ||
            col.gameObject.tag == "Enemigo 3.3" ||
            col.gameObject.tag == "Enemigo 3.4" ||
            col.gameObject.tag == "Mortero 1" ||
            col.gameObject.tag == "Mortero 3" ||
            col.gameObject.tag == "Laser Pistol 1" ||
            col.gameObject.tag == "Laser Pistol 2" ||
            col.gameObject.tag == "Zona Laser" ||
            col.gameObject.tag == "MiniBoss" ||
            col.gameObject.tag == "Boss 3")

		{
			GetComponent<SpriteRenderer>().enabled = false;
			GetComponent<BoxCollider2D>().enabled = false;
		}


	}
}
