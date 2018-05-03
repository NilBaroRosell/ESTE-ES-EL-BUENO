using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	Rigidbody2D player;

	public Transform NAVE;



	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {


		//if (NAVE.position.y <= 0)
	//	{
	//		NAVE.localPosition = new Vector3 (-3.66f, 1.59f, -1.0f);

			// Hay que situar a todas las cosas en su posicion y estados predeterminados
			// justo despues de pulsar el boton de reinicio.
	//	}



	}

	void OnCollisionEnter2D(Collision2D col)
	{
        if (col.gameObject.tag == "Enemigo" || col.gameObject.tag == "Enemigo 2" || col.gameObject.tag == "Enemigo 3" || col.gameObject.tag == "Enemigo 4" || col.gameObject.tag == "Enemigo 5" || col.gameObject.tag == "Enemigo 6" || col.gameObject.tag == "Enemigo 7" || col.gameObject.tag == "Elemento Nocivo" || col.gameObject.tag == "Elemento Nocivo 2") //|| col.tag == "OtroEnemigo")
        {
            player.velocity = new Vector2(-25, 25);
        }

		if(col.gameObject.tag == "Teledirigido") //|| col.tag == "OtroEnemigo")
		{
			player.velocity = new Vector2 (0, 5);
		}

        if (col.gameObject.tag == "Trampolin") //|| col.tag == "OtroEnemigo")
        {
            player.velocity = new Vector2(0, 100);
        }

        if (col.gameObject.tag == "Curs Navet")
        {
            SceneManager.LoadScene("prova", LoadSceneMode.Single);
        }

    }
}
