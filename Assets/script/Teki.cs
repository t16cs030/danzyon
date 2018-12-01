using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teki : MonoBehaviour
{
   public GameObject bullet;
    public GameObject Player;

    // Use this for initialization
    int count = 0;
    int flag = 0;
    public tekiHantei tekihantei;
    GameObject teki;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "player")
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
       
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "player")
        {
            flag = 1;
        }

    }



    void Start()
    {


        teki = GameObject.Find("TEKI_9/hanteiM");
        tekihantei = teki.GetComponent<tekiHantei>();
    }

    void Update()
    {
        if (flag == 1)
        {
            count++;
            if (count > 100&&tekihantei.count>100)
            {
                Instantiate(bullet, transform.position, transform.rotation);
                count = 0;
            }
        }



    }
}