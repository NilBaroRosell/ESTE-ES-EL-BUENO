using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampilla : MonoBehaviour {

    private Rigidbody2D Trampilla;


    // Use this for initialization
    void Start () {
        Trampilla = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            Destroy(gameObject);
        }
    }
}
