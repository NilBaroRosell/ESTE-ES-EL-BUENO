using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion_portal : MonoBehaviour {

    public GameObject Enemy;
    public GameObject compas;
    public Transform transformCompas;
    float change;
    float value;
    public string numeroPortal;
    private Enemy_Boss vidaEnemigo;
    // Use this for initialization
    void Start()
    {
        Enemy = GameObject.FindGameObjectWithTag("Boss 3");
        value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        value -= 20;
        transformCompas.rotation = Quaternion.Euler(0, 0, value);
        vidaEnemigo = Enemy.GetComponent<Enemy_Boss>();
        change = vidaEnemigo.health;
        if (numeroPortal == "1" && change <= 9)
        {
            transformCompas.localPosition = new Vector2(439,-86);
        }

        if (numeroPortal == "2" && change < 8)
        {
            transformCompas.localPosition = new Vector2(419.44f, -76.59f);
        }
    }
}
