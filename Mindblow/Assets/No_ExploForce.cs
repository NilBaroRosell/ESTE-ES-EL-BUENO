using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No_ExploForce : MonoBehaviour {

    private Rigidbody2D Explo;

    void Awake()
    {
        Explo = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SUELO")
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;
            Destroy(gameObject);
        }
    }
}
