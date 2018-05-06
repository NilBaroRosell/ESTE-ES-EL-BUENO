using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prova3 : MonoBehaviour {

    public GameObject jugador;
    public Transform transformJugador;
    public GameObject Palanca, Palanca2, Palanca3, Palanca4, Palanca5, Palanca6, Palanca7, Palanca8, Palanca9;
    public Transform transformPalanca, transformPalanca2, transformPalanca3, transformPalanca4, transformPalanca5, transformPalanca6, transformPalanca7, transformPalanca8, transformPalanca9;
    public GameObject Pinchos, Pinchos2, Pinchos3, Pinchos4, Pinchos5, Pinchos6, Pinchos7, Pinchos8, Pinchos9;
    public Transform transformPinchos, transformPinchos2, transformPinchos3, transformPinchos4, transformPinchos5, transformPinchos6, transformPinchos7, transformPinchos8, transformPinchos9;
    public GameObject Pared, Pared2, Pared3, Pared4, Pared5, Pared6, Pared7, Pared8, Pared9;
    public Transform transformPared, transformPared2, transformPared3, transformPared4, transformPared5, transformPared6, transformPared7, transformPared8, transformPared9;
    public bool pinchos1, pinchos2, pinchos3, pinchos4, pinchos5, pinchos6, pinchos7, pinchos8, pinchos9;
    public float yMax1, yMin1, yMax2, yMin2;
    

    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        transformJugador = jugador.transform;

        Palanca = GameObject.FindGameObjectWithTag("Palanca");
        transformPalanca = Palanca.transform;
        Palanca2 = GameObject.FindGameObjectWithTag("Palanca 2");
        transformPalanca2 = Palanca2.transform;
        Palanca3 = GameObject.FindGameObjectWithTag("Palanca 3");
        transformPalanca3 = Palanca3.transform;
        Palanca4 = GameObject.FindGameObjectWithTag("Palanca 4");
        transformPalanca4 = Palanca4.transform;
        Palanca5 = GameObject.FindGameObjectWithTag("Palanca 5");
        transformPalanca5 = Palanca5.transform;
        Palanca6 = GameObject.FindGameObjectWithTag("Palanca 6");
        transformPalanca6 = Palanca6.transform;
        Palanca7 = GameObject.FindGameObjectWithTag("Palanca7");
        transformPalanca7 = Palanca7.transform;
        Palanca8 = GameObject.FindGameObjectWithTag("Palanca 8");
        transformPalanca8 = Palanca8.transform;
        Palanca9 = GameObject.FindGameObjectWithTag("Palanca 9");
        transformPalanca9 = Palanca9.transform;

        Pinchos = GameObject.FindGameObjectWithTag("Pinchos 1");
        transformPinchos = Pinchos.transform;
        Pinchos2 = GameObject.FindGameObjectWithTag("Pinchos 2");
        transformPinchos2 = Pinchos2.transform;
        Pinchos3 = GameObject.FindGameObjectWithTag("Pinchos 3");
        transformPinchos3 = Pinchos3.transform;
        Pinchos4 = GameObject.FindGameObjectWithTag("Pinchos 4");
        transformPinchos4 = Pinchos4.transform;
        Pinchos5 = GameObject.FindGameObjectWithTag("Pinchos 5");
        transformPinchos5 = Pinchos5.transform;
        Pinchos6 = GameObject.FindGameObjectWithTag("Pinchos 6");
        transformPinchos6 = Pinchos6.transform;
        Pinchos7 = GameObject.FindGameObjectWithTag("Pinchos 7");
        transformPinchos7 = Pinchos7.transform;
        Pinchos8 = GameObject.FindGameObjectWithTag("Pinchos 8");
        transformPinchos8 = Pinchos8.transform;
        Pinchos9 = GameObject.FindGameObjectWithTag("Pinchos 9");
        transformPinchos9 = Pinchos9.transform;

        Pared = GameObject.FindGameObjectWithTag("Pared 1");
        transformPared = Pared.transform;
        Pared2 = GameObject.FindGameObjectWithTag("Pared 2");
        transformPared2 = Pared2.transform;
        Pared3 = GameObject.FindGameObjectWithTag("Pared 3");
        transformPared3 = Pared3.transform;
        Pared4 = GameObject.FindGameObjectWithTag("Pared 4");
        transformPared4 = Pared4.transform;
        Pared5 = GameObject.FindGameObjectWithTag("Pared 5");
        transformPared5 = Pared5.transform;
        Pared6 = GameObject.FindGameObjectWithTag("Pared 6");
        transformPared6 = Pared6.transform;
        Pared7 = GameObject.FindGameObjectWithTag("Pared 7");
        transformPared7 = Pared7.transform;
        Pared8 = GameObject.FindGameObjectWithTag("Pared 8");
        transformPared8 = Pared8.transform;
        Pared9 = GameObject.FindGameObjectWithTag("Pared 9");
        transformPared9 = Pared9.transform;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        checkPalancas();
        checkPinchos();
    }

    void checkPalancas()
    {
        if (transformJugador.localPosition.x > 137.52 && transformJugador.localPosition.x < 139.545 && transformJugador.localPosition.y > -59.17 && transformJugador.localPosition.y < 58.203 && Input.GetKeyDown(KeyCode.E))
        {
            if (pinchos1) pinchos1 = false;
            else pinchos1 = true;
        }

        if (transformJugador.localPosition.x > 148.65 && transformJugador.localPosition.x < 150.64 && transformJugador.localPosition.y > -59.17 && transformJugador.localPosition.y < 58.203 && Input.GetKeyDown(KeyCode.E))
        {
            if (pinchos2) pinchos2 = false;
            else pinchos2 = true;
        }

        if (transformJugador.localPosition.x > 173.75 && transformJugador.localPosition.x < 175.78 && transformJugador.localPosition.y > -59.17 && transformJugador.localPosition.y < 58.203 && Input.GetKeyDown(KeyCode.E))
        {
            if (pinchos3) pinchos3 = false;
            else pinchos3 = true;

            if (pinchos5) pinchos5 = false;
            else pinchos5 = true;
        }

        if (transformJugador.localPosition.x > 184.81 && transformJugador.localPosition.x < 186.83 && transformJugador.localPosition.y > -59.17 && transformJugador.localPosition.y < 58.203 && Input.GetKeyDown(KeyCode.E))
        {
            if (pinchos3) pinchos3 = false;
            else pinchos3 = true;

            if (pinchos4) pinchos4 = false;
            else pinchos4 = true;
        }

        if (transformJugador.localPosition.x > 195.883 && transformJugador.localPosition.x < 197.92 && transformJugador.localPosition.y > -59.17 && transformJugador.localPosition.y < 58.203 && Input.GetKeyDown(KeyCode.E))
        {
            if (pinchos4) pinchos4 = false;
            else pinchos4 = true;

            if (pinchos5) pinchos5 = false;
            else pinchos5 = true;
        }

        if (transformJugador.localPosition.x > 219.04 && transformJugador.localPosition.x < 221.065 && transformJugador.localPosition.y > -59.17 && transformJugador.localPosition.y < 58.203 && Input.GetKeyDown(KeyCode.E))
        {
            if (pinchos6) pinchos6 = false;
            else pinchos6 = true;

            if (pinchos7) pinchos7 = false;
            else pinchos7 = true;
        }

        if (transformJugador.localPosition.x > 232.11 && transformJugador.localPosition.x < 234.14 && transformJugador.localPosition.y > -59.17 && transformJugador.localPosition.y < 58.203 && Input.GetKeyDown(KeyCode.E))
        {
            if (pinchos8) pinchos8 = false;
            else pinchos8 = true;
        }

        if (transformJugador.localPosition.x > 243.185 && transformJugador.localPosition.x < 245.205 && transformJugador.localPosition.y > -59.17 && transformJugador.localPosition.y < 58.203 && Input.GetKeyDown(KeyCode.E))
        {
            if (pinchos8) pinchos8 = false;
            else pinchos8 = true;

            if (pinchos9) pinchos9 = false;
            else pinchos9 = true;
        }

        if (transformJugador.localPosition.x > 254.26 && transformJugador.localPosition.x < 256.27 && transformJugador.localPosition.y > -59.17 && transformJugador.localPosition.y < 58.203 && Input.GetKeyDown(KeyCode.E))
        {
            if (pinchos6) pinchos6 = false;
            else pinchos6 = true;
        }
    }

    void checkPinchos()
    {
        if (pinchos1)
        {
            transformPinchos.localPosition = new Vector3(transformPinchos.localPosition.x, yMin1, transformPinchos.localPosition.z);
            transformPared.localPosition = new Vector3(transformPared.localPosition.x, yMin2, transformPared.localPosition.z);
        }

        else
        {
            transformPinchos.localPosition = new Vector3(transformPinchos.localPosition.x, yMax1, transformPinchos.localPosition.z);
            transformPared.localPosition = new Vector3(transformPared.localPosition.x, yMax2, transformPared.localPosition.z);
        }

        if (pinchos2)
        {
            transformPinchos2.localPosition = new Vector3(transformPinchos2.localPosition.x, yMin1, transformPinchos2.localPosition.z);
            transformPared2.localPosition = new Vector3(transformPared2.localPosition.x, yMin2, transformPared2.localPosition.z);
        }

        else
        {
            transformPinchos2.localPosition = new Vector3(transformPinchos2.localPosition.x, yMax1, transformPinchos2.localPosition.z);
            transformPared2.localPosition = new Vector3(transformPared2.localPosition.x, yMax2, transformPared2.localPosition.z);
        }

        if (pinchos3)
        {
            transformPinchos3.localPosition = new Vector3(transformPinchos3.localPosition.x, yMin1, transformPinchos3.localPosition.z);
            transformPared3.localPosition = new Vector3(transformPared3.localPosition.x, yMin2, transformPared3.localPosition.z);
        }

        else
        {
            transformPinchos3.localPosition = new Vector3(transformPinchos3.localPosition.x, yMax1, transformPinchos3.localPosition.z);
            transformPared3.localPosition = new Vector3(transformPared3.localPosition.x, yMax2, transformPared3.localPosition.z);
        }

        if (pinchos4)
        {
            transformPinchos4.localPosition = new Vector3(transformPinchos4.localPosition.x, yMin1, transformPinchos4.localPosition.z);
            transformPared4.localPosition = new Vector3(transformPared4.localPosition.x, yMin2, transformPared4.localPosition.z);
        }

        else
        {
            transformPinchos4.localPosition = new Vector3(transformPinchos4.localPosition.x, yMax1, transformPinchos4.localPosition.z);
            transformPared4.localPosition = new Vector3(transformPared4.localPosition.x, yMax2, transformPared4.localPosition.z);
        }

        if (pinchos5)
        {
            transformPinchos5.localPosition = new Vector3(transformPinchos5.localPosition.x, yMin1, transformPinchos5.localPosition.z);
            transformPared5.localPosition = new Vector3(transformPared5.localPosition.x, yMin2, transformPared5.localPosition.z);
        }

        else
        {
            transformPinchos5.localPosition = new Vector3(transformPinchos5.localPosition.x, yMax1, transformPinchos5.localPosition.z);
            transformPared5.localPosition = new Vector3(transformPared5.localPosition.x, yMax2, transformPared5.localPosition.z);
        }

        if (pinchos6)
        {
            transformPinchos6.localPosition = new Vector3(transformPinchos6.localPosition.x, yMin1, transformPinchos6.localPosition.z);
            transformPared6.localPosition = new Vector3(transformPared6.localPosition.x, yMin2, transformPared6.localPosition.z);
        }

        else
        {
            transformPinchos6.localPosition = new Vector3(transformPinchos6.localPosition.x, yMax1, transformPinchos6.localPosition.z);
            transformPared6.localPosition = new Vector3(transformPared6.localPosition.x, yMax2, transformPared6.localPosition.z);
        }

        if (pinchos7)
        {
            transformPinchos7.localPosition = new Vector3(transformPinchos7.localPosition.x, yMin1, transformPinchos7.localPosition.z);
            transformPared7.localPosition = new Vector3(transformPared7.localPosition.x, yMin2, transformPared7.localPosition.z);
        }

        else
        {
            transformPinchos7.localPosition = new Vector3(transformPinchos7.localPosition.x, yMax1, transformPinchos7.localPosition.z);
            transformPared7.localPosition = new Vector3(transformPared7.localPosition.x, yMax2, transformPared7.localPosition.z);
        }

        if (pinchos8)
        {
            transformPinchos8.localPosition = new Vector3(transformPinchos8.localPosition.x, yMin1, transformPinchos8.localPosition.z);
            transformPared8.localPosition = new Vector3(transformPared8.localPosition.x, yMin2, transformPared8.localPosition.z);
        }

        else
        {
            transformPinchos8.localPosition = new Vector3(transformPinchos8.localPosition.x, yMax1, transformPinchos8.localPosition.z);
            transformPared8.localPosition = new Vector3(transformPared8.localPosition.x, yMax2, transformPared8.localPosition.z);
        }

        if (pinchos9)
        {
            transformPinchos9.localPosition = new Vector3(transformPinchos9.localPosition.x, yMin1, transformPinchos9.localPosition.z);
            transformPared9.localPosition = new Vector3(transformPared9.localPosition.x, yMin2, transformPared9.localPosition.z);
        }

        else
        {
            transformPinchos9.localPosition = new Vector3(transformPinchos9.localPosition.x, yMax1, transformPinchos9.localPosition.z);
            transformPared9.localPosition = new Vector3(transformPared9.localPosition.x, yMax2, transformPared9.localPosition.z);
        }
    }
}
