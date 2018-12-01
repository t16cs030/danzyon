using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tekiHantei1 : MonoBehaviour
{
    public int  sita= 0;
    public tekiHantei tekihantei;
    public tekiHantei2 tekihantei2;
    public tekiHantei3 tekihantei3;
    GameObject Teki;
    GameObject Teki1;
    GameObject Teki2;
    GameObject Teki3;

    int m = 0;
    int h = 0;
    int u = 0;
    

   


    void Start()
    {
        Teki = GameObject.Find("TEKI_9/hanteiM");

        Teki2 = GameObject.Find("TEKI_9/hanteiH");
        Teki3 = GameObject.Find("TEKI_9/hanteiU");

        tekihantei = Teki.GetComponent<tekiHantei>();
        tekihantei2 = Teki2.GetComponent<tekiHantei2>();
        tekihantei3 = Teki3.GetComponent<tekiHantei3>();

         m = tekihantei.migi;
         h = tekihantei2.hidari;
         u = tekihantei3.ue;
    }
   
void Update()
    {
        //  sita = 0;
        if (sita == 1)
        {
           tekihantei.count+=1;
        }
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "player" && tekihantei.count > 100 )
        {
         
                sita = 1;
                tekihantei.migi = 0;
                tekihantei2.hidari = 0;
                tekihantei3.ue = 0;
            tekihantei.count = 0;

        }
    }

}