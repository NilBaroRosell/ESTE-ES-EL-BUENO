using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion_compas : MonoBehaviour {

    public GameObject compas;
    public Transform transformCompas;

    float value;

    private void Awake()
    {
    }

    // Use this for initialization
    void Start () {
        value = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        value += 3;
        transformCompas.rotation = Quaternion.Euler(0,0,value);
	}

    private void FixedUpdate()
    {
        
    }
}
