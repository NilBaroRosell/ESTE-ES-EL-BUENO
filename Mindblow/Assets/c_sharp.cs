using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_sharp : MonoBehaviour {


	public Transform NAVE;
    public Transform canon;
	public GameObject SquarePrefab;
	public GameObject EspadaPrefab;
    public float cooldown;
    float desiredTime;

    public AudioClip sonidoDisparo;
    public AudioSource fuenteDeAudioDisparo;
    public AudioClip sonidoEspada;
    public AudioSource fuenteDeAudioEspada;

    // Use this for initialization
    void Start () {
        fuenteDeAudioDisparo = GetComponent<AudioSource>();
        fuenteDeAudioEspada= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
		playerShoot ();
		playerSword ();
		NAVE.localRotation = Quaternion.Euler (0,0,0);
        desiredTime += Time.deltaTime;
    }

    //Com l'Update peró amb un temps d'execució més curt. S'utilitza per les físiques
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 0));
			transform.localScale = new Vector3 (-1, 1, 1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(1, 0));
			transform.localScale = new Vector3 (1, 1, 1);
        }
    }



	public void playerShoot()
	{
		if(Input.GetButtonDown("Fire1") && (desiredTime >= cooldown))
		{
			Instantiate (SquarePrefab, canon.position, canon.rotation);
            desiredTime = 0;
            fuenteDeAudioDisparo.clip = sonidoDisparo;
            fuenteDeAudioDisparo.Play();
        }
	}

	public void playerSword()
	{
		if(Input.GetButtonDown("Fire2"))
		{
			Instantiate (EspadaPrefab, canon.position, canon.rotation);
            fuenteDeAudioEspada.clip = sonidoEspada;
            fuenteDeAudioEspada.Play();
        }
	}
}
