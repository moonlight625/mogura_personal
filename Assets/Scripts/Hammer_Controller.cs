using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer_Controller : MonoBehaviour
{
    
    Quaternion rot0;
    Vector3 pos0;
    // Start is called before the first frame update
    void Start()
    {
        rot0 = transform.localRotation;
        pos0 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rot = transform.localRotation;
        
        Vector3 pos = transform.position;
        
        
        if (Input.GetKeyDown("space"))
        {
            //Debug.Log("down");
            rot.z += 30.0f;
            pos.z += 1.0f;
            rot0 = transform.rotation;
            pos0 = transform.position;
        }

        if (Input.GetKeyUp("space"))
        {
            //Debug.Log("up");
            
            rot = rot0;
            pos = pos0;
        }

        transform.localRotation = rot;
        transform.position = pos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mogura")
        {
            Debug.Log("Hit");
            Score_static.score += 1;
            Destroy(other.gameObject);
        }
    }
}
