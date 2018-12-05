using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TekiHantei : MonoBehaviour
{

     int flag = 0;
    public int count ;

    public GameObject tekiBullet;

    void Start()
    {
        count = 11;
    }

    void Update()
    {
        count++;

        if (flag == 1&& count>=10)
        {
            Instantiate(tekiBullet, transform.position, transform.rotation);

            count = 0;
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "player")
        {
            flag = 1;
 
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "player")
        {
            flag = 0;

        }
    }

}