﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inicialitzar : MonoBehaviour {

    public GameObject jugador;
    public GameObject enemigo1;
    public GameObject enemigo2;
    public GameObject enemigo3;
    public GameObject enemigo4;
    public GameObject enemigo5;
    public GameObject enemigo6;
    public GameObject enemigo7;
    public GameObject enemigo8;
    public GameObject enemigo9;
    public GameObject enemigo10;
    public GameObject enemigo11;
    public GameObject enemigo12;
    public GameObject enemigo13;
    public GameObject enemigo14;
    public GameObject enemigo15;
    public GameObject enemigo16;
    public GameObject enemigo17;
    public GameObject enemigo18;
    public GameObject enemigo19;
    public GameObject enemigo20;
    public GameObject enemigo21;
    public GameObject enemigo22;
    public GameObject enemigo23;
    public GameObject enemigo24;
    public GameObject enemigo25;
    public GameObject enemigo26;
    public GameObject enemigo27;
    public GameObject enemigo28;
    public GameObject enemigo29;
    public GameObject enemigo30;
    public GameObject enemigo31;
    public GameObject enemigo32;
    public GameObject enemigo33;
    public GameObject enemigo34;
    public GameObject enemigo35;
    public GameObject camara;
    private PlayerManager getDamagePM;
    public GameObject Player;
    private GameControl getDamageGC;
    private float nVida;
    private int checkPoints;

    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");

        enemigo1 = GameObject.FindGameObjectWithTag("Enemigo");
        enemigo2 = GameObject.FindGameObjectWithTag("Enemigo 5");
        enemigo3 = GameObject.FindGameObjectWithTag("Enemigo 9");
        enemigo4 = GameObject.FindGameObjectWithTag("Enemigo 8");
        enemigo5 = GameObject.FindGameObjectWithTag("Enemigo 10");
        enemigo6 = GameObject.FindGameObjectWithTag("Enemigo 11");
        enemigo7 = GameObject.FindGameObjectWithTag("Enemigo 12");
        enemigo8 = GameObject.FindGameObjectWithTag("Enemigo 13");
        enemigo9 = GameObject.FindGameObjectWithTag("Enemigo 14");
        enemigo10 = GameObject.FindGameObjectWithTag("Enemigo 15");

        enemigo11 = GameObject.FindGameObjectWithTag("Enemigo 2");
        enemigo12 = GameObject.FindGameObjectWithTag("Enemigo 3");
        enemigo13 = GameObject.FindGameObjectWithTag("Enemigo 4");
        enemigo14 = GameObject.FindGameObjectWithTag("Enemigo 6");
        enemigo15 = GameObject.FindGameObjectWithTag("Enemigo 7");

        enemigo16 = GameObject.FindGameObjectWithTag("Dibujante 1");
        enemigo17 = GameObject.FindGameObjectWithTag("Dibujante 2");

        enemigo18 = GameObject.FindGameObjectWithTag("Dibujante 3");
        enemigo19 = GameObject.FindGameObjectWithTag("Lanzador de Esferas");
        enemigo20 = GameObject.FindGameObjectWithTag("Justice Flash");
        enemigo21 = GameObject.FindGameObjectWithTag("Dibujante 5");
        enemigo22 = GameObject.FindGameObjectWithTag("Dibujante 4");
        enemigo23 = GameObject.FindGameObjectWithTag("Enemigo 16");
        enemigo24 = GameObject.FindGameObjectWithTag("Enemigo 17");
        enemigo25 = GameObject.FindGameObjectWithTag("Enemigo 18");
        enemigo26 = GameObject.FindGameObjectWithTag("Enemigo 19");

        enemigo27 = GameObject.FindGameObjectWithTag("Boss 2");

        enemigo28 = GameObject.FindGameObjectWithTag("Enemigo 3.1");
        enemigo29 = GameObject.FindGameObjectWithTag("Laser Pistol 1");
        enemigo30 = GameObject.FindGameObjectWithTag("Laser Pistol 2");
        enemigo31 = GameObject.FindGameObjectWithTag("Enemigo 3.2");
        enemigo32 = GameObject.FindGameObjectWithTag("Enemigo 3.3");
        enemigo33 = GameObject.FindGameObjectWithTag("Enemigo 3.4");
        enemigo34 = GameObject.FindGameObjectWithTag("Mortero 3");
        enemigo35 = GameObject.FindGameObjectWithTag("Mortero 1");

        camara = GameObject.FindGameObjectWithTag("Main Camara");

        enemigo1.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo2.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo3.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo4.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo5.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo6.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo7.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo8.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo9.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo10.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo11.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo12.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo13.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo14.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo15.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo16.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo17.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo18.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo19.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo20.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo21.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo22.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo23.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo24.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo25.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo26.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo27.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo28.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo29.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo30.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo31.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo32.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo33.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo34.transform.localRotation = Quaternion.Euler(0, 0, 0);
        enemigo35.transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        getDamagePM = Player.GetComponent<PlayerManager>();
        nVida = getDamagePM.Vida;
        getDamageGC = Player.GetComponent<GameControl>();
        checkPoints = getDamageGC.checkPoint;
        if (nVida < 1)
        {
            switch (checkPoints)
            {
                case 0:
                    {
                        SceneManager.LoadScene(sceneBuildIndex: 1);
                        break;
                    }
                case 1:
                    {
                        jugador.transform.localPosition = new Vector3((float)15, (float)-14, jugador.transform.localPosition.z);
                        //camara.transform.localPosition = new Vector3(jugador.transform.localPosition.x, jugador.transform.localPosition.y + (float)3.67, camara.transform.localPosition.z);

                        Destroy(enemigo1);
                        Instantiate(enemigo1, enemigo1.transform.localPosition, enemigo1.transform.localRotation);
                        Destroy(enemigo2);
                        Instantiate(enemigo2, enemigo2.transform.localPosition, enemigo2.transform.localRotation);
                        Destroy(enemigo3);
                        Instantiate(enemigo3, enemigo3.transform.localPosition, enemigo3.transform.localRotation);
                        Destroy(enemigo4);
                        Instantiate(enemigo4, enemigo4.transform.localPosition, enemigo4.transform.localRotation);
                        Destroy(enemigo5);
                        Instantiate(enemigo5, enemigo5.transform.localPosition, enemigo5.transform.localRotation);
                        Destroy(enemigo6);
                        Instantiate(enemigo6, enemigo6.transform.localPosition, enemigo6.transform.localRotation);
                        Destroy(enemigo7);
                        Instantiate(enemigo7, enemigo7.transform.localPosition, enemigo7.transform.localRotation);
                        Destroy(enemigo8);
                        Instantiate(enemigo8, enemigo8.transform.localPosition, enemigo8.transform.localRotation);
                        Destroy(enemigo9);
                        Instantiate(enemigo9, enemigo9.transform.localPosition, enemigo9.transform.localRotation);
                        Destroy(enemigo10);
                        Instantiate(enemigo10, enemigo10.transform.localPosition, enemigo10.transform.localRotation);

                        break;
                    }
                /*case 2:
                    {

                        transformJugador.localPosition = new Vector3(28, (float)-24.5, transformJugador.localPosition.z);
                        break;
                    }
                case 3:
                    {

                        transformJugador.localPosition = new Vector3((float)162.24, (float)-8.56, transformJugador.localPosition.z);
                        break;
                    }
                case 4:
                    {

                        transformJugador.localPosition = new Vector3(233, (float)-6.5, transformJugador.localPosition.z);
                        break;
                    }
                case 5:
                    {

                        transformJugador.localPosition = new Vector3(183, (float)-6.5, transformJugador.localPosition.z);
                        break;
                    }
                case 6:
                    {

                        transformJugador.localPosition = new Vector3((float)405.3, (float)-11.93, transformJugador.localPosition.z);
                        break;
                    }
                case 7:
                    {

                        transformJugador.localPosition = new Vector3(457, -37, transformJugador.localPosition.z);
                        break;
                    }
                case 8:
                    {

                        transformJugador.localPosition = new Vector3(428, (float)-55.5, transformJugador.localPosition.z);
                        break;
                    }
                case 9:
                    {

                        transformJugador.localPosition = new Vector3(468, -68, transformJugador.localPosition.z);
                        break;
                    }*/
                default:
                    {
                        break;
                    }
            }
        }
    }
}