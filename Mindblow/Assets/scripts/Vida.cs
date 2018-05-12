using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour {

    public GameObject Player;
    private PlayerManager getDamage;

    public Image vida;
    public float numVida;

    private void Awake()
    {

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        getDamage = Player.GetComponent<PlayerManager>();
        numVida = getDamage.Vida;
        vida.fillAmount = numVida / 100;
    }

    //private void FixedUpdate()
    //{
    //    PlayerManager getDamage = GetComponent<PlayerManager>();
    //    numVida = getDamage.Vida;
    //    vida.fillAmount = numVida / 100;
    //    print(numVida);
    //}
}
