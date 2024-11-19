using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//使いません
public class EffectManeger : MonoBehaviour
{
    public ParticleSystem effect;
    // Start is called before the first frame update
    void Start()
    {
        effect.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this);
    }
}
