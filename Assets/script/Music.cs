﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Music : MonoBehaviour {

    // Use this for initialization

    public GameObject soundManager;


    public AudioClip play;
    public AudioClip boss;
    public AudioClip end;
    private AudioSource sources;

    void Awake()
    {
       

        DontDestroyOnLoad(soundManager);

       sources = gameObject.GetComponent<AudioSource>();

    }
    public void Startplay()
    {
        sources.clip = play;
        sources.Play();

    }
    public void endplay()
    {
        sources.clip = end;
        sources.Play();

    }
    public void Stop()
    {
        
        sources.Stop();

    }

    public void Startboss()
    {
        sources.clip = boss;
        sources.Play();
     
    }

   public void OnDisable()
    {
         StopAllCoroutines();
          if (gameObject.activeSelf)
              StartCoroutine(Fadeout());
      
       
    }
    void Update()
    {
        
        }

    IEnumerator Fadeout()
    {
        for (int i = 0; i < 100; i++)
        {
            sources.volume -= 0.01f;
            yield return null;
        }
        sources.volume = 0;
        if (sources.volume == 0)
        {
            sources.Stop();
            sources.volume = 1f;
        }
       
    }
    


}