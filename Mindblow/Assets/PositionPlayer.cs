using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionPlayer : MonoBehaviour {

    public GameObject canon;
    public Transform transformCanon;

    public GameObject jugador;
    public Transform transformJugador;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transformJugador.localScale.x > 0)
        {
            transformCanon.localPosition = new Vector3(transformJugador.localPosition.x + 1, transformJugador.localPosition.y + 0.1f, transformJugador.localPosition.z);
        }

        if (transformJugador.localScale.x < 0)
        {
            transformCanon.localPosition = new Vector3(transformJugador.localPosition.x - 1, transformJugador.localPosition.y + 0.1f, transformJugador.localPosition.z);
        }
    }
}
