using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position_Enemy : MonoBehaviour {

    public GameObject canonEnemy;
    public Transform transformCanonEnemy;

    public GameObject enemy;
    public Transform transformEnemy;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transformEnemy.localScale.x > 0)
        {
            transformCanonEnemy.localPosition = new Vector3(transformEnemy.localPosition.x + 1, transformEnemy.localPosition.y + 0.1f, transformEnemy.localPosition.z);
        }

        if (transformEnemy.localScale.x < 0)
        {
            transformCanonEnemy.localPosition = new Vector3(transformEnemy.localPosition.x - 1, transformEnemy.localPosition.y + 0.1f, transformEnemy.localPosition.z);
        }
    }
}
