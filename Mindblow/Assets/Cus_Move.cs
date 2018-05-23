using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cus_Move : MonoBehaviour {

    public Rigidbody2D Cursa;
    public GameObject jugador;
    public GameObject bola;
    public Transform transformCurs;
    float value;

    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        bola = GameObject.FindGameObjectWithTag("Curs Navet");
    }

    // Use this for initialization
    void Start () {
        Cursa = GetComponent<Rigidbody2D>();
        value = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (jugador.transform.localPosition.y >= -81 && jugador.transform.localPosition.y <= -70)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(6, 0));
            value -= 0.25f;
            transformCurs.rotation = Quaternion.Euler(0, 0, value);
        }

        else
        {
            bola.transform.localPosition = new Vector2((float)-77.56, (float)-77.62);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player_Bullet")
        {
            value = 0;
            bola.transform.localPosition = new Vector2((float)-77.56, (float)-77.62);
            transformCurs.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
