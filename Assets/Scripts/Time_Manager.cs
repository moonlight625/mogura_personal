using System;
using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.PoseDetection;
using UnityEngine;

public class Time_Manager : MonoBehaviour
{
    private float timelimit = 30.0f;

    private GameObject manager;
    private bool isGame = false;
    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
        Time_static.time = 0;
        manager = this.gameObject;
        manager.GetComponent<Mogura_Manager>().setGame(true);
        isGame = false;

        _audioSource = manager.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGame)
        {
            Time_static.time += Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        if (Time_static.time >= timelimit)
        {
            manager.GetComponent<Mogura_Manager>().setGame(false);
            isGame = false;
            _audioSource.PlayOneShot(_audioSource.clip);
        }
    }

    public void initGame()
    {
        Time_static.time = 0;
        Score_static.score = 0;
        manager.GetComponent<Mogura_Manager>().setGame(true);
        isGame = true;
        _audioSource.PlayOneShot(_audioSource.clip);
    }
    
}
