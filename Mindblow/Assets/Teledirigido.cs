using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teledirigido : MonoBehaviour {

	public GameObject Polygon;
	private Transform lados;

	public GameObject NAVE;
	private Transform ladosPlayer;

	public float TeledirigidoLife;
	private Rigidbody2D TeledirigidoRB;


	void Awake()
	{
		TeledirigidoRB = GetComponent<Rigidbody2D> ();
		Polygon = GameObject.FindGameObjectWithTag ("Polygon");
		lados = Polygon.transform;
		ladosPlayer = NAVE.transform;
	}

	// Use this for initialization
	void Start () {

		TeledirigidoRB.velocity = new Vector2 ((ladosPlayer.localPosition.x - lados.localPosition.x)/5, (ladosPlayer.localPosition.y - lados.localPosition.y)/5);

	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, TeledirigidoLife);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Player") //|| col.tag == "OtroEnemigo")
		{
			GetComponent<SpriteRenderer>().enabled = false;
			GetComponent<BoxCollider2D>().enabled = false;
		}
	}
}
