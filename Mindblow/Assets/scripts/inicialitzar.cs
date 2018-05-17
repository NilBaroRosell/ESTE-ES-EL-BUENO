using System.Collections;
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
    public bool cambio = false;

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

        camara = GameObject.FindGameObjectWithTag("MainCamera");

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
                        jugador.transform.localPosition = new Vector3((float)15, (float)-5, jugador.transform.localPosition.z);
                        
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

                        cambio = true;

                        break;
                    }
                case 2:
                    {
                        jugador.transform.localPosition = new Vector3(28, (float)-24.5, jugador.transform.localPosition.z);

                        Destroy(enemigo11);
                        Instantiate(enemigo11, enemigo11.transform.localPosition, enemigo11.transform.localRotation);
                        Destroy(enemigo12);
                        Instantiate(enemigo12, enemigo12.transform.localPosition, enemigo12.transform.localRotation);
                        Destroy(enemigo13);
                        Instantiate(enemigo13, enemigo13.transform.localPosition, enemigo13.transform.localRotation);
                        Destroy(enemigo14);
                        Instantiate(enemigo14, enemigo14.transform.localPosition, enemigo14.transform.localRotation);
                        Destroy(enemigo15);
                        Instantiate(enemigo15, enemigo15.transform.localPosition, enemigo15.transform.localRotation);

                        cambio = true;

                        break;
                    }
                case 3:
                    {
                        jugador.transform.localPosition = new Vector3((float)162.24, (float)-8.56, jugador.transform.localPosition.z);

                        Destroy(enemigo16);
                        Instantiate(enemigo16, enemigo16.transform.localPosition, enemigo16.transform.localRotation);
                        Destroy(enemigo17);
                        Instantiate(enemigo17, enemigo17.transform.localPosition, enemigo17.transform.localRotation);

                        cambio = true;

                        break;
                    }
                case 4:
                    {
                        jugador.transform.localPosition = new Vector3(233, (float)-6.5, jugador.transform.localPosition.z);

                        Destroy(enemigo18);
                        Instantiate(enemigo18, enemigo18.transform.localPosition, enemigo18.transform.localRotation);
                        Destroy(enemigo19);
                        Instantiate(enemigo19, enemigo19.transform.localPosition, enemigo19.transform.localRotation);
                        Destroy(enemigo20);
                        Instantiate(enemigo20, enemigo20.transform.localPosition, enemigo20.transform.localRotation);
                        Destroy(enemigo21);
                        Instantiate(enemigo21, enemigo21.transform.localPosition, enemigo21.transform.localRotation);
                        Destroy(enemigo22);
                        Instantiate(enemigo22, enemigo22.transform.localPosition, enemigo22.transform.localRotation);
                        Destroy(enemigo23);
                        Instantiate(enemigo23, enemigo23.transform.localPosition, enemigo23.transform.localRotation);
                        Destroy(enemigo24);
                        Instantiate(enemigo24, enemigo24.transform.localPosition, enemigo24.transform.localRotation);
                        Destroy(enemigo25);
                        Instantiate(enemigo25, enemigo25.transform.localPosition, enemigo25.transform.localRotation);
                        Destroy(enemigo26);
                        Instantiate(enemigo26, enemigo26.transform.localPosition, enemigo26.transform.localRotation);

                        cambio = true;

                        break;
                    }
                case 5:
                    {
                        jugador.transform.localPosition = new Vector3(183, (float)-6.5, jugador.transform.localPosition.z);

                        Destroy(enemigo27);
                        Instantiate(enemigo27, enemigo27.transform.localPosition, enemigo27.transform.localRotation);

                        cambio = true;

                        break;
                    }
                case 6:
                    {
                        jugador.transform.localPosition = new Vector3((float)405.3, (float)-11.93, jugador.transform.localPosition.z);

                        Destroy(enemigo28);
                        Instantiate(enemigo28, enemigo28.transform.localPosition, enemigo28.transform.localRotation);
                        Destroy(enemigo29);
                        Instantiate(enemigo29, enemigo29.transform.localPosition, enemigo29.transform.localRotation);
                        Destroy(enemigo30);
                        Instantiate(enemigo30, enemigo30.transform.localPosition, enemigo30.transform.localRotation);

                        cambio = true;

                        break;
                    }
                case 7:
                    {
                        jugador.transform.localPosition = new Vector3(457, -37, jugador.transform.localPosition.z);

                        Destroy(enemigo31);
                        Instantiate(enemigo31, enemigo31.transform.localPosition, enemigo31.transform.localRotation);

                        cambio = true;

                        break;
                    }
                case 8:
                    {
                        jugador.transform.localPosition = new Vector3(428, (float)-55.5, jugador.transform.localPosition.z);

                        Destroy(enemigo32);
                        Instantiate(enemigo32, enemigo32.transform.localPosition, enemigo32.transform.localRotation);
                        Destroy(enemigo33);
                        Instantiate(enemigo33, enemigo33.transform.localPosition, enemigo33.transform.localRotation);
                        Destroy(enemigo34);
                        Instantiate(enemigo34, enemigo34.transform.localPosition, enemigo34.transform.localRotation);

                        cambio = true;

                        break;
                    }
                case 9:
                    {
                        jugador.transform.localPosition = new Vector3(468, -68, jugador.transform.localPosition.z);

                        Destroy(enemigo35);
                        Instantiate(enemigo35, enemigo35.transform.localPosition, enemigo35.transform.localRotation);

                        cambio = true;

                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        else cambio = false;
    }
}
