using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole : MonoBehaviour
{
    public GameObject mog;
    
    public void spawn()
    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;
        pos.y -= 1.0f;
        Instantiate(mog, pos, rot);
    }
}
