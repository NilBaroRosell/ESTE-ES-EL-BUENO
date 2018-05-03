using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cus_Move : MonoBehaviour {

    public Rigidbody2D Cursa;
    public GameObject jugador;
    public GameObject bola;

    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        bola = GameObject.FindGameObjectWithTag("Curs Navet");
    }

    // Use this for initialization
    void Start () {
        Cursa = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (jugador.transform.localPosition.y >= -81 && jugador.transform.localPosition.y <= -70)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(3, 0));
        }

        else
        {
            bola.transform.localPosition = new Vector2((float)-78.08, (float)-78.84);
        }
    }
}
