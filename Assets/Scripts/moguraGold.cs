using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class moguraGold : MonoBehaviour
{
    private float time;
    public float range = 0.8f;
    public float lifespan = 2.0f;

    public ParticleSystem hitEffect;
    // Start is called before the first frame update
    void Start()
    {
        GameObject manager = GameObject.Find("Manager");
                           
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        Vector3 pos = transform.position;
        if (time < lifespan/2)
        {
            pos.y += range/lifespan * Time.deltaTime;
            if (pos.y >= range)
            {
                pos.y = range;
            }
        }else if (time < lifespan)
        {
            pos.y -= range/lifespan * Time.deltaTime;
        }
        else
        {
            Destroy(this.gameObject);
        }

        transform.position = pos;
    }
}