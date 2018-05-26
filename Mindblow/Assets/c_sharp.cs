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
    private Animator myAnimator;
    bool disparo, golpe;

    // Use this for initialization
    void Start () {
        fuenteDeAudioDisparo = GetComponent<AudioSource>();
        fuenteDeAudioEspada= GetComponent<AudioSource>();
        myAnimator = GetComponent<Animator>();
        disparo = false;
        golpe = false;
    }

    // Update is called once per frame
    void Update()
    {
		playerShoot ();
		playerSword ();
        if (NAVE.localScale.x > 0) NAVE.localScale = new Vector3(0.5335937f, 0.5619395f, 1);
        if (NAVE.localScale.x < 0) NAVE.localScale = new Vector3(-0.5335937f, 0.5619395f, 1);
        NAVE.localRotation = Quaternion.Euler (0,0,0);
        desiredTime += Time.deltaTime;
        myAnimator.SetBool("Disparo", disparo);
        myAnimator.SetBool("Golpe", golpe);
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
        if (Input.GetButtonDown("Fire1") && (desiredTime >= cooldown))
        {
            disparo = true;
            Instantiate(SquarePrefab, canon.position, canon.rotation);
            desiredTime = 0;
            fuenteDeAudioDisparo.clip = sonidoDisparo;
            fuenteDeAudioDisparo.Play();
        }

        else disparo = false;
	}

	public void playerSword()
	{
        if (Input.GetButtonDown("Fire2"))
        {
            golpe = true;
            Instantiate(EspadaPrefab, canon.position, canon.rotation);
            fuenteDeAudioEspada.clip = sonidoEspada;
            fuenteDeAudioEspada.Play();
        }

        else golpe = false;
	}
}
