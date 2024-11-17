using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{

    public TextMeshPro score;
    public TextMeshPro time;

    private void Start()
    {
        Score_static.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + Score_static.score;
        time.text = (30.0f - Time_static.time).ToString("F1");
    }
    
}
