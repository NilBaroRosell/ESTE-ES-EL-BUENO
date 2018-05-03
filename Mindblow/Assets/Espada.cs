using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour {

	public GameObject NAVE;

	private Transform lados;
	private Rigidbody2D EspadaRB;

	public float EspadaSpeed;
	public float EspadaLife;

	void Awake()
	{
		EspadaRB = GetComponent<Rigidbody2D> ();
		NAVE = GameObject.FindGameObjectWithTag ("Player");
		lados = NAVE.transform;
	}


	// Use this for initialization
	void Start () {
		if (lados.localScale.x > 0)
		{
			transform.localScale = new Vector3(1, 1, 1);
		}

		else
		{
			transform.localScale = new Vector3(-1, 1, 1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, EspadaLife/10);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Polygon") //|| col.tag == "OtroEnemigo")
		{
			GetComponent<SpriteRenderer>().enabled = false;
			GetComponent<BoxCollider2D>().enabled = false;
		}
	}

}
