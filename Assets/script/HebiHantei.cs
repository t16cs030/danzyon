using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HebiHantei : MonoBehaviour
{

   public  int flag = 0;
    public int count = 0;
    public hebi hebii;

    public GameObject tekiBullet;

    void Start()
    {
        
    }

    void Update()
    {
       
        if (flag == 1 && count >= 150&&hebii.Kougeki==true&& hebii.Death_Anime ==false )
        {
            for (int i = 0; i < 3; i++) { 
            Instantiate(tekiBullet, transform.position, transform.GetChild(i).rotation);
        }
            count = 0;
        }
    


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "player")
        {
            flag = 1;
            count++;
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