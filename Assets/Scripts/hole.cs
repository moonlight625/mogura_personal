using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole : MonoBehaviour
{
    public GameObject mog;
    public GameObject bomb;
    public GameObject gold;
    
    public void spawn()
    {
        switch (Random.Range(0,5))
        {
            case 0: 
                spawn_gold();
                break;
            case 1:
                spawn_bomb();
                break;
            default:
                spawn_mogura();
                break;
        }
    }

    private void spawn_mogura()
    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;
        pos.y -= 0.45f;
        Instantiate(mog, pos, rot);
    }
    
    private void spawn_bomb()
    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;
        pos.y -= 0.45f;
        Instantiate(bomb, pos, rot);
    }
    
    private void spawn_gold()
    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;
        pos.y -= 0.45f;
        Instantiate(gold, pos, rot);
    }
    
}
