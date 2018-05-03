using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position_Enemy_7 : MonoBehaviour {

    public GameObject canonEnemy7;
    public Transform transformCanonEnemy7;

    public GameObject enemy7;
    public Transform transformEnemy7;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transformEnemy7.localScale.x > 0)
        {
            transformCanonEnemy7.localPosition = new Vector3(transformEnemy7.localPosition.x + 1, transformEnemy7.localPosition.y + 0.1f, transformEnemy7.localPosition.z);
        }

        if (transformEnemy7.localScale.x < 0)
        {
            transformCanonEnemy7.localPosition = new Vector3(transformEnemy7.localPosition.x - 1, transformEnemy7.localPosition.y + 0.1f, transformEnemy7.localPosition.z);
        }
    }
}
