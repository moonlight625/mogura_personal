using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{

    public TextMeshPro score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + Score_static.score;
    }
}
