﻿using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Animator))]

public class anime : MonoBehaviour
{
    // 移動スピード
    public float speed = 4;
  public  int x = 0;
  public  int y = 0;
    public int xx = 0;
    public int yy = 0;
    private Animator Anim;
    public warp warpp;
    public player playerr;
    private text textt;
    int count = 0;
    public bool Camera_Flag = false;
    public GameObject Player;
    public hebi hebii;
    int Hebi_hosuu = 0;
    void Awake()
    {
        Player = GameObject.Find("Player");
        Anim = GetComponent<Animator>();
        textt = GetComponent<text>();

    }

    // Update is called once per frame
    void Update()
    {

        if (textt.Text_Flag==true)
        {
            x = 0; y = 0;
            Anim.SetFloat("stop", 1f);
        }
      else  if (Camera_Flag == true&& hebii.Kougeki == false)
        {
            Anim.SetFloat("rotationx", 0f);
            Anim.SetFloat("rotationy", 1f);
            transform.Translate(0, Time.deltaTime, 0);
            Anim.SetFloat("stop", -1f);
            x = 0; y = 1;
            xx = 0; yy = 1;
         
        }
      
     else   if  (Input.GetKey(KeyCode.UpArrow)&&warpp.riset == 1)
        {

           

            Anim.SetFloat("stop", 1f);
            Anim.SetFloat("rotationx", 0f);
            Anim.SetFloat("rotationy", -1f);
            warpp.keep = 0;

          
        }
     


        else  if (Input.GetKey(KeyCode.RightArrow))
        {
            Anim.SetFloat("rotationx", 1f);
            Anim.SetFloat("rotationy", 0f);
            transform.Translate(Time.deltaTime, 0, 0);
            Anim.SetFloat("stop", -1f);
            x = 1; y = 0;
            xx = 1;yy = 0;
         
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Anim.SetFloat("rotationx", -1f);
            Anim.SetFloat("rotationy", 0f);
            transform.Translate(-Time.deltaTime, 0, 0);
            Anim.SetFloat("stop", -1f);
            x = -1; y = 0;
            xx = -1;yy = 0;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            Anim.SetFloat("rotationx", 0f);
            Anim.SetFloat("rotationy", 1f);
            transform.Translate(0, Time.deltaTime, 0);
            Anim.SetFloat("stop", -1f);
            x = 0; y = 1;
            xx = 0;yy = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Anim.SetFloat("rotationx", 0f);
            Anim.SetFloat("rotationy", -1f);
            transform.Translate(0, -Time.deltaTime, 0);
            Anim.SetFloat("stop", -1f);
            x = 0; y = -1;
            xx = 0; yy = -1;
        }
        else {
           
            x = 0; y = 0;
            Anim.SetFloat("stop", 1f);
            warpp.riset = 0;
         
        }
        
        Vector2 direction = new Vector2(x, y).normalized;
        // 移動する向きとスピードを代入する
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}