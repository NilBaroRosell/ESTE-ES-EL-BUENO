using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour {

    public GameObject jugador;
    public Transform transformJugador;

    public GameObject enemigo;
    public Transform transformEnemigo;
    public GameObject enemigo2;
    public Transform transformEnemigo2;
    public GameObject enemigo3;
    public Transform transformEnemigo3;
    public GameObject enemigo4;
    public Transform transformEnemigo4;
    public GameObject enemigo5;
    public Transform transformEnemigo5;
    public GameObject enemigo6;
    public Transform transformEnemigo6;
    public GameObject enemigo7;
    public Transform transformEnemigo7;

    public GameObject enemyBall;
    public Transform transformEnemyBall;
    public GameObject enemyBall2;
    public Transform transformEnemyBall2;
    public GameObject enemyBall3;
    public Transform transformEnemyBall3;

    public GameObject rebotante1;
    public Transform transformRebotante1;
    public GameObject rebotante2;
    public Transform transformRebotante2;
    public GameObject rebotante3;
    public Transform transformRebotante3;
    public GameObject rebotante4;
    public Transform transformRebotante4;
    public GameObject rebotante5;
    public Transform transformRebotante5;
    public GameObject rebotante6;
    public Transform transformRebotante6;
    public GameObject rebotante7;
    public Transform transformRebotante7;



    public GameObject pinchos;
    public Transform transformPinchos;
    public GameObject pinchos2;
    public Transform transformPinchos2;

    public Image vida;
    public float numVida;

    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        transformJugador = jugador.transform;


        enemigo = GameObject.FindGameObjectWithTag("Enemigo");
        transformEnemigo = enemigo.transform;
        enemigo2 = GameObject.FindGameObjectWithTag("Enemigo 2");
        transformEnemigo2 = enemigo2.transform;
        enemigo3 = GameObject.FindGameObjectWithTag("Enemigo 3");
        transformEnemigo3 = enemigo3.transform;
        enemigo4 = GameObject.FindGameObjectWithTag("Enemigo 4");
        transformEnemigo4 = enemigo4.transform;
        enemigo5 = GameObject.FindGameObjectWithTag("Enemigo 5");
        transformEnemigo5 = enemigo5.transform;
        enemigo6 = GameObject.FindGameObjectWithTag("Enemigo 6");
        transformEnemigo6 = enemigo6.transform;
        enemigo7 = GameObject.FindGameObjectWithTag("Enemigo 7");
        transformEnemigo7 = enemigo7.transform;

        pinchos = GameObject.FindGameObjectWithTag("Elemento Nocivo");
        transformPinchos = pinchos.transform;
        pinchos2 = GameObject.FindGameObjectWithTag("Elemento Nocivo 2");
        transformPinchos2 = pinchos2.transform;

        rebotante1 = GameObject.FindGameObjectWithTag("Rebotante 1");
        transformRebotante1 = rebotante1.transform;
        rebotante2 = GameObject.FindGameObjectWithTag("Rebotante 2");
        transformRebotante2 = rebotante2.transform;
        rebotante3 = GameObject.FindGameObjectWithTag("Rebotante 3");
        transformRebotante3 = rebotante3.transform;
        rebotante4 = GameObject.FindGameObjectWithTag("Rebotante 4");
        transformRebotante4 = rebotante4.transform;
        rebotante5 = GameObject.FindGameObjectWithTag("Rebotante 5");
        transformRebotante5 = rebotante5.transform;
        rebotante6 = GameObject.FindGameObjectWithTag("Rebotante 6");
        transformRebotante6 = rebotante6.transform;
        rebotante7 = GameObject.FindGameObjectWithTag("Rebotante 7");
        transformRebotante7 = rebotante7.transform;

        enemyBall = GameObject.FindGameObjectWithTag("Enemy Ball");
        transformEnemyBall = enemyBall.transform;
        enemyBall2 = GameObject.FindGameObjectWithTag("Enemy Ball 2");
        transformEnemyBall2 = enemyBall2.transform;
        enemyBall3 = GameObject.FindGameObjectWithTag("Enemy Ball 3");
        transformEnemyBall3 = enemyBall3.transform;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void FixedUpdate()
    {
        if (numVida < 1)
        {
            SceneManager.LoadScene(sceneBuildIndex: 1);
        }

        if (((Mathf.Abs(transformJugador.localPosition.x - transformEnemigo.localPosition.x) <= 1.1 || Mathf.Abs(transformEnemigo.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemigo2.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo2.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemigo3.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo3.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemigo4.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo4.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemigo5.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo5.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemigo6.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo6.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemigo7.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemigo7.localPosition.y) <= 1.1)) ||

           ((Mathf.Abs(transformEnemyBall.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemyBall.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemyBall2.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemyBall2.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformEnemyBall3.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformEnemyBall3.localPosition.y) <= 1.1)) ||

           ((Mathf.Abs(transformRebotante1.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformRebotante1.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformRebotante2.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformRebotante2.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformRebotante3.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformRebotante3.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformRebotante4.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformRebotante4.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformRebotante5.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformRebotante5.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformRebotante6.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformRebotante6.localPosition.y) <= 1.1)) ||
           ((Mathf.Abs(transformRebotante7.localPosition.x - transformJugador.localPosition.x) <= 1.1) && (Mathf.Abs(transformJugador.localPosition.y - transformRebotante7.localPosition.y) <= 1.1)) ||

           ((Mathf.Abs(transformPinchos.localPosition.x - transformJugador.localPosition.x) <= 1.6) && (Mathf.Abs(transformJugador.localPosition.y - transformPinchos.localPosition.y) <= 0.75)) ||
           ((Mathf.Abs(transformPinchos2.localPosition.x - transformJugador.localPosition.x) <= 1.6) && (Mathf.Abs(transformJugador.localPosition.y - transformPinchos2.localPosition.y) <= 0.75))
           )
        {
            numVida -= 2;
            vida.fillAmount = numVida / 100;
        }
    }
}
