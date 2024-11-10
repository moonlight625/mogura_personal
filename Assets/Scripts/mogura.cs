using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class mogura : MonoBehaviour
{
    private float time;
    private float speed = 1.0f;
    public float lifespan = 2.0f;
    
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
            pos.y += speed * Time.deltaTime;
            if (pos.y >= 0.9f)
            {
                pos.y = 0.9f;
            }
        }else if (time < lifespan)
        {
            pos.y -= speed * Time.deltaTime;
        }
        else
        {
            Destroy(this.gameObject);
        }

        transform.position = pos;
    }
}
