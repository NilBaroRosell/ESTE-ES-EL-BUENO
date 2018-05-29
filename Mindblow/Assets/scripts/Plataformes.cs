using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformes : MonoBehaviour {

    public bool direccion1; // vertical = true, horizontal = false
    public bool sentido1; // si es vertical: arriba = true, abajo = false; si es horizontal: derecha = true, izquierda = false

    public float minX, maxX, minY, maxY;

    public float velocidad;

    private bool hasPlayer = false;

    public GameObject Player;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        if (direccion1)
        {
            if (sentido1)
            {
                if (transform.localPosition.y < maxY) transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + velocidad, transform.localPosition.z);

                else sentido1 = false;
            }

            else
            {
                if (transform.localPosition.y > minY) transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - velocidad, transform.localPosition.z);

                else sentido1 = true;
            }
        }

        else
        {
            if (sentido1)
            {
                if (transform.localPosition.x < maxX) transform.localPosition = new Vector3(transform.localPosition.x + velocidad, transform.localPosition.y, transform.localPosition.z);

                else sentido1 = false;

                if (hasPlayer) Player.transform.localPosition = new Vector3(Player.transform.localPosition.x + velocidad, Player.transform.localPosition.y, Player.transform.localPosition.z);
            }

            else
            {
                if (transform.localPosition.x > minX) transform.localPosition = new Vector3(transform.localPosition.x - velocidad, transform.localPosition.y, transform.localPosition.z);

                else sentido1 = true;

                if (hasPlayer) Player.transform.localPosition = new Vector3(Player.transform.localPosition.x - velocidad, Player.transform.localPosition.y, Player.transform.localPosition.z);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") hasPlayer = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") hasPlayer = false;
    }
}
