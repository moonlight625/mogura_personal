using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;

public class Hammer_Controller : MonoBehaviour
{
    
    public int score_mogura = 1;
    public int score_gold = 2;
    public int score_bomb = -3;
    private AudioSource audioSource;

    public AudioSource audioSouse;
    public AudioClip se_mog;
    public AudioClip se_bom;
    public AudioClip se_gol;

    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mogura")
        {
            Debug.Log("Hit");
            Score_static.score += score_mogura;
            audioSource.PlayOneShot(se_mog);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "gold")
        {
            Debug.Log("Hit");
            Score_static.score += score_gold;
            audioSource.PlayOneShot(se_gol);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "bomb")
        {
            Debug.Log("Hit");
            Score_static.score += score_bomb;
            audioSource.PlayOneShot(se_bom);
            Destroy(other.gameObject);
        }   
        if (other.gameObject.tag == "Start")
        {
            audioSource = other.GetComponent<AudioSource>();
            //audioSource.PlayOneShot(audioSource.clip);
            other.gameObject.GetComponent<Time_Manager>().initGame();
        }
    }
}
