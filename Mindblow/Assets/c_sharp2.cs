using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_sharp2 : MonoBehaviour {

    public float minForce = -10.0f;
    public float maxForce = 10.0f;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(minForce, maxForce), Random.Range(minForce, maxForce)));
    }

    // Update is called once per frame
    void Update () {
		
	}
}
