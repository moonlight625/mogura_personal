using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class Mogura_Manager : MonoBehaviour
{
    public GameObject[] holes;
    
    private float cooltime = 2.0f;
    private float time;

    private void Start()
    {
        holes = GameObject.FindGameObjectsWithTag("Hole");
        if (holes.Length == 0)
        {
            Debug.Log("No hole was found");
        }

        time = 0.0f;
    }

    private void Update()
    {
        time += Time.deltaTime;
    }

    private void FixedUpdate()
    {
        if (time >= cooltime)
        {
            int i = Random.Range(0, holes.Length - 1);
            hole h = holes[i].GetComponent<hole>();
            h.spawn();
            
            int j = Random.Range(0, holes.Length - 1);
            while (i == j)
            {
                j = Random.Range(0, holes.Length - 1);
            }
            h = holes[j].GetComponent<hole>();
            h.spawn();
            time = 0.0f;
        }
    }
}
