using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tekiHantei2 : MonoBehaviour
{
    public int hidari = 0;
    public tekiHantei tekihantei;
    public tekiHantei1 tekihantei1;
    public tekiHantei3 tekihantei3;
    GameObject Teki;
    GameObject Teki1;
    GameObject Teki2;
    GameObject Teki3;

    int m = 0;
    int s = 0;
    int u = 0;





    void Start()
    {
        Teki = GameObject.Find("TEKI_9/hanteiM");

        Teki1 = GameObject.Find("TEKI_9/hanteiS");
        Teki3 = GameObject.Find("TEKI_9/hanteiU");

        tekihantei = Teki.GetComponent<tekiHantei>();
        tekihantei1 = Teki1.GetComponent<tekiHantei1>();
        tekihantei3 = Teki3.GetComponent<tekiHantei3>();

        m = tekihantei.migi;
        s = tekihantei1.sita;
        u = tekihantei3.ue;
    }

    void Update()
    {
        if (hidari == 1)
        {
            tekihantei.count += 1;
        }
     
        //  sita = 0;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "player" && tekihantei.count > 300 )
        {
           
                hidari = 1;
                tekihantei.migi = 0;
                tekihantei1.sita = 0;
                tekihantei3.ue = 0;
            tekihantei.count = 0;
        }
            
    }

}