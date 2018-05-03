using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_sharp3 : MonoBehaviour {
    public GameObject enemyPrefab;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 5; i++)
        {
            GameObject.Instantiate(enemyPrefab);
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
